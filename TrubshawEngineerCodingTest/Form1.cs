using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Niall Swan

namespace TrubshawEngineerCodingTest
{
    public partial class Form1 : Form
    {

        // Variables
        int questionNumber = 1;

        string name;


        // Window
        public Form1()
        {
            InitializeComponent();
            warningLabel.Visible = false;
            askQuestion(questionNumber);

        }

        // Question function
        private void askQuestion(int qNum)
        {
            // Switch Current Question
            switch (qNum)
            {
                // Q1
                case 1:
                    questionNo.Text = "Question 1";
                    questionText.Text = "What is your name?";
                    backButton.Visible = false;
                    break;
                // Q2
                case 2:
                    questionNo.Text = "Question 2";
                    questionText.Text = "What is your email?";
                    backButton.Visible = false;
                    break;
                // Q3
                case 3:
                    questionNo.Text = "Question 3";
                    questionText.Text = "What level of threat are you reporting?";
                    backButton.Visible = true;
                    break;
            }
        }

        
        // Button to advance to next question
        private void nextButton_Click(object sender, EventArgs e)
        {
            // Q1
            if(questionNumber == 1)
            {
                // Get name from text box
                name = answerEntryBox.Text;

                // Check name
                if(name.Length < 2 || name.Length > 25)
                {
                    // Display warning
                    warningLabel.Text = "Please enter a name between 2 and 25 characters in length.";
                    warningLabel.Visible = true;
                }
                // If correct proceed to Q2
                else
                {
                    warningLabel.Visible = false;
                    questionNumber = 2;
                    askQuestion(questionNumber);
                    answerEntryBox.Clear();
                }
            }

        }

        // Back button to return to question 2
        private void backButton_Click(object sender, EventArgs e)
        {
            questionNumber = 2;
            askQuestion(questionNumber);
        }
    }
}
