using GooseGame.Business;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

//VIEWMODEL ALS JE IETS WILT DOEN IN DE BUSINESS
namespace GooseGame.Presentation.WPF.ViewModels
{
    public class MainWindowViewModel
    {
        private readonly Game _game;
        public ObservableCollection<PlayerModel> Players { get; set; }
        public PlayerModel Player1 { get; set; }

        private int[,] myGrid = new int[8, 8];

        public MainWindowViewModel()
        {
            _game = new Game();
            Players = new ObservableCollection<PlayerModel>(_game.Players);
            Player1 = new PlayerModel { Position = 0 };
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    myGrid[j, i] = i % 2 == 0 ? i * 8 + j : (i * 8 + 8 - j) - 1;
                }
            }
        }

        public int GetCurrentRoll()
        {
            return Math.Abs(Player1.CurrentRoll);
        }

        public string GetCurrentSpecialEvent()
        {
            return Player1.CurrentSquare.ReturnDescription();
        }

        public void Init(PlayerModel player, System.Windows.Controls.Image image)
        {
            Grid.SetColumn(image, ShowOnBoard(player.Position).Item1);
            Grid.SetRow(image, ShowOnBoard(player.Position).Item2);
        }

        public void MovePlayer(PlayerModel player, System.Windows.Controls.Image image)
        {
            int[] dice = player.RollDie();
            int sum = dice.Sum();
            if (player.FirstThrow == true)
            {
                if (dice[0] == 5 && dice[1] == 4 || dice[0] == 4 && dice[1] == 5)
                {
                    Grid.SetColumn(image, ShowOnBoard(26).Item1);
                    Grid.SetRow(image, ShowOnBoard(26).Item2);
                    player.SetPlayerPosition(26);
                    player.FirstThrow = false;
                }
                else if (dice[0] == 6 && dice[1] == 3 || dice[0] == 3 && dice[1] == 6)
                {
                    Grid.SetColumn(image, ShowOnBoard(53).Item1);
                    Grid.SetRow(image, ShowOnBoard(53).Item2);
                    player.SetPlayerPosition(53);
                    player.FirstThrow = false;
                }
                else
                {
                    player.MovePlayer(sum);
                    Grid.SetColumn(image, ShowOnBoard(player.Position).Item1);
                    Grid.SetRow(image, ShowOnBoard(player.Position).Item2);
                    player.FirstThrow = false;
                }
            }
            else if (player.Position + sum != 63)
            {
                player.MovePlayer(sum);
                Grid.SetColumn(image, ShowOnBoard(player.Position).Item1);
                Grid.SetRow(image, ShowOnBoard(player.Position).Item2);
            }
            else
            {
                player.MovePlayer(sum);
                Grid.SetColumn(image, ShowOnBoard(player.Position).Item1);
                Grid.SetRow(image, ShowOnBoard(player.Position).Item2);
                Application.Current.Shutdown();
            }
        }

        private Tuple<int, int> ShowOnBoard(int location)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (myGrid[j, i] == location)
                    {
                        return new Tuple<int, int>(j + 2, i + 2);
                    }
                }
            }
            return null!;
        }
    }
}