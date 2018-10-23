using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CFK_API.Models;
using CFK_API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CFK_API.Controllers
{
    [Route("user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private ITokenService Tokens { get; set; }

        private IUserService Users { get; set; }

        public UserController(ITokenService tokens, IUserService users)
        {
            Tokens = tokens;
            Users = users;
        }

        [HttpPost("create")]
        public ActionResult<object> CreateNewUser(User user)
        {
            ModelState.Remove(user.Remove);

            if (ModelState.IsValid)
            {
                return user;
            }

            return new User();
        }

        [HttpPost("clone")]
        public ActionResult<object> Clone(object input)
        {
            return input;
        }

        [HttpGet("test")]
        public ActionResult<string> Test()
        {
            return "Accessible";
        }
    }
}
