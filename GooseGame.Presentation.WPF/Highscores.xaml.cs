using System.Windows;

namespace GooseGame.Presentation.WPF
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
            MainMenu.soundPlayer.Stop();
            BtnPlay.Visibility = Visibility.Visible;
            BtnMute.Visibility = Visibility.Collapsed;
        }

        private void Play(object sender, RoutedEventArgs e)
        {
            MainMenu.soundPlayer.PlayLooping();
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