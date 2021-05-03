
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
    public partial class MainWindow : Window
    {
       
        List<int> questionNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int qNum = 0;
  
        int i;

        int score;
        public MainWindow()
        {
            InitializeComponent();
            StartGame();
            NextQuestion();

        }

        private void checkAnswer(object sender, RoutedEventArgs e)
        {
            Button senderButton = sender as Button;

            if (senderButton.Tag.ToString() == "1")
            {
                score++;
            }

            if (qNum < 0)
            {
                qNum = 0;
            }
            else
            {
                qNum++;
            }

            scoreText.Content = "Answered correctly" + score + "/" + questionNumbers.Count;

            NextQuestion();

        }

        private void RestardGame() 
        {
            score = 0;
            qNum = -1;
            i = 0;
            StartGame();


        }

        private void NextQuestion() 
        { 
            if(qNum < questionNumbers.Count)
            {
                i = questionNumbers[qNum];
            }
            else
            {
                RestardGame();
            }

            foreach (var x in MyCanvas.Children.OfType<Button>())
            {
                x.Tag = "0";
                x.Background = Brushes.DarkSalmon;
            }

            switch (i)
            {
                case 1:
                    txtQuestions.Text = "Question 1";

                    ans1.Content = "Answer 1";
                    ans2.Content = "Answer 2 Correct";
                    ans3.Content = "Answer 3";
                    ans4.Content = "Answer 4";

                    break;
            }




        }

        private void StartGame()
        {
            var randomList = questionNumbers.OrderBy(a => Guid.NewGuid()).ToList();

            questionNumbers = randomList;
            questionOrder.Content = null;

            for (int i = 0; i < questionNumbers.Count; i++ )
            {
                questionOrder.Content += "" + questionNumbers[i].ToString();
            }
        }
    }
}
