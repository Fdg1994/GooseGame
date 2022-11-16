using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GooseGame.Business
{
    internal class GameLogic
    {
        Player player1 = new Player();
        int tempRoll;
        public void ChangePlayerPosition(int tempRoll)
        {
            player1.Pos += tempRoll;
            FinishLine(tempRoll);
        }
        public void FinishLine(int tempRoll)
        {
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
        public void CheckFirstThrow() //Make method to check first throw die (5 + 4 = go to 26; 6 + 3 = go to 53)
        {

        }
    }
}
