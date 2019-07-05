using Microsoft.EntityFrameworkCore;

namespace GymWebApp.Models
{
    public class GymContext: DbContext
    {
        public GymContext(DbContextOptions<GymContext> options):base(options)
        {
        }

        public DbSet<Client> Clients {get; set;}
    }
}