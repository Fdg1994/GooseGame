namespace GooseGame.Business.Squares
{
    public class Death : ISquare
    {
        public void HandlePlayer(Player player)
        {
            Console.WriteLine("You died! Back to square one!");
            player.SetPlayerPosition(0);
        }
    }
}