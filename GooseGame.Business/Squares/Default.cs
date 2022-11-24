using System.Diagnostics;

namespace GooseGame.Business.Squares
{
    public class Default : ISquare
    {
        public void HandlePlayer(PlayerModel player)
        {
            string defaultSquareString = "Nothing happens...";
            Debug.WriteLine(defaultSquareString);
        }

        public string ReturnDescription()
        {
            string SquareMessage = "Wow! A bridge! Get to square 12!";
            return SquareMessage;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}