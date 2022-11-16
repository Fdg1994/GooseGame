using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GooseGame.Business.Squares
{
    internal class Inn : Default, ISquare
    {
        public override void HandlePlayer()
        {
            //hold player on current square for 1 turn
        }
    }
}
