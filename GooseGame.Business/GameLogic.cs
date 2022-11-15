using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GooseGame.Business
{
    internal class GameLogic
    {
        int tempRoll;
        Player player1 = new Player();
        public void ChangePlayerPosition()
        {
            tempRoll = player1.RollDie();

            if (player1.Pos + tempRoll == 63)
            {
                //WinCon
            }
            else
            {
                int movesBack = player1.Pos + tempRoll - 63;
                player1.Pos = 63 - movesBack;

            }

        }
    }
}
