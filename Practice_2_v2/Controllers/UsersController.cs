using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_2_v2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // implementación de injections
        private IUserManager _userManager;
         public UsersController(IUserManager userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(_userManager.GetUsers());
        }
        [HttpPost]
        public IActionResult PostUser(User user)
        {
            return Ok(_userManager.PostUser(user) );
        }
        [HttpPut]
        public IActionResult PutUser(User user)
        {
            return Ok(_userManager.PutUser(user) );
        }
        [HttpDelete]
        public IActionResult DeleteUser(User user)
        {
            return Ok(_userManager.DeleteUser(user) );
        }
    }
}
