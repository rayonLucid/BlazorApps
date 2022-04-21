using Club_Portal.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Club_Portal.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly DbClass db;
       public LoginController(DbClass dbClass)
        {
            db = dbClass;
        }
        [HttpGet]
        public IEnumerable<UserInformation> Get()

        { 
            var userInformation = db.UserInformation.ToList();
            return userInformation;
        }

        [HttpGet]
        public IEnumerable<UserInformation> Get(string userName,string password)

        {
            var userInformation = db.UserInformation.Where(x =>x.UserName== userName && x.Password== password).ToList();
            return userInformation;
        }
        // GET api/<LoginController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LoginController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<LoginController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LoginController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
