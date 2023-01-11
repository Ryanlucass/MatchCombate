using Domain.Entities;
using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Data.DbCotext
{
    public class MatchCombateContext : DbContext
    {
        public DbSet<Fighter> Fighters { get; set; }
        public DbSet<Fight> Fight { get; set; }
        public DbSet<User> User { get; set; }

        public MatchCombateContext(DbContextOptions<MatchCombateContext> options) : base(options)
        {}
    }
}
