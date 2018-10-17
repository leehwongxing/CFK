using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CFK_API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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

        public ActionResult<Models.Outputs.User_Signed_In> User_SignIn(
            [FromBody][Bind(new string[] { "Email", "Password", "Store_ID" })]
            Models.User user)
        {
            return null;
        }
    }
}
