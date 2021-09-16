using Microsoft.EntityFrameworkCore;
using usermanagementService.Models;
namespace usermanagementService.Data
{
    public class UserDbContext:DbContext
    {
        public DbSet<User> users{get;set;}
        public UserDbContext(DbContextOptions options):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // here we are linking building between user and usermap and for context we use onconfigure
            new UserMap(modelBuilder.Entity<User>());
        }
       
        
    }
}