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
            string SquareMessage = "Wow! A bridge! Get to square 12!";
            return SquareMessage;
        }
    }
}