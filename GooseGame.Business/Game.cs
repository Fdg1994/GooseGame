namespace GooseGame.Business
{
    internal class Game
    {
        public List<Player>? Players { get; set; }
        public static int Turns { get; set; }

        public Game(Gameboard gameboard, List<Player> players)
        {
            gameboard = Gameboard.GetInstance();
            players = AddPlayers();
        }

        public void StartGame()
        {
            Gameboard.GetInstance();
            AddPlayers();
            while ()
            {
                foreach (Player player in Players)
                {
                    if (player.TurnsSkip == 0)
                    {
                        Console.WriteLine($"Your turn,{player.Name}! Press any button to roll the dice");
                        Console.WriteLine($"{player.Name} rolls the dice...");
                        CheckThrow(player, player.RollDie());
                    }
                    else if(player.TurnsSkip > 0)
                    {
                        player.TurnsSkip--;
                        Console.WriteLine($"You're stuck! for {player.TurnsSkip} more turns!");
                    }
                }
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

        private void CheckWin(Player player)
        {
            if(player.Position == 63)
            {
                Console.WriteLine("you won!");
                 
            }
        }

        private List<Player> AddPlayers(int numberOfPlayers = 2)
        {
            for (int i = 1; i < numberOfPlayers; i++)
            {
                Players.Add(new Player());
                Console.WriteLine($"Hello player {i}! Enter your name please:");
                Players[i].Name = Console.ReadLine().ToUpper();
            }
            return Players;
        }
    }
}