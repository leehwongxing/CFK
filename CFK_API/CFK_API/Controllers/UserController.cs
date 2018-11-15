using CFK_API.Models;
using CFK_API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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

        [HttpGet("clone")]
        public Customer Clone()
        {
            return new Customer();
        }

        [HttpGet("test")]
        public IList<string> Test()
        {
            var result = new Customer().GetFields();

            Request.HttpContext.Response.Headers.Add("X-Total-Count", result.Count.ToString());

            return result;
        }

        [HttpGet("auth")]
        public Models.Outputs.Base Authenticated()
        {
            return new Models.Outputs.Base();
        }
    }
}
