using System.Media;
using System.Windows;

namespace Goose_Game
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        
        public static SoundPlayer player = new SoundPlayer(GooseGame.Presentation.WPF.Properties.Resources.creepy_music_box_halloween_music_horror_scary_spooky_dark_ambient_118577);

        public MainMenu()
        {

            player.PlayLooping();
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
            player.Stop();
            BtnPlay.Visibility = Visibility.Visible;
            BtnMute.Visibility = Visibility.Collapsed;
        }

        private void Play(object sender, RoutedEventArgs e)
        {
            player.PlayLooping();
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