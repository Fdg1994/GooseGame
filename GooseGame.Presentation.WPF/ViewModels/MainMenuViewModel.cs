using GooseGame.Business;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

//VIEWMODEL ALS JE IETS WILT DOEN IN DE BUSINESS
namespace GooseGame.Presentation.WPF.ViewModels
{
    public class MainMenuViewModel
    {
        private readonly Game _game;

        public ObservableCollection<PlayerModel> Players { get; set; }
        public PlayerModel Player1 { get; set; }

        public MainMenuViewModel()
        {
            _game = new Game();
            Players = new ObservableCollection<PlayerModel>(_game.Players);
            Player1 = new PlayerModel { X = 5, Y = 7 };
        }

        public void SetPlayerPosition(int id, int pos)
        {
            _game.Players?[id].SetPlayerPosition(pos);
        }

        public List<Models.PlayerModel> GetPlayerList()
        {
            List<Models.PlayerModel> players = new List<Models.PlayerModel>();

            foreach (PlayerModel player in _game.Players)
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
            _game.StartGame();
            MessageBox.Show("Hello world!");
        }
    }
}