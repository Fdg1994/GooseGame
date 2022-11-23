using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//VIEWMODEL ALS JE IETS WILT DOEN IN DE BUSINESS
namespace GooseGame.Presentation.WPF.ViewModels
{
    public class MainWindowViewModel
    {
        private readonly Game _game;
        public ObservableCollection<PlayerModel> Players { get; set; }
        public PlayerModel Player1 { get; set; }

        public MainWindowViewModel()
        {
            _game = new Game();
            Players = new ObservableCollection<PlayerModel>(_game.Players);
            Player1 = new PlayerModel { Position = 1 };
        }

        public void MovePlayer(PlayerModel player)
        {
            int sum = player.RollDie().Sum();
            player.MovePlayer(sum);
        }
    }
}
