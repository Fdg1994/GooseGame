using System.Diagnostics;

namespace GooseGame.Business.Squares
{
    internal class Prison : ISquare
    {
        public void HandlePlayer(PlayerModel player)
        {
            string prisonSquareString = "STOP RIGHT THERE CRIMINAL SCUM!";
            Debug.WriteLine(prisonSquareString);
            player.TurnsSkip = 3;
        }

        public string ReturnDescription()
        {
            string SquareMessage = @"OH NO! A WALKING SKELETON!
You spend three turns slaying the undead creature.";

            return SquareMessage;
        }
    }
}