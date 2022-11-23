﻿using GooseGame.Data.NewEntities;
using GooseGame.Data.Repository;
using GooseGame.Data.Services;

namespace GooseGame.Business
{
    public class Game
    {
        BaseRepository _repo;
        BusinessService service = new BusinessService();
        public int Id { get; set; }
        public List<PlayerModel>? Players { get; set; }
        public static int Turns { get; set; }
        public static bool IsDone { get; set; }
        public DateTime StartDateTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public PlayerModel Winner { get; set; }
        public Game()
        {
            _repo = new();
            Players = new List<PlayerModel>();
            Players = AddPlayers();
        }

        public void StartGame()
        {
            //_repo.AddPlayer(new Player
            //{
            //    Name = "Ken"
            //});

            while (IsDone == false)
            {
                HandleTurns(Players);
            }
        }

        private void HandleTurns(List<PlayerModel> Players)
        {
            foreach (PlayerModel player in Players)
            {
                if (CheckIfStuck(player) == false)
                {
                    string playerTurnString = $"Your turn,{player.Name}! Press any button to roll the dice. Current position: {player.Position}";
                    Console.WriteLine(playerTurnString);
                    string rollDiceString = $"{player.Name} rolls the dice...";
                    Console.WriteLine(rollDiceString);
                    CheckThrow(player, player.RollDie());
                }
            }
            Turns++;
        }

        private void CheckThrow(PlayerModel player, int[] dice) //Make method to check first throw die (5 + 4 = go to 26; 6 + 3 = go to 53)
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
                else
                {
                    player.MovePlayer(dice[0] + dice[1]);
                }
            }
            else
            {
                player.MovePlayer(dice[0] + dice[1]);
            }
            player.FirstThrow = false;
        }

        private bool CheckIfStuck(PlayerModel player)
        {
            if (player.TurnsSkip == 0 && player.StuckInWell == false)
            {
                return false;
            }
            else if (player.StuckInWell == true)
            {
                HandleWell(player);
                return true;
            }
            else
            {
                HandleSkipTurn(player);
                return true;
            }
        }

        private string HandleWell(PlayerModel player) //Checks if player is stuck in well and ensures that he remains there until another player hits the well square.
        {
            foreach (PlayerModel p in Players)
            {
                p.StuckInWell = false;
            }
            player.StuckInWell = true;
            string wellString = $"Im sure someone will come for you eventually, {player.Name}";
            Console.WriteLine(wellString);
            return wellString;
        }

        private string HandleSkipTurn(PlayerModel player)
        {
            player.TurnsSkip--;
            string turnSkipString = $"{player.Name}, you're stuck! for {player.TurnsSkip + 1} more turn(s)!";
            Console.WriteLine(turnSkipString);
            return turnSkipString;
        }

        private List<PlayerModel> AddPlayers(int numberOfPlayers = 3)
        {
            for (int i = 0; i < numberOfPlayers; i++)
            {
                Players.Add(new PlayerModel { Name = i.ToString()});
                string askNameString = $"Hello player {Players[i].Name}!";
            }
            return Players;
        }
    }
}