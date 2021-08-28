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
        string threatLvl;


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
                    answerEntryBox.Visible = true;
                    lowCheckBox.Visible = false;
                    mediumCheckBox.Visible = false;
                    highCheckBox.Visible = false;
                    question1.Visible = false;
                    question1Answer.Visible = false;
                    question2.Visible = false;
                    question2Answer.Visible = false;
                    question3.Visible = false;
                    question3Answer.Visible = false;
                    backButton.Visible = false;
                    break;
                // Q2
                case 2:
                    questionNo.Text = "Question 2";
                    questionText.Text = "What is your email?";
                    answerEntryBox.Visible = true;
                    lowCheckBox.Visible = false;
                    mediumCheckBox.Visible = false;
                    highCheckBox.Visible = false;
                    question1.Visible = false;
                    question1Answer.Visible = false;
                    question2.Visible = false;
                    question2Answer.Visible = false;
                    question3.Visible = false;
                    question3Answer.Visible = false;
                    backButton.Visible = false;
                    break;
                // Q3
                case 3:
                    questionNo.Text = "Question 3";
                    questionText.Text = "What level of threat are you reporting?";
                    answerEntryBox.Visible = false;
                    lowCheckBox.Visible = true;
                    mediumCheckBox.Visible = true;
                    highCheckBox.Visible = true;
                    question1.Visible = false;
                    question1Answer.Visible = false;
                    question2.Visible = false;
                    question2Answer.Visible = false;
                    question3.Visible = false;
                    question3Answer.Visible = false;
                    backButton.Visible = true;
                    break;
                // Preview page
                case 4:
                    questionNo.Text = "Preview Page";
                    questionText.Text = "";
                    lowCheckBox.Visible = false;
                    mediumCheckBox.Visible = false;
                    highCheckBox.Visible = false;
                    question1.Visible = true;
                    question1Answer.Visible = true;
                    question2.Visible = true;
                    question2Answer.Visible = true;
                    question3.Visible = true;
                    question3Answer.Visible = true;
                    question1Answer.Text = name;
                    question2Answer.Text = email;
                    question3Answer.Text = threatLvl;
                    backButton.Visible = true;
                    backButton.Text = "Amend Answers";
                    nextButton.Text = "Exit";
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
                if (name.Length < 2 || name.Length > 25)
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

                    // Switch to Q2
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

                    // Switch to Q3
                    questionNumber = 3;
                    askQuestion(questionNumber);
                }
            }
            // Q3
            else if (questionNumber == 3)
            {
                // Check only one is selected
                if(lowCheckBox.Checked == true && mediumCheckBox.Checked == false && highCheckBox.Checked == false || lowCheckBox.Checked == false && mediumCheckBox.Checked == true && highCheckBox.Checked == false || lowCheckBox.Checked == false && mediumCheckBox.Checked == false && highCheckBox.Checked == true)
                {
                    // Set answer for preview page
                    if (lowCheckBox.Checked == true)
                    {
                        threatLvl = "Low";
                    }
                    else if (mediumCheckBox.Checked == true)
                    {
                        threatLvl = "Medium";
                    }
                    else
                    {
                        threatLvl = "High";
                    }

                    warningLabel.Visible = false;

                    // Switch to preview page
                    questionNumber = 4;
                    askQuestion(questionNumber);
                }
                // Or display warning
                else
                {
                    // Display warning
                    warningLabel.Text = "Please select one of the options.";
                    warningLabel.Visible = true;

                }
            }
            else
            {
                this.Close();
            }

            // Enable the button
            nextButton.Enabled = true;
        }

        // Back button on Q3 / Amend button on preview page
        private void backButton_Click(object sender, EventArgs e)
        {
            switch(questionNumber)
            {
                // Page 3
                case 3:
                    questionNumber = 2;
                    askQuestion(questionNumber);
                    break;
                // Preview page
                case 4:
                    questionNumber = 1;
                    backButton.Text = "Back";
                    askQuestion(questionNumber);
                    break;
            }

        }
    }
}
