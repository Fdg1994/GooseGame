using System.Diagnostics;

namespace GooseGame.Business.Squares
{
    internal class Prison : ISquare
    {
        public void HandlePlayer(PlayerModel player)
        {
            string prisonSquareString = "STOP RIGHT THERE CRIMINAL SCUM!";
            Debug.WriteLine(prisonSquareString);
            player.TurnsSkip = 3;
        }
        public string ReturnDescription()
        {
            string SquareMessage = "Wow! A bridge! Get to square 12!";
            return SquareMessage;
        }
    }
}