namespace GooseGame.Business.Squares
{
    internal class End : ISquare
    {
        public void HandlePlayer(Player player)
        {
            Console.WriteLine($"You made it in {Game.Turns}!");
            Console.ReadLine();
            Game.IsDone = true;
        }
    }
}