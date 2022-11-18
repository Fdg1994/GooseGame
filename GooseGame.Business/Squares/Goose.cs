namespace GooseGame.Business.Squares
{
    public class Goose : ISquare
    {
        public void HandlePlayer(Player player)
        {
            Console.WriteLine("A goose! You can go twice as far!");

            if (player.PreviousPosition + (player.Position - player.PreviousPosition) > 63)
            {
                if (player.Position == 54)
                {
                    player.Position = 54 - ((63 - player.PreviousPosition) + (63 - player.Position));
                }
                else if (player.Position == 59)
                {
                    player.Position = 59 - ((63 - player.PreviousPosition) + (63 - player.Position));
                }
            }
            else
            {
                player.Position += player.Position - player.PreviousPosition;
            }


      //      if (PreviousPosition > Position)

      //          Moveplayer(-roll) //twice as far back (same rules apply)

      //      else

      //          Moveplayer(roll) //twice as far (same rules apply)

        }
    }
}