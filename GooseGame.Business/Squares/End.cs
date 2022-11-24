using System.Diagnostics;

namespace GooseGame.Business.Squares
{
    internal class End : ISquare
    {
        public void HandlePlayer(PlayerModel player)
        {
            string endSquareString = $"Well done {player.Name} You made it in {Game.Turns}!";
            Debug.WriteLine(endSquareString);
            Console.ReadLine();
            Game.IsDone = true;
        }

        public string ReturnDescription()
        {
            string SquareMessage = @"You see a light
at the end of the corridor.
A fresh breeze tickles 
your face as you realize...
YOU'RE FREE!";
            return SquareMessage;
        }
    }
}