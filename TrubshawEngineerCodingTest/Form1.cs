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
        string email;


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

        // Check email function
        bool checkEmail(string email)
        {
            // Check if valid address
            try 
            {
                var address = new System.Net.Mail.MailAddress(email);
                return address.Address == email;
            }
            // If not, return false
            catch 
            {
                return false;
            }

        }

        // Button to advance to next question
        private void nextButton_Click(object sender, EventArgs e)
        {
            // Disable button to prevent multiple submissions
            nextButton.Enabled = false;

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
                    nextButton.Enabled = true;
                }
                // If correct proceed to Q2
                else
                {
                    warningLabel.Visible = false;
                    answerEntryBox.Clear();
                    questionNumber = 2;
                    askQuestion(questionNumber);
                }
            }
            // Q2
            else if (questionNumber == 2)
            {
                // Get email from text box
                email = answerEntryBox.Text;

                // Check name
                if (checkEmail(email) == false)
                {
                    // Display warning
                    warningLabel.Text = "Please enter a valid email address.";
                    warningLabel.Visible = true;
                    nextButton.Enabled = true;
                }
                // If correct proceed to Q3
                else
                {
                    warningLabel.Visible = false;
                    answerEntryBox.Clear();
                    questionNumber = 3;
                    askQuestion(questionNumber);
                }
            }

            // Enable the button
            nextButton.Enabled = true;
        }

        // Back button to return to question 2
        private void backButton_Click(object sender, EventArgs e)
        {
            questionNumber = 2;
            askQuestion(questionNumber);
        }
    }
}
