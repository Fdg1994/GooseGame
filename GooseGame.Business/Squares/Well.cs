using System.Diagnostics;

namespace GooseGame.Business.Squares
{
    public class Well : ISquare
    {
        public void HandlePlayer(PlayerModel player)
        {
            string wellSquareString = "You fell in a well!";
            Debug.WriteLine(wellSquareString);
            player.StuckInWell = true;
        }

        public string ReturnDescription()
        {
            string SquareMessage = @"A wall in the path.
You'll need to wait
for someone to
lift you over!";

            return SquareMessage;
        }
    }
}