namespace GooseGame.Business.Squares
{
    internal class Prison : ISquare
    {
        public void HandlePlayer(Player player)
        {
            player.IsTurn = false;
        }
    }
}