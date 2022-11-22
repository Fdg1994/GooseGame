using GooseGame.Data.Entities;
using GooseGame.Data.NewEntities;
using Microsoft.EntityFrameworkCore;

namespace GooseGame.Data.Database
{
    public class GooseGameDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=GooseGameVoorFrederik;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlayerSpecialSquaresHit>().HasKey(x => new { x.PlayerId, x.SpecialSquaresHitId});
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<PlayedGame> PlayedGames { get; set; }
        public DbSet<SpecialSquaresHit> SpecialSquareHits { get; set; }
        public DbSet<PlayerSpecialSquaresHit> PlayerSpecialSquareHits { get; set; }
    }
}