using System;
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

namespace slut_projekt_quiz
{
    /// <summary>
    /// Interaction logic for start.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Yes(object sender, RoutedEventArgs e)
        {
            WindowGame windowGame = new WindowGame();
            windowGame.ShowDialog();
        }

        private void No(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
