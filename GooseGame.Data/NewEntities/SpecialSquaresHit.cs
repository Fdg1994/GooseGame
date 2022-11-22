using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GooseGame.Data.NewEntities
{
    public class SpecialSquaresHit
    {
        public int Id { get; set; }
        public DateTime WhenHit { get; set; }
        public int SquareNumber { get; set; }
        public List<PlayerSpecialSquaresHit>? PlayerSpecialSquaresHits { get; set; }
    }
}
