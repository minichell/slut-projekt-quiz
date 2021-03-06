
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace slut_projekt_quiz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class WindowGame : Window //Klassen är spelets funktionalitet
    {

        //En lista på 10 frågor och man ser numrerna som kommer blanda detta inuti startspelfunktionen
        List<int> questionNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


        //qNum som styr vilken fråga som visas på skärmen, i och score
        int qNum = 0;
        int i;
        int score;
        public WindowGame()
        {
            InitializeComponent();

            //Inuti funktionen kommer vi att köra startspelet (StartGame) och nästa frågefunktion (NextQuestion)

            StartGame();
            NextQuestion();

        }

        private void checkAnswer(object sender, RoutedEventArgs e)

        {
            //Detta är händelse för checkAnswer, den här händelsen är länkad till knapparna på duken
            //När någan av dess knapparna trycks kommer vi att köra denna händelsen


            Button senderButton = sender as Button;

            //i If-systemet nedan kommer man kontrollera om den klickade på knappen har en 1 Tag inuti, om den gör det kommer vi lägga till 1 poäng

            if (senderButton.Tag.ToString() == "1")
            {
                score++;
            }

            //Om qNum är mindre än 0 kommer vi att återställa qNum-heltalet till 0
            if (qNum < 0)
            {
                qNum = 0;
            }
            else
            {
             //Om qNum är större än 0 kommer vi lägga 1 till qNum-heltalet
                qNum++;
            }

            //Den uppdaterar poängen varje gång du trycker på knapparna
            scoreText.Content = "Answered correctly" + score + "/" + questionNumbers.Count;

            NextQuestion();

        }

        private void RestartGame() 
        {
            //RestardGame är en funktion där spelet kommer att stängas och att EndWindow öppnas så att spelaren kan välja om att spela igen eller inte
            this.Close(); //Sänger fönstret
            EndWindow endWindow = new EndWindow(); //Öppnar EndWindow
            endWindow.ShowDialog();


        }

        private void NextQuestion() 
        {
            //I den är funktionen kontrollerar den vilken fråga som ska visas nästa och den kommer att ha alla definitioner av frågor och svar

            //i if-systemet nedan kommer det att kontrolleras om qNum är mindre än det totala antalet fårgor, då sätter på i till värdet på qNum


            if (qNum < questionNumbers.Count)
            {
                i = questionNumbers[qNum];
            }
            else
            {
                //Om vi har besvarat alla frågor så startas RestardGame
                RestartGame();
            }

            foreach (var x in MyCanvas.Children.OfType<Button>())
            {
                x.Tag = "0"; //Nya knappar ska ha Tags tillbaks till 0
                x.Background = Brushes.LightCyan; //Sätter knapparnas färger till Lightcyan
            }

            switch (i)
            {
                case 1:
                    txtQuestion.Text = "Who is the main character in the Moana movie"; //Detta är frågan till fråge quizen

                    ans1.Content = "Tamatoa"; //Var och en av knapparna kan ha sina egna svar i det här spelet.
                    ans2.Content = "Moana";
                    ans3.Content = "Hei Hei";
                    ans4.Content = "Maui";

                    ans2.Tag = "1"; //Här berättar vi för programmet vilket av alternativet är korrekta.

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/1.jpg"));

                    break;

                case 2:
                    txtQuestion.Text = "Who does the voice of Maui";

                    ans1.Content = "The Rock";
                    ans2.Content = "Nicole";
                    ans3.Content = "Troy";
                    ans4.Content = "Alan";

                    ans1.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/2.jpeg"));

                    break;

                case 3:
                    txtQuestion.Text = "What is the name of Mickey's sister?";

                    ans1.Content = "Carla";
                    ans2.Content = "Doreen";
                    ans3.Content = "Ameila";
                    ans4.Content = "Bonnie";

                    ans3.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/3.jpg"));

                    break;

                case 4:
                    txtQuestion.Text = "What is the name of Princess Jasmine's tiger?";

                    ans1.Content = "Jafar";
                    ans2.Content = "Abu";
                    ans3.Content = "Lago";
                    ans4.Content = "Raja";

                    ans4.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/4.jpg"));

                    break;

                case 5:
                    txtQuestion.Text = "who is playing cinderella";

                    ans1.Content = "Lily James";
                    ans2.Content = "Helena Bonham Carter";
                    ans3.Content = "Nonso Anozie";
                    ans4.Content = "Richard Madden";

                    ans1.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/5.jpg"));

                    break;

                case 6:
                    txtQuestion.Text = "which date release the new lion king movie";

                    ans1.Content = "May 5, 2019";
                    ans2.Content = "June 6, 2019";
                    ans3.Content = "July 9, 2019";
                    ans4.Content = "July 9, 2022";

                    ans3.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/6.jpg"));

                    break;


                case 7:
                    txtQuestion.Text = "What is the name of the sea that Elsa must face on her journey?";

                    ans1.Content = "The Salty Sea";
                    ans2.Content = "The Dark Sea";
                    ans3.Content = "The Wet Sea";
                    ans4.Content = "The light Sea";

                    ans2.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/7.jpeg"));

                    break;

                case 8:
                    txtQuestion.Text = "What is Rapunzel's dream?";

                    ans1.Content = "To find true love";
                    ans2.Content = "To see the floating lanterns gleam ";
                    ans3.Content = "To have a birthday party";
                    ans4.Content = "To leave her tower";

                    ans2.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/8.jpg"));

                    break;

                case 9:
                    txtQuestion.Text = "Who was Mowgli raised by?";

                    ans1.Content = "People";
                    ans2.Content = "Monkeys";
                    ans3.Content = "Wolves";
                    ans4.Content = "Ducks";

                    ans3.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/9.jpg"));

                    break;

                case 10:
                    txtQuestion.Text = "Who plays Malificent";

                    ans1.Content = "Angelina Jolie";
                    ans2.Content = "Elle Fanning";
                    ans3.Content = "Ella Purnell";
                    ans4.Content = "Imelda Staunton";

                    ans1.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/10.jpg"));

                    break;
            }
        }

        private void StartGame()
        {
            //Detta är startspelfunktionen
            //inuti denna funktionen slumpar man ifrågasättningslista och sparar den tillbaks i listan

            var randomList = questionNumbers.OrderBy(a => Guid.NewGuid()).ToList();

            questionNumbers = randomList;
            questionOrder.Content = null;

            //En foor-loop som lägger till värdet som visar den randomiserade listan till skärmen så att vi kan se hur randomiserats

            for (int i = 0; i < questionNumbers.Count; i++ )
            {
                questionOrder.Content += "" + questionNumbers[i].ToString();
            }
        }
    }
}
