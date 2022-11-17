
﻿using System.Windows;
﻿using System;
using System.Collections.Generic;
using System.Linq;
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
            //MainMenu.player.Stop();
            BtnPlay.Visibility = Visibility.Visible;
            BtnMute.Visibility = Visibility.Collapsed;
        }

        private void Play(object sender, RoutedEventArgs e)
        {
            //MainMenu.player.PlayLooping();
            BtnPlay.Visibility = Visibility.Collapsed;
            BtnMute.Visibility = Visibility.Visible;
        }

        private void BackHighscores_Click(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            Close();
        }
    }
}
