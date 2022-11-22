using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GooseGame.Data.NewEntities
{
    public class PlayerSpecialSquaresHit
    {
        public int PlayerId { get; set; }
        public Player? Player { get; set; }
        public int SpecialSquaresHitId { get; set; }
        public SpecialSquaresHit? SpecialSquaresHit { get; set; }
    }
}
