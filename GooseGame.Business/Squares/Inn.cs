namespace GooseGame.Business.Squares
{
    internal class Inn : ISquare
    {
        public void HandlePlayer(Player player)
        {
            string innSquareString = "You stop for a drink";
            Console.WriteLine(innSquareString);
            player.TurnsSkip = 1;
        }
    }
}