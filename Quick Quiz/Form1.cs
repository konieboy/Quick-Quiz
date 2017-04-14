using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Quick_Quiz
{

    public partial class StartForm : Form
    {
        public List<Quiz> QuizQuestions;

        public StartForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle; //Prevent Resizing
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            // Show the dialog and get result.
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                string fileName = openFileDialog.FileName;
                try
                {
                    //Read json file
                    string text = File.ReadAllText(fileName);
                    if (String.IsNullOrEmpty(text))
                    {
                        showInputError();
                    }
                    this.QuizQuestions = JsonConvert.DeserializeObject<List<Quiz>>(text);
                }

                catch (IOException)
                {
                    showInputError();
                    throw new IOException();
                }
                Console.WriteLine(result); // <-- For debugging use.

                //File Loaded
                StartButton.Enabled = true;
            }
            Console.WriteLine(result); // <-- For debugging use.
        }

        public void showInputError()
        {
             MessageBox.Show("The file you selected is empty or in an invalid format. \nPlease try Again.",
              "File Input Error",
              MessageBoxButtons.OK,
              MessageBoxIcon.Asterisk
              );


        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            //Launch new form with Quiz
            QuizForm quizUI = new QuizForm(QuizQuestions);
            quizUI.Show();
            this.Hide();
        }

    }

}



