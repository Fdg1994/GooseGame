using GooseGame.Business;
using GooseGame.Presentation.WPF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

//VIEWMODEL ALS JE IETS WILT DOEN IN DE BUSINESS
namespace GooseGame.Presentation.WPF.ViewModels
{
    public class MainMenuViewModel
    {
        Game game;

        public ObservableCollection<PlayerModel> Players { get; set; }
        public PlayerModel player1 { get; set; } 

        public MainMenuViewModel()
        {
            game = new Game();
            Players = new ObservableCollection<PlayerModel>(game.Players);
            player1 = new PlayerModel { X = 5, Y = 7};

        }

        public void SetPlayerPosition(int id, int pos)
        {
            game.Players?[id].SetPlayerPosition(pos);
        }

        public List<Models.PlayerModel> GetPlayerList()
        {
            List<Models.PlayerModel> players = new List<Models.PlayerModel>();

            foreach (PlayerModel player in game.Players)
            {
                //We "mappen" van "object 1" zijn properties naar "object 2".
                players.Add(new Models.PlayerModel
                {
                    Id = player.Id,
                    Name = player.Name,
                    Position = player.Position
                });
            }

            return players;
        }

        //DUMMY
        public void DoeIets()
        {
            game.StartGame();
            MessageBox.Show("Hello world!");
        }
    }
}
