using CFK_API.Models;
using Dapper;
using CFK_API.Models.Projections;
using System.Linq;
using System;

namespace CFK_API.Services
{
    public interface ICustomerService
    {
        Models.Projections.Token Register(Registry registry);

        Models.Projections.Token SignIn(string Email, string Password);

        bool SignOut();

        Models.Customer GetOne(long Customer_ID);

        bool LockOne(long Customer_ID);
    }

    public class CustomerService : ICustomerService
    {
        private IDbContainer Container { get; set; }

        private ITokenService Tokens { get; set; }

        private readonly string Get
            = @"SELECT * FROM Dim_Customers WHERE Customer_ID = @Customer_ID";

        private readonly string Lock
            = @"UPDATE Dim_Customers SET IsLocked = 1 WHERE Customer_ID = @Customer_ID";

        private readonly string Create
            = @"INSERT INTO Dim_Customers VALUES (@Username, @Email, @Password, @FullName, @Gender, @Birthday, @Phone, @VerifiedAt, @Ref_Avatar, @Ref_Profile, 0)";

        public CustomerService(IDbContainer container, ITokenService tokens)
        {
            Container = container;
            Tokens = tokens;
        }

        public Customer GetOne(long Customer_ID)
        {
            if (Customer_ID < 0)
            {
                throw new Exception("Invalid Customer_ID, must be greater than 0");
            }
            return Container.Connect().Query<Customer>(Get, new { Customer_ID }).Single();
        }

        public bool LockOne(long Customer_ID)
        {
            if (Customer_ID < 0)
            {
                throw new Exception("Invalid Customer_ID, must be greater than 0");
            }
            return Container.Connect().Execute(Lock, new { Customer_ID }) > 0 ? true : false;
        }

        public Models.Projections.Token Register(
            Registry registry)
        {
            throw new NotImplementedException();
        }

        public Models.Projections.Token SignIn(string email, string password)
        {
            throw new NotImplementedException();
        }

        public bool SignOut()
        {
            throw new NotImplementedException();
        }
    }
}
