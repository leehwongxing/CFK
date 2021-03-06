using CFK_API.Models;
using Dapper;
using System.Collections.Generic;
using System.Linq;

namespace CFK_API.Services
{
    public interface IRoleService
    {
        Role Create(string Role_ID, string RoleName, bool IsGlobal = false);

        IEnumerable<Role> GetRoles(long User_ID, int Store_ID = -1);

        IEnumerable<string> GetOneRoleIDs(long User_ID, int Store_ID = -1);
    }

    public class RoleService : IRoleService
    {
        private Compute.Sample<Role> Sample { get; set; }

        private readonly string CreateRole
            = @"INSERT INTO Dim_Roles VALUES (@Role_ID, @RoleName, @IsGlobal)";

        private string GetOneRoles(bool HasStoreID = true)
            => string.Concat(@"SELECT * FROM Dim_Roles WHERE Role_ID IN (SELECT Role_ID FROM UserRoles WHERE User_ID = @User_ID ", (HasStoreID ? @"AND Store_ID = @Store_ID" : @""), @")");

        private string GetOneRoleIDs(bool HasStoreID = true)
            => string.Concat(@"SELECT Role_ID FROM UserRoles WHERE User_ID = @User_ID ", (HasStoreID ? @"AND Store_ID = @Store_ID" : @""));

        private IDbContainer Container;

        public RoleService(IDbContainer container)
        {
            Container = container;

            Preload();
        }

        private void Preload()
        {
            var check = @"SELECT COUNT(Role_ID) FROM Dim_Roles";

            if (Container.Connect().Query<int>(check).Single() == 0 && Sample.DataSource.Count() > 0)
            {
                Container.Connect().Execute(CreateRole, Sample.DataSource);
            }
        }

        public Role Create(string Role_ID, string RoleName, bool IsGlobal = false)
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
            return null;
        }

        public IEnumerable<Role> GetRoles(long User_ID, int Store_ID = -1)
        {
            var _Query = GetOneRoles(Store_ID > 0);

            return Container.Connect().Query<Role>(_Query, new { User_ID, Store_ID });
        }

        public IEnumerable<string> GetOneRoleIDs(long User_ID, int Store_ID = -1)
        {
            var _Query = GetOneRoleIDs(Store_ID > 0);

            return Container.Connect().Query<string>(_Query, new { User_ID, Store_ID });
        }
    }
}
