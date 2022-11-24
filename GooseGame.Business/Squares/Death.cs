using System.Diagnostics;

namespace GooseGame.Business.Squares
{
    public class Death : ISquare
    {
        public void HandlePlayer(PlayerModel player)
        {
            string deathSquareString = "You DIEEEEEED!";
            Debug.WriteLine(deathSquareString);
            player.SetPlayerPosition(1);
        }

        public string ReturnDescription()
        {
            string SquareMessage = @"STOP RIGHT THERE YOU CRIMINAL SCUM!
A guard has caught you.
He's taking you back to your cell.";
            return SquareMessage;
        }
    }
}