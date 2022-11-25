namespace GooseGame.Business.Squares
{
    public interface ISquare
    {
        public void HandlePlayer(PlayerModel player);

        public string ReturnDescription();
    }
}