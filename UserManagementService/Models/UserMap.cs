using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace UserManagementService.Models
{
    public class UserMap
    {
        public UserMap(EntityTypeBuilder<User> users)
        {
            users.HasKey(t=>t.Id);
            users.Property(t=>t.Username).HasMaxLength(50);
            users.Property(t=>t.Username).IsRequired();
            users.Property(t=>t.Age).HasMaxLength(2);
            users.Property(t=>t.Age).IsRequired();
        }
    }
}