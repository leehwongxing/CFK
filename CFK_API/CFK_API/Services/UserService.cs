using CFK_API.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace CFK_API.Services
{
    public interface IUserService
    {
        User Create(
            string Email,
            string Password,
            string FullName,
            long Creator_ID = -1);

        Models.Projections.Token Authenticate(
            string Email,
            string Password,
            int Store_ID = -1);

        bool Lock(
            long User_ID);

        object GetOne(
            long User_ID,
            IEnumerable<string> fields);
    }

    public class UserService : IUserService
    {
        private IDbContainer Container { get; set; }
        private ITokenService Tokens { get; set; }

        public UserService(IDbContainer container, ITokenService tokens)
        {
            Container = container;
            Tokens = tokens;
        }

        private readonly string FindUser
            = @"SELECT * FROM Dim_Users WHERE Email = @Email AND Password = @Password";

        private readonly string CreateUser
            = @"INSERT INTO Dim_Users VALUES ( @FullName, @Email, @Password, '', 0, @CreatedAt, @CreatedBy); SELECT CAST(SCOPE_IDENTITY() as int)";

        private readonly string GetUser
            = @"SELECT @Fields FROM Dim_Users WHERE User_ID = @User_ID";

        private readonly string LockUser
            = @"UPDATE Dim_Users SET IsLocked = 1 WHERE User_ID = @User_ID";

        public Models.Projections.Token Authenticate(
            string Email,
            string Password,
            int Store_ID = -1)
        {
            if (string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Password))
            {
                return null;
            }

            var _Input = new
            {
                Email,
                Password = Compute.Hash.Saltier(Password, Container.Config.Salt)
            };

            var _User = Container.Connect().Query<User>(FindUser, _Input).Single();

            if (_User.IsLocked)
            {
                return null;
            }
            else
            {
                return Tokens.CreateUserToken(
                    _User,
                    Store_ID);
            }
        }

        public User Create(
            string Email,
            string Password,
            string FullName,
            long Creator_ID = -1)
        {
            Password = Compute.Hash.Saltier(
                Password,
                Container.Config.Salt);
            User _User = null;

            try
            {
                _User = new User
                {
                    Email = Email,
                    Password = Password,
                    FullName = FullName,
                    Ref_User = Creator_ID
                };
            }
            catch (ValidationException e)
            {
                Console.WriteLine(e);
                return null;
            }

            _User.User_ID = Container.Connect().Query<int>(CreateUser, _User).Single();

            return _User;
        }

        public object GetOne(long User_ID, IEnumerable<string> fields)
        {
            return Container.Connect().Query<User>(GetUser, new { User_ID }).Single();
        }

        public bool Lock(long User_ID)
        {
            return Container.Connect().Execute(LockUser, new { User_ID }) > 0 ? true : false;
        }
    }
}
