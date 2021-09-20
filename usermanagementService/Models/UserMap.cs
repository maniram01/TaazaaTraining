using Microsoft.EntityFrameworkCore.Metadata.Builders;  //For Fluent Api
namespace usermanagementService.Models
{
    public class UserMap
    {
       public UserMap(EntityTypeBuilder<User> users)
       {
           users.HasKey(t=>t.Id);
           users.Property(t=>t.Name).HasMaxLength(30).IsRequired();
           users.Property(t=>t.Age).HasMaxLength(3).IsRequired();
       } 
    }
}