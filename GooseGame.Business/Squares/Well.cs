namespace GooseGame.Business.Squares
{
    public class Well : ISquare
    {
        public void HandlePlayer(Player player)
        {
            Console.WriteLine("You fell in a well!");
            player.StuckInWell = true;
        }
    }
}