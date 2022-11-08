using GooseGame.Data.Database;
using GooseGame.Data.Entities;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
