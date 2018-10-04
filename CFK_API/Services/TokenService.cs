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
        Models.Projections.Token CreateToken(int User_ID = -1, int Store_ID = -1);

        IEnumerable<Token> GetTokens(int User_ID = -1);

        bool UpdateToken(long Token_ID = -1, string Content = "");

        bool DeleteToken(long Token_ID = -1);

        Token GetToken(long Token_ID = -1);
    }

    public class TokenService : ITokenService
    {
        private IDbContainer Container { get; set; }
        private JWT JwtConfig { get; set; }
        private IUserService Users { get; set; }
        private IRoleService Roles { get; set; }

        private readonly string Create
            = @"INSERT INTO Dim_Tokens VALUES (@User_ID, '', @Origin, @CreatedAt); SELECT CAST(SCOPE_IDENTITY() as bigint)";

        private readonly string Delete
            = @"DELETE FROM Dim_Tokens WHERE Token_ID = @Token_ID";

        private readonly string Update
            = @"UPDATE Dim_Tokens SET Content = @Content WHERE Token_ID = @Token_ID";

        private readonly string SelectOnes
            = @"SELECT * FROM Dim_Tokens WHERE User_ID = @User_ID";

        private readonly string Select
             = @"SELECT * FROM Dim_Tokens WHERE Token_ID = @Token_ID";

        public TokenService(IDbContainer container, IOptions<JWT> config, IUserService users, IRoleService roles)
        {
            Container = container;
            JwtConfig = config.Value;
            Users = users;
            Roles = roles;
        }

        public Models.Projections.Token CreateToken(int User_ID = -1, int Store_ID = -1)
        {
            var _User = Users.GetOne(User_ID);
            var _Roles = Roles.GetRoles(User_ID, Store_ID);
            var _CreatedAt = Compute.Time.UnixNow;

            if (_User == null)
            {
                return null;
            }

            var _Token = new Token
            {
                User_ID = User_ID,
                Origin = JwtConfig.Issuer,
                CreatedAt = _CreatedAt,
                Content = ""
            };

            _Token.Token_ID = Container.Connect().Query<long>(Create, _Token).Single();

            var Handler = new JwtSecurityTokenHandler();
            var Key = Encoding.UTF8.GetBytes(JwtConfig.Key);

            // Adding Roles and stuffs into JWT Token
            var Claims = new ClaimsIdentity(new Claim[] {
                    new Claim(ClaimTypes.PrimarySid, User_ID.ToString()),
                    new Claim(ClaimTypes.PrimaryGroupSid, Store_ID.ToString()),
                    new Claim(ClaimTypes.UserData, _Token.Token_ID.ToString())
                });

            foreach (var _role in _Roles)
            {
                Claims.AddClaim(new Claim(ClaimTypes.Role, _role.Role_ID));
            }

            // Adding the basic stuffs to the Tokens's content
            var Descriptor = new SecurityTokenDescriptor
            {
                Subject = Claims,
                IssuedAt = Compute.Time.FromUnix(_CreatedAt),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Key), SecurityAlgorithms.HmacSha256Signature),
                Expires = Compute.Time.FromUnix(_CreatedAt).AddDays(JwtConfig.TTL),
                Issuer = JwtConfig.Issuer,
                Audience = JwtConfig.Audience,
            };

            var _UserToken = Handler.CreateEncodedJwt(Descriptor);

            return new Models.Projections.Token
            {
                User_ID = User_ID,
                Store_ID = Store_ID,
                FullName = _User.FullName,
                CreatedAt = Compute.Time.FromUnix(_CreatedAt),
                ExpireOn = Compute.Time.FromUnix(_CreatedAt).AddDays(JwtConfig.TTL),
                Content = _UserToken
            };
        }

        public bool DeleteToken(long Token_ID = -1)
        {
            return Container.Connect().Execute(Delete, new { Token_ID }) > 0 ? true : false;
        }

        public IEnumerable<Token> GetTokens(int User_ID = -1)
        {
            return Container.Connect().Query<Token>(SelectOnes, new { User_ID });
        }

        public bool UpdateToken(long Token_ID = -1, string Content = "")
        {
            return Container.Connect().Execute(Update, new { Token_ID, Content }) > 0 ? true : false;
        }

        public Token GetToken(long Token_ID = -1)
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
    }
}
