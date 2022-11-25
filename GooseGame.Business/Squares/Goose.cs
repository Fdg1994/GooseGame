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
            string SquareMessage = @"You've found some treasure!
You get extra motivation
to go on.
You go twice as far!";

            return SquareMessage;
        }
    }
}