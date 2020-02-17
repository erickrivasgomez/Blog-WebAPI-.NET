using Blog.Models;
using Blog.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace Blog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private UserService _userService;
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger, UserService userService)
        {
            _userService = userService;
            _logger = logger;
        }

        // GET: api/User
        [HttpGet]
        public UserDTO Get()
        {
            return _userService.GetUsers();
        }

        // GET: api/User/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/User
        [HttpPost]
        public UserDTO Post([FromBody] User user)
        {
            return _userService.AddUser(user);
        }

        // PUT: api/User/5
        [HttpPut("{id}")]
        public UserDTO Put(int id, [FromBody] User user)
        {
            return _userService.EditUser(id, user);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public UserDTO Delete(int id)
        {
            return _userService.DeleteUser(id);
        }
    }
}
