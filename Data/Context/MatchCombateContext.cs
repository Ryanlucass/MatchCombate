using Domain;
using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Data.DbCotext
{
    public class MatchCombateContext : DbContext
    {
        public DbSet<Fighter> Fighters { get; set; }
        public DbSet<Fight> Fight { get; set; }
       
        public MatchCombateContext(DbContextOptions<MatchCombateContext> options) : base(options)
        {}
    }
}
