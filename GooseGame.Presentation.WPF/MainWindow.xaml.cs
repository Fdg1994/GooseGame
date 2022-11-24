using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Windows;
using System.Windows.Controls;
using GooseGame.Business;
using GooseGame.Business.Squares;
using GooseGame.Presentation.WPF.ViewModels;

namespace GooseGame.Presentation.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        public static SoundPlayer soundPlayer = new(Properties.Resources.midnight_123895);
        private MainWindowViewModel vm = new();

        public IList<ISquare> Squares { get; }


        public MainWindow()
        {
            InitializeComponent();
           // soundPlayer.PlayLooping();
            BtnPlay.Visibility = Visibility.Collapsed;
            MyGrid.DataContext = vm;
            Squares = Gameboard.GetInstance().Squares;
            vm.Init(vm.Player1, Pion1);
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

        private void Image_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            vm.MovePlayer(vm.Player1, Pion1);
            CurrentRollParchment.Text = 
                $"Current event: {vm.GetCurrentSpecialEvent()}\n" +
                "Current roll:" +" "+ $"{vm.GetCurrentRoll()}";
            UpperScroll.Text = $"Current player: {1}";

        }
    }
}