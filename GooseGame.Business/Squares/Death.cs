namespace GooseGame.Business.Squares
{
    public class Death : ISquare
    {
        public void HandlePlayer(Player player)
        {
            string deathSquareString = "You got lost in the maze!";
            Console.WriteLine(deathSquareString);
            player.SetPlayerPosition(1);
        }
    }
}