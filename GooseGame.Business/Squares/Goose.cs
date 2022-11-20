namespace GooseGame.Business.Squares
{
    public class Goose : ISquare
    {
        public void HandlePlayer(Player player)
        {
            Console.WriteLine("A goose! You can go twice as far!");

            player.MovePlayer(player.CurrentRoll);
        }
    }
}