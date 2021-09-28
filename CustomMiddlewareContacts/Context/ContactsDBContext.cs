using Microsoft.EntityFrameworkCore;
using CustomMiddlewareContacts.Models;
using System.Threading.Tasks;
namespace CustomMiddlewareContacts.Context
{
    public class ContactsDBContext:DbContext
    {
        public DbSet<Contact> contacts{get;set;}
        public ContactsDBContext(DbContextOptions dbContextOptions):base(dbContextOptions)
        {
            
        }
    }
}