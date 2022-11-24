using System.Diagnostics;

namespace GooseGame.Business.Squares
{
    public class Goose : ISquare
    {
        public void HandlePlayer(PlayerModel player)
        {
            string gooseSquareString = "A goose! You can go twice as far!";
            Debug.WriteLine(gooseSquareString);

            player.MovePlayer(player.CurrentRoll);
        }
        public string ReturnDescription()
        {
            string SquareMessage = "Wow! A bridge! Get to square 12!";
            return SquareMessage;
        }   
    }
}