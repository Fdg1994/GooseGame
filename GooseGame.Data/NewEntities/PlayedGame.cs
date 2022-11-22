using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GooseGame.Data.NewEntities
{
    public class PlayedGame
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public Player Player { get; set; }
    }
}
