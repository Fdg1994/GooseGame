using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GooseGame.Data.NewEntities
{
    public class Player
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int GamesPlayed { get; set; }
        public List<PlayedGame>? PlayedGames { get; set; }
        public List<PlayerSpecialSquaresHit>? PlayerSpecialSquaresHits { get; set; }
    }
}
