using GooseGame.Data.Database;
using GooseGame.Data.Entities;
using GooseGame.Data.NewEntities;

namespace GooseGame.Data.Repository
{
    public class BaseRepository
    {
        private GooseGameDbContext ctx = new GooseGameDbContext();

        public void AddPlayer(Player player)
        {
            ctx.Players.Add(player);
            ctx.SaveChanges();
        }
    }
}