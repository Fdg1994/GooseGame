using System.Diagnostics;

namespace GooseGame.Business.Squares
{
    internal class Inn : ISquare
    {
        public void HandlePlayer(PlayerModel player)
        {
            string innSquareString = "You stop for a drink";
            Debug.WriteLine(innSquareString);
            player.TurnsSkip = 1;
        }
        public string ReturnDescription()
        {
            string SquareMessage = "Wow! A bridge! Get to square 12!";
            return SquareMessage;
        }   
    }
}