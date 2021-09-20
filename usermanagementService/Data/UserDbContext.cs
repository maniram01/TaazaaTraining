using Microsoft.EntityFrameworkCore;
using usermanagementService.Models;
namespace usermanagementService.Data
{
    public class UserDbContext:DbContext
    {
        public DbSet<User> users{get;set;}
        public UserDbContext(DbContextOptions options):base (options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Linking Between User(Model) and UserMap(Mapper)
            new UserMap(modelBuilder.Entity<User>());
        }
        
    }
}