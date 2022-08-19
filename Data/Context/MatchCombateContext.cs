using Domain;
using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Data.DbCotext
{
    public class MatchCombateContext : DbContext
    {
        public DbSet<Fighter> Fighters { get; set; }
        public DbSet<Judge> Judges { get; set; }
        public DbSet<Fight> Fights { get; set; }
       
        public MatchCombateContext(DbContextOptions<MatchCombateContext> options) : base(options)
        {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MatchCombateContext).Assembly); 
        }
    }
}
