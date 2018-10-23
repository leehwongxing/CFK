using CFK_API.Models;
using Dapper;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace CFK_API.Services
{
    public interface ITokenService
    {
        Models.Projections.Token CreateUserToken(
            User user,
            int Store_ID = -1);

        Models.Projections.Token CreateCustomerToken(
            Customer customer);

        IEnumerable<Token> GetTokens(
            long Ref_SID,
            bool IsCustomer = true);

        bool UpdateToken(
            long Token_ID,
            string Content = "");

        bool RemoveOldToken(
            long Ref_SID,
            bool IsCustomer = true,
            long Exception = -1);

        bool DeleteToken(
            long Token_ID);

        Token GetToken(
            long Token_ID);
    }

    public class TokenService : ITokenService
    {
        private IDbContainer Container { get; set; }
        private JWT JwtConfig { get; set; }
        private IRoleService Roles { get; set; }

        private readonly string Create
            = @"INSERT INTO Dim_Tokens VALUES ('', @Origin, @CreatedAt, @ValidUntil, @Ref_SID, @IsCustomer); SELECT CAST(SCOPE_IDENTITY() as bigint)";

        private readonly string Delete
            = @"DELETE FROM Dim_Tokens WHERE Token_ID = @Token_ID";

        private readonly string Update
            = @"UPDATE Dim_Tokens SET Content = @Content WHERE Token_ID = @Token_ID";

        private readonly string SelectOnes
            = @"SELECT * FROM Dim_Tokens WHERE Ref_SID = @Ref_SID and IsCustomer = @IsCustomer";

        private readonly string Select
             = @"SELECT * FROM Dim_Tokens WHERE Token_ID = @Token_ID";

        private readonly string RemoveOld =
            @"DELETE FROM Dim_Tokens WHERE Ref_SID = @Ref_SID and IsCustomer = @IsCustomer and Token_ID != @Exception";

        public TokenService(
            IDbContainer container,
            IOptions<JWT> config,
            IRoleService roles)
        {
            Container = container;
            JwtConfig = config.Value;
            Roles = roles;
        }

        private string CreateToken(
            HashSet<string> Roles,
            long Ref_SID,
            long Token_ID = -1,
            int Store_ID = -1)
        {
            var _CreatedAt = Compute.Time.UnixNow;
            if (Roles.Count() == 0)
            {
                Roles = new HashSet<string>
                {
                    "CUSTOMER"
                };
            }

            if (Ref_SID < 0)
            {
                throw new Exception("Invalid Ref_SID, must be greater than 0");
            }

            var Handler = new JwtSecurityTokenHandler();
            var Key = Encoding.UTF8.GetBytes(JwtConfig.Key);

            // Adding Roles and stuffs into JWT Token
            var Claims = new ClaimsIdentity(new Claim[] {
                    new Claim(ClaimTypes.PrimarySid, Ref_SID.ToString()),
                    new Claim(ClaimTypes.UserData, Token_ID.ToString())
                });

            if (Store_ID > 0)
                Claims.AddClaim(new Claim(ClaimTypes.PrimaryGroupSid, Store_ID.ToString()));

            foreach (string Role in Roles)
            {
                Claims.AddClaim(new Claim(ClaimTypes.Role, Role));
            }

            var Descriptor = new SecurityTokenDescriptor
            {
                Subject = Claims,
                IssuedAt = Compute.Time.FromUnix(_CreatedAt),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Key), SecurityAlgorithms.HmacSha256Signature),
                Expires = Compute.Time.FromUnix(_CreatedAt).AddDays(JwtConfig.TTL),
                Issuer = JwtConfig.Issuer,
                Audience = JwtConfig.Audience,
            };

            return Handler.CreateEncodedJwt(Descriptor);
        }

        public Models.Projections.Token CreateUserToken(
            User user,
            int Store_ID = -1)
        {
            if (user == null)
            {
                return null;
            }
            var _Roles = Roles.GetOneRoleIDs(user.User_ID, Store_ID);
            var _CreatedAt = Compute.Time.UnixNow;
            var _ExpireOn = Compute.Time.UnixAt(DateTime.UtcNow.AddDays(JwtConfig.TTL));

            var _Token = new Token
            {
                Ref_SID = user.User_ID,
                Origin = JwtConfig.Issuer,
                CreatedAt = _CreatedAt,
                IsCustomer = false,
                ValidUntil = _ExpireOn,
                Content = ""
            };

            _Token.Token_ID = Container.Connect().Query<long>(Create, _Token).Single();

            var _UserToken = CreateToken(new HashSet<string>(_Roles), _Token.Ref_SID, _Token.Token_ID, Store_ID);

            return new Models.Projections.Token
            {
                Ref_SID = user.User_ID,
                FullName = user.FullName,
                CreatedAt = Compute.Time.FromUnix(_CreatedAt),
                ValidUntil = Compute.Time.FromUnix(_ExpireOn),
                Content = _UserToken
            };
        }

        public Models.Projections.Token CreateCustomerToken(Customer customer)
        {
            return null;
        }

        public bool DeleteToken(
            long Token_ID)
        {
            return Container.Connect().Execute(Delete, new { Token_ID }) > 0 ? true : false;
        }

        public bool UpdateToken(
            long Token_ID,
            string Content = "")
        {
            return Container.Connect().Execute(Update, new { Token_ID, Content }) > 0 ? true : false;
        }

        public Token GetToken(
            long Token_ID)
        {
            try
            {
                return Container.Connect().Query<Token>(Select, new { Token_ID }).Single();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public bool RemoveOldToken(
            long Ref_SID,
            bool IsCustomer = true,
            long Exception = -1)
        {
            if (Ref_SID < 0)
            {
                throw new Exception("Invalid Ref_SID, must be greater than 0");
            }

            return Container
                .Connect()
                .Execute(RemoveOld, new { Ref_SID, IsCustomer, Exception }) > 0 ? true : false;
        }

        public IEnumerable<Token> GetTokens(
            long Ref_SID,
            bool IsCustomer)
        {
            return Container.Connect().Query<Token>(SelectOnes, new { Ref_SID, IsCustomer });
        }
    }
}
