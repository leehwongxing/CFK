using CFK_API.Models;
using Dapper;
using System;
using System.Linq;

namespace CFK_API.Services
{
    public interface IUserService
    {
        User Create(string Email, string Password, string FullName, int Creator_ID);

        UserExt Authenticate(string Email, string Password);

        bool Lock(int User_ID = -1);

        User GetOne(int User_ID = -1);
    }

    public class UserService : IUserService
    {
        private readonly IDbContainer Container;

        public UserService(IDbContainer container)
        {
            Container = container;
        }

        public UserExt Authenticate(string Email, string Password)
        {
            throw new NotImplementedException();
        }

        public User Create(string Email, string Password, string FullName, int Creator_ID)
        {
            Password = Compute.Hash.Saltier(Password, Container.Config.Salt);

            var _User = new User
            {
                Email = Email,
                Password = Password,
                FullName = FullName,
                CreatedBy = Creator_ID
            };

            _User.User_ID = Container.Connect().Query<int>("INSERT INTO Dim_Users VALUES ( @FullName, @Email, @Password, '', 0, @CreatedAt, @CreatedBy); SELECT CAST(SCOPE_IDENTITY() as int)", _User).Single();

            return _User;
        }

        public User GetOne(int User_ID = -1)
        {
            throw new NotImplementedException();
        }

        public bool Lock(int User_ID = -1)
        {
            throw new NotImplementedException();
        }
    }
}
