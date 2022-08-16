using Domain;
using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Data.DbCotext
{
    public class AplicationContext : DbContext
    {
        public DbSet<Fighter> Lutadores { get; set; }
        public DbSet<Juiz> Juizes { get; set; }
        public DbSet<Luta> Lutas { get; set; }
        public AplicationContext(DbContextOptions<AplicationContext> options) : base(options)
        {

        }
    }
}
