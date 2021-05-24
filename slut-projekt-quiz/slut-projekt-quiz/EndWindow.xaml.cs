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
    /// Interaction logic for EndWindow.xaml
    /// </summary>
    public partial class EndWindow : Window
    {
        public EndWindow() //Klassen är en funktionalitet där man kan välja om man vill köra spelet igen eller inte
        {
            InitializeComponent();
            
        }

        private void PlayAgain(object sender, RoutedEventArgs e) //När spelaren trycker på button "Play Again" ska det öppnas WindowGame fönstret där spelet körs
        {
            this.Close(); //EndWindow-fönstret stängs
            WindowGame windowGame = new WindowGame(); //WindowGame-fönstret öppnas
            windowGame.ShowDialog();
        }

        private void No(object sender, RoutedEventArgs e) //EndWindow-fönstret stängs
        {
            this.Close();
        }
    }
}
