using System.Collections.Generic;
using System.Media;
using System.Windows;
using GooseGame.Business.Squares;
using GooseGame.Presentation.WPF.ViewModels;

namespace GooseGame.Presentation.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        public static SoundPlayer soundPlayer = new SoundPlayer(GooseGame.Presentation.WPF.Properties.Resources.midnight_123895);
        private MainMenuViewModel vm = new MainMenuViewModel();

        public IList<ISquare> Squares { get; }


        public MainWindow()
        {
            InitializeComponent();
           // soundPlayer.PlayLooping();
            BtnPlay.Visibility = Visibility.Collapsed;
            DataContext = vm;
            
            Squares = Gameboard.GetInstance().Squares;
        }

        private void Mute(object sender, RoutedEventArgs e)
        {
            soundPlayer.Stop();
            BtnPlay.Visibility = Visibility.Visible;
            BtnMute.Visibility = Visibility.Collapsed;
        }

        private void Play(object sender, RoutedEventArgs e)
        {
            //soundPlayer.PlayLooping();
            BtnPlay.Visibility = Visibility.Collapsed;
            BtnMute.Visibility = Visibility.Visible;
        }
    }
}