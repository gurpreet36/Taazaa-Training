using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UserManagementService.Service;
using UserManagementService.Models;


namespace UserManagementService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        IUserRepository _iuserrepository;
        public UserController(IUserRepository iuserrepository)
        {
            _iuserrepository = iuserrepository;
        }
        [HttpPost("CreateUser")]
        public IActionResult PostUsers(User user)
        {
            int res = _iuserrepository.AddUser(user);
            if(res!=0)
            {
                return Ok("saved!!");
            }
            return Forbid();
        }
        [HttpGet("{Id}")]
        
        public IActionResult Getuser(int id)
        {
            var user = _iuserrepository.SearchUser(id);
            if(user==null)
            {
                return NotFound();
            }
            return Ok(user);
        }
        [HttpPut("{id}")]
        
        public IActionResult updateuser(int id,User user)
        {
            int res = _iuserrepository.updateUser(id, user);
            if(res!=0)
            {
                return Ok(res);
            }
            return NotFound();
        }
        [HttpDelete("{id}")]
        
        public IActionResult DeleteUser(int id)
        {
            int res = _iuserrepository.DeleteUser(id);
            if(res!=0)
            {
                return Ok("User Deleted!!");
            }
            return NotFound();
        }
        [HttpGet]
        
        public IEnumerable<User> GetUsers()
        {
            var user = _iuserrepository.GetUsers();
            return user;
        }
    }
}