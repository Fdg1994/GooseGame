namespace GooseGame.Business.Squares
{
    public class Goose : ISquare
    {
        public void HandlePlayer(PlayerModel player)
        {
            string gooseSquareString = "A goose! You can go twice as far!";
            Console.WriteLine(gooseSquareString);

            player.MovePlayer(player.CurrentRoll);
        }
    }
}