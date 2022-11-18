namespace GooseGame.Business.Squares
{
    internal class Inn : ISquare
    {
        public void HandlePlayer(Player player)
        {
            player.Skips = 1;
            if (player.Skips > 0)
            {
                player.IsTurn = false;
                player.Skips--;
            }
        }
    }
}