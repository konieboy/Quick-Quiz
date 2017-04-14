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
    public partial class QuizForm : Form
    {
        private int QuesionNumber;
        private Dictionary<int, Tuple<String,CheckBox>> chosenAnswers = new Dictionary<int, Tuple<string, CheckBox>>(); //Question, answerChosen
        private List<Quiz> QuizQuestions;


        public QuizForm(List<Quiz> QuizQuestions)
        {
            InitializeComponent();
            this.QuizQuestions = QuizQuestions;
            QuesionNumber = 0;

            initQuestions();

            if (QuizQuestions.First() == QuizQuestions.Last())
            {
                ButtonNext.Text = "Finish";
            }

        }


        private void QuizForm_Load(object sender, EventArgs e)
        {

        }

        private void checkQuestion1_Click(object sender, EventArgs e)
        {

            checkQuestion2.Checked = false;
            checkQuestion3.Checked = false;
            checkQuestion4.Checked = false;

            if (checkQuestion1.Checked)
            {
                //Override the previous answer
                if (chosenAnswers.ContainsKey(QuesionNumber))
                {
                    chosenAnswers[QuesionNumber] = Tuple.Create(labelAnswer1.Text, checkQuestion1);
                }
                else
                {
                    chosenAnswers.Add(QuesionNumber, Tuple.Create(labelAnswer1.Text, checkQuestion1));
                }
                if (QuizQuestions.Count == chosenAnswers.Count)
                {
                    ButtonNext.Enabled = true;
                }

            }
            else
            {
                chosenAnswers.Remove(QuesionNumber);
                if (ButtonNext.Text == "Finish")
                {
                    ButtonNext.Enabled = false;
                }

            }


        }

        private void checkQuestion2_Click(object sender, EventArgs e)
        {
            checkQuestion1.Checked = false;
            checkQuestion3.Checked = false;
            checkQuestion4.Checked = false;
            if (checkQuestion2.Checked)
            {
                //Override the previous answer
                if (chosenAnswers.ContainsKey(QuesionNumber))
                {
                    chosenAnswers[QuesionNumber] = Tuple.Create(labelAnswer2.Text, checkQuestion2);
                }
                else
                {
                    chosenAnswers.Add(QuesionNumber, Tuple.Create(labelAnswer2.Text, checkQuestion2));
                }
                if (QuizQuestions.Count == chosenAnswers.Count)
                {
                    ButtonNext.Enabled = true;
                }
            }
            else
            {
                chosenAnswers.Remove(QuesionNumber);
                if (ButtonNext.Text == "Finish")
                {
                    ButtonNext.Enabled = false;
                }
            }

        }

        private void checkQuestion3_Click(object sender, EventArgs e)
        {

            checkQuestion1.Checked = false;
            checkQuestion2.Checked = false;
            checkQuestion4.Checked = false;
            if (checkQuestion3.Checked)
            {
                //Override the previous answer
                if (chosenAnswers.ContainsKey(QuesionNumber))
                {
                    chosenAnswers[QuesionNumber] = Tuple.Create(labelAnswer3.Text, checkQuestion3);
                }
                else
                {
                    chosenAnswers.Add(QuesionNumber, Tuple.Create(labelAnswer3.Text, checkQuestion3));
                }
                if (QuizQuestions.Count == chosenAnswers.Count)
                {
                    ButtonNext.Enabled = true;
                }
            }
            else
            {
                chosenAnswers.Remove(QuesionNumber);
                if (ButtonNext.Text == "Finish")
                {
                    ButtonNext.Enabled = false;
                }
            }
        }

        private void checkQuestion4_Click(object sender, EventArgs e)
        {

            checkQuestion1.Checked = false;
            checkQuestion2.Checked = false;
            checkQuestion3.Checked = false;

            if (checkQuestion4.Checked)
            {
                //Override the previous answer
                if (chosenAnswers.ContainsKey(QuesionNumber))
                {
                    chosenAnswers[QuesionNumber] = Tuple.Create(labelAnswer4.Text, checkQuestion4);
                }
                else
                {
                    chosenAnswers.Add(QuesionNumber, Tuple.Create(labelAnswer4.Text, checkQuestion4));
                }
                if (QuizQuestions.Count == chosenAnswers.Count)
                {
                    ButtonNext.Enabled = true;
                }
            }
            else
            {
                chosenAnswers.Remove(QuesionNumber);
                if (ButtonNext.Text == "Finish")
                {
                    ButtonNext.Enabled = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            QuesionNumber -= 1;

            ButtonNext.Enabled = true;

            //TODO - put this in initQuestions
            ButtonNext.Text = "Next";

            //If first question, Disable back button
            if (QuesionNumber == 0)
            {
                buttonBack.Enabled = false;
            }

            //Clear the button
            checkQuestion1.Checked = false;
            checkQuestion2.Checked = false;
            checkQuestion3.Checked = false;
            checkQuestion4.Checked = false;

            if (chosenAnswers.ContainsKey(QuesionNumber))
            {
                chosenAnswers[QuesionNumber].Item2.Checked = true;
            }

            initQuestions();
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {

            //Check if this is the 2nd last
            if ((QuesionNumber + 1) == (QuizQuestions.Count - 1))
            {
                //Change NextBox text to Finish
                ButtonNext.Text = "Finish";

                //TODO Only enable if 
                if (chosenAnswers.Count != QuizQuestions.Count)
                {
                    ButtonNext.Enabled = false;
                }
                else
                {
                    ButtonNext.Enabled = true;
                }

            }

            //Check if this is the last question
            //If so, end the quiz and show results screen
            if ((QuesionNumber + 1) == QuizQuestions.Count)
            {
                //Hide Quiz Screen
                this.Close();
                //Show results screen
                ResultsScreen resultsScreen = new ResultsScreen(QuizQuestions, chosenAnswers, QuesionNumber + 1);
                resultsScreen.Show();
                this.Hide();
            }
            else
            {
                QuesionNumber += 1;

                buttonBack.Enabled = true;

                checkQuestion1.Checked = false;
                checkQuestion2.Checked = false;
                checkQuestion3.Checked = false;
                checkQuestion4.Checked = false;

                if (chosenAnswers.ContainsKey(QuesionNumber))
                {
                    chosenAnswers[QuesionNumber].Item2.Checked = true;
                }

                initQuestions();
            }
        }

        private void initQuestions()
        {
            labelQuestionNumber.Text = "Question " + (QuesionNumber + 1);

            labelQuestionText.Text = QuizQuestions[QuesionNumber].Question.question;

            //Posible answers
            labelAnswer1.Text = QuizQuestions[QuesionNumber].Question.answerA;
            labelAnswer2.Text = QuizQuestions[QuesionNumber].Question.answerB;
            labelAnswer3.Text = QuizQuestions[QuesionNumber].Question.answerC;
            labelAnswer4.Text = QuizQuestions[QuesionNumber].Question.answerD;
        }
    }

}
