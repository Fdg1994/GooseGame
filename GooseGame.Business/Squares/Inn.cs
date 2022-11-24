using System.Diagnostics;

namespace GooseGame.Business.Squares
{
    internal class Inn : ISquare
    {
        public void HandlePlayer(PlayerModel player)
        {
            string innSquareString = "You stop for a drink";
            Debug.WriteLine(innSquareString);
            player.TurnsSkip = 1;
        }
        public string ReturnDescription()
        {
            string SquareMessage = @"Oh no! Massive spiderwebs!
You spend a turn trying to get through.
Let's hope the owner of this web
isn't nearby...";

            return SquareMessage;
        }   
    }
}