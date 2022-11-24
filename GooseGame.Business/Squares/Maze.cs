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
            string SquareMessage = "Wow! A bridge! Get to square 12!";
            return SquareMessage;
        }
    }
}