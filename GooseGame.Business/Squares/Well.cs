namespace GooseGame.Business.Squares
{
    public class Well : ISquare
    {
        public void HandlePlayer(Player player)
        {
            string wellSquareString = "You fell in a well!";
            Console.WriteLine(wellSquareString);
            player.StuckInWell = true;
        }
    }
}