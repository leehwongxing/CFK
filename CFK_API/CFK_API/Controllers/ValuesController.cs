using CFK_API.Services;
using Microsoft.AspNetCore.Mvc;

namespace CFK_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private ITokenService Users { get; set; }

        public ValuesController(ITokenService _Service)
        {
            Users = _Service;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<Models.Projections.Token> Get()
        {
            return Users.CreateUserToken(1, 1);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
