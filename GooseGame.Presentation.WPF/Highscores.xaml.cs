using System.Windows;

namespace Goose_Game
{
    /// <summary>
    /// Interaction logic for Highscores.xaml
    /// </summary>
    public partial class Highscores : Window
    {
        public Highscores()
        {
            InitializeComponent();
            BtnPlay.Visibility = Visibility.Collapsed;
        }

        private void Mute(object sender, RoutedEventArgs e)
        {
            MainMenu.player.Stop();
            BtnPlay.Visibility = Visibility.Visible;
            BtnMute.Visibility = Visibility.Collapsed;
        }

        private void Play(object sender, RoutedEventArgs e)
        {
            MainMenu.player.PlayLooping();
            BtnPlay.Visibility = Visibility.Collapsed;
            BtnMute.Visibility = Visibility.Visible;
        }

        private void BackHighscores_Click(object sender, RoutedEventArgs e)
        { 
            MainMenu mainMenu = new MainMenu();
            Close();
        }
    }
}