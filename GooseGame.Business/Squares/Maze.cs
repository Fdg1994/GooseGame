namespace GooseGame.Business.Squares
{
    internal class Maze : ISquare
    {
        public void HandlePlayer(PlayerModel player)
        {
            string mazeSquareString = "You got lost in the maze!";
            Console.WriteLine(mazeSquareString);
            player.SetPlayerPosition(39);
        }
    }
}