using System.Media;
using System.Windows;

namespace Goose_Game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        private SoundPlayer player = new SoundPlayer(@"C:\Users\Lenovo\Documents\Oefeningen\OOP\Goose Game\Goose Game\Music\midnight-123895.wav");

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