using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CFK_API.Models;
using CFK_API.Models.Outputs;
using CFK_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CFK_API.Controllers
{
    [Route("role")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private IRoleService Roles { get; set; }

        private new RoleMsg Response { get; set; }

        public RoleController(IRoleService service)
        {
            Roles = service;
            Response = new RoleMsg();
        }

        public IEnumerable<Role> GetAll()
        {
            return null;
        }

        public RoleMsg CreateRole()
        {
            return null;
        }
    }
}
