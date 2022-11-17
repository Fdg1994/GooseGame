using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Goose_Game
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {

        //public static SoundPlayer player = new SoundPlayer(@"\Music\creepy-music-box-halloween-music-horror-scary-spooky-dark-ambient-118577.wav");


        public MainMenu()
        {
           //player.PlayLooping();
            InitializeComponent();
            BtnPlay.Visibility = Visibility.Collapsed;
        }

        private void Play_Game(object sender, RoutedEventArgs e)
        {
            PlayerSelection playerSelection = new PlayerSelection();
            playerSelection.Show();
            Close();
        }

        private void Mute(object sender, RoutedEventArgs e)
        {
            //player.Stop();
            BtnPlay.Visibility = Visibility.Visible;
            BtnMute.Visibility = Visibility.Collapsed;
        }

        private void Play(object sender, RoutedEventArgs e)
        {
            //player.PlayLooping();
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

