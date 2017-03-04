using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prog2017
{
    public partial class DialogWindow : Form
    {
        public DialogWindow()
        {
            InitializeComponent();
        }

        private void DialogWindow_Load(object sender, EventArgs e)
        {

        }

        private void AButton_Press(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
                MessageBox.Show("You press \"A\"!");
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
                QuestionsBox.Text = String.Format("Is your number bigger than {0}?", NumberGuessWolF.StartGuess(true));
                QuestionsCounter.Text = String.Format("Answered questions: {0}", NumberGuessWolF.numberOfQuestions);
            if (!(NumberGuessWolF.low < NumberGuessWolF.high))
            {
                Introduction.Text = String.Format("Your number is {0}!", NumberGuessWolF.high);
                QuestionsBox.Text = String.Format("I guessed it in {0} questions!", NumberGuessWolF.numberOfQuestions);
                YesButton.Visible = false;
                YesButton.Enabled = false;
                NoButton.Visible = false;
                NoButton.Enabled = false;
                QuestionsCounter.Visible = false;
                QuestionsCounter.Enabled = false;

            }
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
                QuestionsBox.Text = String.Format("Is your number bigger than {0}?", NumberGuessWolF.StartGuess(false));
                QuestionsCounter.Text = String.Format("Answered questions: {0}", NumberGuessWolF.numberOfQuestions);
                if (!(NumberGuessWolF.low < NumberGuessWolF.high))
                {
                    Introduction.Text = String.Format("Your number is {0}!", NumberGuessWolF.high);
                    QuestionsBox.Text = String.Format("I guessed it in {0} questions!", NumberGuessWolF.numberOfQuestions);
                    YesButton.Visible = false;
                    YesButton.Enabled = false;
                    NoButton.Visible = false;
                    NoButton.Enabled = false;
                    QuestionsCounter.Visible = false;
                    QuestionsCounter.Enabled = false;
                }
            }

        private void StartButton_Click(object sender, EventArgs e)
        {
            Introduction.Text = "Answer the questions (yes or no)";
            QuestionsBox.Visible = true;
            QuestionsBox.Enabled = true;
            QuestionsBox.Text = String.Format("Is your number bigger than {0}?", NumberGuessWolF.middle);
            QuestionsCounter.Visible = true;
            QuestionsCounter.Enabled = true;
            QuestionsCounter.Text = String.Format("Answered questions: {0}", NumberGuessWolF.numberOfQuestions);
            StartButton.Visible = false;
            StartButton.Enabled = false;
            YesButton.Visible = true;
            YesButton.Enabled = true;
            NoButton.Visible = true;
            NoButton.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
