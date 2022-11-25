using System.Diagnostics;

namespace GooseGame.Business.Squares
{
    internal class Maze : ISquare
    {
        public void HandlePlayer(PlayerModel player)
        {
            string mazeSquareString = "You got lost in the maze!";
            Debug.WriteLine(mazeSquareString);
            player.SetPlayerPosition(39);
        }

        public string ReturnDescription()
        {
            string SquareMessage = @"You've completely
lost your way
and it seems like...
you're walking in circles!
You go back 3 squares.";
            return SquareMessage;
        }
    }
}