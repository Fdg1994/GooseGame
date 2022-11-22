namespace GooseGame.Business.Squares
{
    internal class Prison : ISquare
    {
        public void HandlePlayer(PlayerModel player)
        {
            string prisonSquareString = "STOP RIGHT THERE CRIMINAL SCUM!";
            Console.WriteLine(prisonSquareString);
            player.TurnsSkip = 3;
        }
    }
}