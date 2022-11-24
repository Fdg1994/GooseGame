using GooseGame.Business;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public PlayerModel Player2 { get; set; }
        public PlayerModel Player3 { get; set; }
        public PlayerModel Player4 { get; set; }

        private int[,] myGrid = new int[8, 8];

        public MainWindowViewModel()
        {
            _game = new Game();
            Players = new ObservableCollection<PlayerModel>(_game.Players);
            Player1 = new PlayerModel { Position = 1 };
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    myGrid[j, i] = i % 2 == 0 ? i * 8 + j : (i * 8 + 8 - j) - 1;
                }
            }
        }

        public void Init(PlayerModel player, System.Windows.Controls.Image image)
        {
            Grid.SetColumn(image, ShowOnBoard(player.Position).Item1 - 1);
            Grid.SetRow(image, ShowOnBoard(player.Position).Item2);
        }

        public void MovePlayer(PlayerModel player, System.Windows.Controls.Image image)
        {
            int sum = player.RollDie().Sum();
            player.MovePlayer(sum);
            Grid.SetColumn(image, ShowOnBoard(player.Position).Item1);
            Grid.SetRow(image, ShowOnBoard(player.Position).Item2);
        }


        Tuple<int, int> ShowOnBoard(int location)
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


        /*private int XShowOnBoard(int location)
        {
            int x = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (myGrid[j, i] == location)
                    {
                        x = j + 1;
                        return x;
                    }
                }
            }
            throw new Exception();
        }
        private int YShowOnBoard(int location)
        {
            int y = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (myGrid[j, i] == location)
                    {
                        y = i + 1;
                        return y;
                    }
                }
            }
            throw new Exception();
        }*/
    }
}
