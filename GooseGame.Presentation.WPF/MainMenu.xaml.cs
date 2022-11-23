using GooseGame.Presentation.WPF.Models;
using GooseGame.Presentation.WPF.ViewModels;
using System.Collections.Generic;
using System.Media;
using System.Windows;

//Als hier using GooseGame.Business staat klopt het niet :)
//VISUEEL
namespace Goose_Game
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    ///
    public partial class MainMenu : Window
    {
        
        public static SoundPlayer soundPlayer = new SoundPlayer(GooseGame.Presentation.WPF.Properties.Resources.creepy_music_box_halloween_music_horror_scary_spooky_dark_ambient_118577);
        MainMenuViewModel vm;
        List<GooseGame.Presentation.WPF.Models.PlayerModel> players;

        public MainMenu()
        {
            //soundPlayer.PlayLooping();
            InitializeComponent();
            BtnPlay.Visibility = Visibility.Collapsed;

            vm = new MainMenuViewModel();
            players = vm.GetPlayerList();
            vm.SetPlayerPosition(2, 5);
        }

        //DUMMY
        private void ButtonHasBeenClicked()
        {
            vm.DoeIets();
            DrawPlayer();
        }

        //DUMMY
        private void DrawPlayer()
        {
            //Draw Player
        }

        private void Play_Game(object sender, RoutedEventArgs e)
        {
            PlayerSelection playerSelection = new PlayerSelection();
            playerSelection.Show();
            Close();
        }

        private void Mute(object sender, RoutedEventArgs e)
        {
            soundPlayer.Stop();
            BtnPlay.Visibility = Visibility.Visible;
            BtnMute.Visibility = Visibility.Collapsed;
        }

        private void Play(object sender, RoutedEventArgs e)
        {
            soundPlayer.PlayLooping();
            BtnPlay.Visibility = Visibility.Collapsed;
            BtnMute.Visibility = Visibility.Visible;
        }

        private void Highscores_Click(object sender, RoutedEventArgs e)
        {
            Highscores highScores = new Highscores();
            highScores.Show();
            Close();
        }
    }
}