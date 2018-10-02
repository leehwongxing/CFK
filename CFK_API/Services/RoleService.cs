using CFK_API.Models;
using System;
using System.Collections.Generic;
using Dapper;
using System.Linq;
using System.Threading.Tasks;

namespace CFK_API.Services
{
    public interface IRoleService
    {
        Role Create(string Role_ID = "", string RoleName = "", bool IsGlobal = false);

        IEnumerable<Role> GetRoles(int User_ID = -1, int Store_ID = -1);
    }

    public class RoleService : IRoleService
    {
        private readonly string CreateRole
            = @"INSERT INTO Dim_Roles VALUES (@Role_ID, @RoleName, @IsGlobal)";

        private string GetOneRoles(bool HasUserID = true, bool HasStoreID = true)
            => string.Concat("SELECT * FROM User_Roles WHERE ", (HasUserID ? "User_ID = @User_ID" : "TRUE"), " AND ", (HasStoreID ? "Store_ID = @Store_ID" : "TRUE"));

        private IDbContainer Container;

        public RoleService(IDbContainer container)
        {
            Container = container;
        }

        public Role Create(string Role_ID = "", string RoleName = "", bool IsGlobal = false)
        {
            var _Role = new Role
            {
                Role_ID = Compute.Etc.IDed(Role_ID),
                RoleName = RoleName,
                IsGlobal = IsGlobal
            };

            var Result = Container.Connect().Execute(CreateRole, _Role);

            if (Result > 0)
            {
                return _Role;
            }
            else
            {
                return null;
            }
        }

        public IEnumerable<Role> GetRoles(int User_ID = -1, int Store_ID = -1)
        {
            var _Input = new { User_ID, Store_ID };
            var _Query = GetOneRoles(User_ID > 0, Store_ID > 0);

            var ResultSet = Container.Connect().Query<Role>(_Query, _Input);

            if (ResultSet.LongCount() == 0)
            {
                return null;
            }
            else
            {
                return ResultSet;
            }
        }
    }
}
