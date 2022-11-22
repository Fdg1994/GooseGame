using GooseGame.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace GooseGame.Data.Database
{
    public class GooseGameDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=GooseGame;Trusted_Connection=True;");
        }



        public DbSet<PlayerEntity> Players { get; set; }
        public DbSet<GameEntity> Games { get; set; }
        public DbSet<Player_SpecialSquareHitEntity> SpecialSquareHits { get; set; }
    }
}