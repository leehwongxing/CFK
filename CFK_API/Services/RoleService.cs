using CFK_API.Models;
using Dapper;
using System.Collections.Generic;
using System.Linq;

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

        private string GetOneRoles(bool HasStoreID = true)
            => string.Concat("SELECT * FROM UserRoles WHERE User_ID = @User_ID ", (HasStoreID ? "AND Store_ID = @Store_ID" : ""));

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
            var _Query = GetOneRoles(Store_ID > 0);

            return Container.Connect().Query<Role>(_Query, new { User_ID, Store_ID });
        }
    }
}
