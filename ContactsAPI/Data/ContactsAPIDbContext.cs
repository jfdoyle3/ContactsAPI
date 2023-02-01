using Microsoft.EntityFrameworkCore;
using ContactsAPI.Models;

namespace ContactsApi.Data
{
    public class ContactsApiDbContext : DbContext
    {
        public ContactsApiDbContext(DbContextOptions options) : base(options) 
        { 
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
