using GooseGame.Data.Database;
using GooseGame.Data.Entities;

namespace GooseGame.Data.Repository
{
    public class DummyRepository
    {
        private GooseGameDbContext ctx = new GooseGameDbContext();

        public void AddDummy(Dummy dummy)
        {
            ctx.Dummies.Add(dummy);
            ctx.SaveChanges();
        }
    }
}