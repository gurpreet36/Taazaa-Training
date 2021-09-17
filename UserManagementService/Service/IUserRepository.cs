using UserManagementService.Models;
using System.Collections.Generic; 

namespace UserManagementService.Service
{
    public interface IUserRepository
    {
         int AddUser(User user);
         int updateUser(int id,User user);
         int DeleteUser(int id);
         User SearchUser(int id);
         IEnumerable<User> GetUsers();
    }
}