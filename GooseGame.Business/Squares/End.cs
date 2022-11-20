namespace GooseGame.Business.Squares
{
    internal class End : ISquare
    {
        public void HandlePlayer(Player player)
        {
            string endSquareString = $"Well done {player.Name} You made it in {Game.Turns}!";
            Console.WriteLine(endSquareString);
            Console.ReadLine();
            Game.IsDone = true;
        }
    }
}