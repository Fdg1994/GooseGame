using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GooseGame.Business.Squares
{
    public class Well : Default, ISquare
    {
        public override void HandlePlayer()
        {
            //wait for other player to land on square, then resume movement
        }
    }
}
