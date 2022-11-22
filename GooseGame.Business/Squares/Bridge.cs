namespace GooseGame.Business.Squares
{
    public class Bridge : ISquare
    {
        public void HandlePlayer(PlayerModel player)
        {
            string bridgeSquareString = "Wow! A bridge! Get to square 12!";
            Console.WriteLine(bridgeSquareString);
            player.SetPlayerPosition(12);
        }
    }
}