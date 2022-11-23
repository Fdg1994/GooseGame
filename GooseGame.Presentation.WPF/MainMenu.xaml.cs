using System.Media;
using System.Windows;
using GooseGame.Presentation.WPF.ViewModels;

//Als hier using GooseGame.Business staat klopt het niet :)
//VISUEEL
namespace GooseGame.Presentation.WPF
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    ///
    public partial class MainMenu : Window
    {
        
        public static SoundPlayer soundPlayer = new SoundPlayer(GooseGame.Presentation.WPF.Properties.Resources.creepy_music_box_halloween_music_horror_scary_spooky_dark_ambient_118577);
        MainWindowViewModel vm;

        public MainMenu()
        {
            //soundPlayer.PlayLooping();
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