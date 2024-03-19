using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Web2.Models;

namespace Web2.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Web2.Models.TheatreShow> TheatreShow { get; set; } = default!;
        public DbSet<Web2.Models.Ticket> Ticket { get; set; } = default!;
    }
}
