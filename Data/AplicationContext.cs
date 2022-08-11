using Domain;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class AplicationContext : DbContext
    {
        public DbSet<Lutador> Lutadores { get; set; }
        public DbSet<Juiz> Juizes { get; set; }
        public DbSet<Luta> Lutas { get; set; }
        public AplicationContext(DbContextOptions<AplicationContext> options) : base(options)
        {
           
        }
    }
}
