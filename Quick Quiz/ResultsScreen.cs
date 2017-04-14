using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quick_Quiz
{
    public partial class ResultsScreen : Form
    {
        public ResultsScreen(List<Quiz> quizQuestions, Dictionary<int, Tuple<String, CheckBox>> chosenAnswers, int numberOfQuestions)
        {
            InitializeComponent();

            //Total Questions
            labelTotalA.Text = numberOfQuestions.ToString();

            //Calculate Correct Answers
            float correctAnswers = checkAnswers(quizQuestions, chosenAnswers);
            labelCorrectA.Text = correctAnswers.ToString();

            //Calculate IncorrectAnswer Answers
            float incorrectAnswers = (quizQuestions.Count - correctAnswers);
            labelIncorrect.Text = incorrectAnswers.ToString();

            //Calculate Score
            labelScore.Text = ((correctAnswers/quizQuestions.Count)*100).ToString() + "%";
        }

        private int checkAnswers(List<Quiz> quizQuestions, Dictionary<int, Tuple<String, CheckBox>> chosenAnswers)
        {
            int correctAnswers = 0;
            for (int i = 0; i < quizQuestions.Count; i++)
            {
                if (quizQuestions[i].Question.correctAnswer == chosenAnswers[i].Item1)
                {
                    correctAnswers++;
                }
            }
            return correctAnswers;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
