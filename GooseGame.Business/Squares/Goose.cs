namespace GooseGame.Business.Squares
{
    public class Goose : ISquare
    {
        public void HandlePlayer(Player player)
        {
            Console.WriteLine("A goose! You can go twice as far!"); //TODO reverse logic

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
        }
    }
}