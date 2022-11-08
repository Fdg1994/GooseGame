using GooseGame.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GooseGame.Data.Database
{
    public class GooseGameDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=GooseGame;Trusted_Connection=True;");
        }

        public DbSet<Dummy> Dummies { get; set; }
    }
}
