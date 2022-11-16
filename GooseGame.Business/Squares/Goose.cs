using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GooseGame.Business.Squares
{
    public class Goose : Default, ISquare
    {
        public override void HandlePlayer(int tempRoll) //find a way to add tempRoll?
        {
            //use tempRoll and player.Pos to skip player equal number of squares as he rolled
        }
    }
}
