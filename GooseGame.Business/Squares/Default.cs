namespace GooseGame.Business.Squares
{
    public class Default : ISquare
    {
        public void HandlePlayer(PlayerModel player)
        {
            string defaultSquareString = "Nothing happens...";
            Console.WriteLine(defaultSquareString);
        }
    }
}