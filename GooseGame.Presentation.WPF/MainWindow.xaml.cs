using System.Media;
using System.Windows;


namespace Goose_Game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        public static SoundPlayer player = new SoundPlayer(GooseGame.Presentation.WPF.Properties.Resources.midnight_123895);

        public MainWindow()
        {
            InitializeComponent();
            player.PlayLooping();
            BtnPlay.Visibility = Visibility.Collapsed;
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
    }
}