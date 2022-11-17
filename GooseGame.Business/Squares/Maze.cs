namespace GooseGame.Business.Squares
{
    internal class Maze : ISquare
    {
        public void HandlePlayer(Player player)
        {
            player.SetPlayerPosition(39);
        }
    }
}