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
            string SquareMessage = "Wow! A bridge! Get to square 12!";
            return SquareMessage;
        }
    }
}