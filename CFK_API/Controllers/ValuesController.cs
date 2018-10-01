using CFK_API.Models;
using CFK_API.Services;
using Microsoft.AspNetCore.Mvc;

namespace CFK_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IUserService Users { get; set; }

        public ValuesController(IUserService _UserService)
        {
            Users = _UserService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<User> Get()
        {
            return Users.Create("leehwongxing@yandex.ru", "saocungduoc", "Lê Quang Vinh", 666);
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
