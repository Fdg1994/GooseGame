namespace GooseGame.Business.Squares
{
    public class Default : ISquare
    {
        public void HandlePlayer(Player player)
        {
            string defaultSquareString = "Nothing happens...";
            Console.WriteLine(defaultSquareString);
        }
    }
}