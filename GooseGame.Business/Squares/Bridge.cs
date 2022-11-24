using System.Diagnostics;

namespace GooseGame.Business.Squares
{
    public class Bridge : ISquare
    {
        public void HandlePlayer(PlayerModel player)
        {
            string SquareMessage = "Wow! A bridge! Get to square 12!";
            Debug.WriteLine(SquareMessage);
            player.SetPlayerPosition(12);
        }

        public string ReturnDescription()
        {
            string SquareMessage = @"You discover a secret tunnel!
Move to square 12!";
            return SquareMessage;
        }
    }
}