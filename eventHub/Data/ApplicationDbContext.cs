using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using eventHub.Models;

namespace eventHub.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<eventHub.Models.Event>? Event { get; set; }
        public DbSet<eventHub.Models.PersonalEvent>? PersonalEvent { get; set; }

       
    }
}