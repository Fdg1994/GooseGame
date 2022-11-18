namespace GooseGame.Business
{
    public class Game
    {
        public List<Player>? Players { get; set; }
        public static int Turns { get; set; }
        public static bool IsDone { get; set; }

        public Game()
        {
            Players = new List<Player>();      
        }

        public void StartGame()
        {
            Players = AddPlayers();

            while(IsDone == false)
            {
                foreach (Player player in Players)
                {
                    if (player.TurnsSkip == 0)
                    {
                        Console.WriteLine($"Your turn,{player.Name}! Press any button to roll the dice. Current position: {player.Position}");
                        Console.WriteLine($"{player.Name} rolls the dice...");
                        CheckThrow(player, player.RollDie());
                        
                    }
                    else if(player.TurnsSkip > 0)
                    {
                        player.TurnsSkip--;
                        Console.WriteLine($"You're stuck! for {player.TurnsSkip+1} more turns!");
                    }
                }
                Turns++;
            }
        }

        public void CheckThrow(Player player, int[] dice) //Make method to check first throw die (5 + 4 = go to 26; 6 + 3 = go to 53)
        {
            if (player.FirstThrow == true)
            {
                if (dice[0] == 5 && dice[1] == 4 || dice[0] == 4 && dice[1] == 5)
                {
                    player.SetPlayerPosition(26);
                }
                else if (dice[0] == 6 && dice[1] == 3 || dice[0] == 3 && dice[1] == 6)
                {
                    player.SetPlayerPosition(53);
                }
            }
            else
            {
                player.MovePlayer(dice[0] + dice[1]);
            }
            player.FirstThrow = false;
        }

        
        private List<Player> AddPlayers(int numberOfPlayers = 1)
        {
            for (int i = 0; i < numberOfPlayers; i++)
            {
                Players.Add(new Player());
                Console.WriteLine($"Hello player {i}! Enter your name please:");
                Players[i].Name = Console.ReadLine().ToUpper();
            }
            return Players;
        }
    }
}