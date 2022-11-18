namespace GooseGame.Business.Squares
{
    internal class Prison : ISquare
    {
        public void HandlePlayer(Player player)
        {
            player.Skips = 3;
            if (player.Skips > 0)
            {
                player.IsTurn = false;
                player.Skips--;
            }
        }
    }
}