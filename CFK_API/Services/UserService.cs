using CFK_API.Models;
using Dapper;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace CFK_API.Services
{
    public interface IUserService
    {
        User Create(string Email, string Password, string FullName, int Creator_ID);

        Models.Projections.Token Authenticate(string Email, string Password);

        bool Lock(int User_ID = -1);

        User GetOne(int User_ID = -1);
    }

    public class UserService : IUserService
    {
        private IDbContainer Container;

        public UserService(IDbContainer container)
        {
            Container = container;
        }

        private readonly string CreateUser
            = @"INSERT INTO Dim_Users VALUES ( @FullName, @Email, @Password, '', 0, @CreatedAt, @CreatedBy); SELECT CAST(SCOPE_IDENTITY() as int)";

        private readonly string GetUser
            = @"SELECT * FROM Dim_Users WHERE User_ID = @User_ID";

        public Models.Projections.Token Authenticate(string Email, string Password)
        {
            throw new NotImplementedException();
        }

        public User Create(string Email, string Password, string FullName, int Creator_ID)
        {
            Password = Compute.Hash.Saltier(Password, Container.Config.Salt);
            User _User = null;

            try
            {
                _User = new User
                {
                    Email = Email,
                    Password = Password,
                    FullName = FullName,
                    CreatedBy = Creator_ID
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

        public User GetOne(int User_ID = -1)
        {
            return Container.Connect().Query<User>(GetUser, new { User_ID }).Single();
        }

        public bool Lock(int User_ID = -1)
        {
            throw new NotImplementedException();
        }
    }
}
