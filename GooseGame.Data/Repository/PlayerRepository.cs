using GooseGame.Data.Database;
using GooseGame.Data.Entities;


namespace GooseGame.Data.Repository
{
    public class PlayerRepository
    {
        private GooseGameDbContext ctx = new GooseGameDbContext();

        public void AddDummy(PlayerDb player)
        {
            //ctx.Players.Add(new PlayerDb);
            //ctx.SaveChanges();
        }
    }
}