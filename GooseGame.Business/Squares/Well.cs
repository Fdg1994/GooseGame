namespace GooseGame.Business.Squares
{
    public class Well : ISquare
    {
        public void HandlePlayer(Player player)
        {
            player.TurnsSkip = 1;
        }
    }
}