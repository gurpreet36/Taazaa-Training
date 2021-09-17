using Microsoft.EntityFrameworkCore;
using UserManagementService.Models;

namespace UserManagementService.Data
{
    public class UserDbContext : DbContext
    {
        public DbSet<User> users{get;set;}
        public UserDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Linking between User(model) and UserMap
            new UserMap(modelBuilder.Entity<User>());
        }
        
    }
}