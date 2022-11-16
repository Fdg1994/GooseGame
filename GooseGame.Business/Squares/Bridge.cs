namespace GooseGame.Business.Squares
{
    public class Bridge : Default, ISquare
    {
        public void HandlePlayer(Player player)
        {
            Console.WriteLine("Wow! A bridge! Get to square 12!");
            player.SetPlayerPosition(12);
        }
    }
}