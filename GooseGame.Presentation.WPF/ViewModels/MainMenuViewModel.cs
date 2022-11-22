using GooseGame.Business;
using GooseGame.Presentation.WPF.Models;
using System;
using System.Collections.Generic;
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
        public MainMenuViewModel()
        {
            game = new Game();
        }

        public void SetPlayerPosition(int id, int pos)
        {
            game.Players?[id].SetPlayerPosition(pos);
        }

        public List<PlayerModel> GetPlayerList()
        {
            List<PlayerModel> players = new List<PlayerModel>();

            foreach (Player player in game.Players)
            {
                //We "mappen" van "object 1" zijn properties naar "object 2".
                players.Add(new PlayerModel
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
            //game.StartGame();
            MessageBox.Show("Hello world!");
        }
    }
}
