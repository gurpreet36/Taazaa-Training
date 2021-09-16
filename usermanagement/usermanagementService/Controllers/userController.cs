using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using usermanagementService.Service;
using usermanagementService.Models;
namespace usermanagementService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class userController:ControllerBase
    {
        IUserRepository _iuserRepository;
        public userController(IUserRepository iuserRepository)
        {
            _iuserRepository=iuserRepository;

        }
        [HttpPost("create user")]
 //       [Route("PostUser")]
        public IActionResult PostUsers(User user)
        {
            int res=_iuserRepository.AddUser(user);
            if(res!=0)
            {
                return Ok("saved");
            }
            return Forbid();
        }
        [HttpGet("{id}")]
 //       [Route("GetUser")]
        public IActionResult Get(int id)
        {
            var user=_iuserRepository.SearchUser(id);
            if(user==null)
            {
                return NotFound();
            }
            return Ok(user);
        }
        [HttpPut("{id}")]
 //       [Route("UpdateUser")]

        public IActionResult updateuser(int id,User user)
        {
           int res= _iuserRepository.UpdateUser(id,user);
           if(res!=0)
           {
               return Ok(res);
           }
           return NotFound();
        }
        [HttpDelete("{id}")]
 //       [Route("DeleteUser")]
        public IActionResult Deleteuser(int id)
        {
            int res=_iuserRepository.DeleteUser(id);
            if(res!=0)
            {
                return Ok();
            }
            return NotFound();
        }
        [HttpGet("userList")]
  //      [Route("userList")]
        public IEnumerable<User> GetUsers()
        {
           var user=_iuserRepository.GetUsers();
           return user;
        }

    }
}