
namespace TrubshawEngineerCodingTest
{
    partial class TrubshawEngineerCodingTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nextButton = new System.Windows.Forms.Button();
            this.questionNo = new System.Windows.Forms.Label();
            this.questionText = new System.Windows.Forms.Label();
            this.answerEntryBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.warningLabel = new System.Windows.Forms.Label();
            this.lowCheckBox = new System.Windows.Forms.CheckBox();
            this.mediumCheckBox = new System.Windows.Forms.CheckBox();
            this.highCheckBox = new System.Windows.Forms.CheckBox();
            this.question1 = new System.Windows.Forms.Label();
            this.question2 = new System.Windows.Forms.Label();
            this.question3 = new System.Windows.Forms.Label();
            this.question1Answer = new System.Windows.Forms.Label();
            this.question2Answer = new System.Windows.Forms.Label();
            this.question3Answer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(488, 311);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(168, 51);
            this.nextButton.TabIndex = 0;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // questionNo
            // 
            this.questionNo.AutoSize = true;
            this.questionNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionNo.Location = new System.Drawing.Point(1, -1);
            this.questionNo.Name = "questionNo";
            this.questionNo.Size = new System.Drawing.Size(195, 51);
            this.questionNo.TabIndex = 1;
            this.questionNo.Text = "Question";
            // 
            // questionText
            // 
            this.questionText.AutoSize = true;
            this.questionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionText.Location = new System.Drawing.Point(4, 50);
            this.questionText.Name = "questionText";
            this.questionText.Size = new System.Drawing.Size(183, 31);
            this.questionText.TabIndex = 2;
            this.questionText.Text = "Question Text";
            // 
            // answerEntryBox
            // 
            this.answerEntryBox.Location = new System.Drawing.Point(12, 133);
            this.answerEntryBox.Name = "answerEntryBox";
            this.answerEntryBox.Size = new System.Drawing.Size(347, 20);
            this.answerEntryBox.TabIndex = 3;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 311);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(168, 51);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.ForeColor = System.Drawing.Color.Red;
            this.warningLabel.Location = new System.Drawing.Point(9, 108);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(70, 13);
            this.warningLabel.TabIndex = 5;
            this.warningLabel.Text = "warningLabel";
            // 
            // lowCheckBox
            // 
            this.lowCheckBox.AutoSize = true;
            this.lowCheckBox.Location = new System.Drawing.Point(14, 135);
            this.lowCheckBox.Name = "lowCheckBox";
            this.lowCheckBox.Size = new System.Drawing.Size(46, 17);
            this.lowCheckBox.TabIndex = 6;
            this.lowCheckBox.Text = "Low";
            this.lowCheckBox.UseVisualStyleBackColor = true;
            // 
            // mediumCheckBox
            // 
            this.mediumCheckBox.AutoSize = true;
            this.mediumCheckBox.Location = new System.Drawing.Point(106, 135);
            this.mediumCheckBox.Name = "mediumCheckBox";
            this.mediumCheckBox.Size = new System.Drawing.Size(63, 17);
            this.mediumCheckBox.TabIndex = 7;
            this.mediumCheckBox.Text = "Medium";
            this.mediumCheckBox.UseVisualStyleBackColor = true;
            // 
            // highCheckBox
            // 
            this.highCheckBox.AutoSize = true;
            this.highCheckBox.Location = new System.Drawing.Point(213, 135);
            this.highCheckBox.Name = "highCheckBox";
            this.highCheckBox.Size = new System.Drawing.Size(48, 17);
            this.highCheckBox.TabIndex = 8;
            this.highCheckBox.Text = "High";
            this.highCheckBox.UseVisualStyleBackColor = true;
            // 
            // question1
            // 
            this.question1.AutoSize = true;
            this.question1.Location = new System.Drawing.Point(9, 84);
            this.question1.Name = "question1";
            this.question1.Size = new System.Drawing.Size(158, 13);
            this.question1.TabIndex = 9;
            this.question1.Text = "Question 1: What is your name?";
            // 
            // question2
            // 
            this.question2.AutoSize = true;
            this.question2.Location = new System.Drawing.Point(210, 84);
            this.question2.Name = "question2";
            this.question2.Size = new System.Drawing.Size(156, 13);
            this.question2.TabIndex = 10;
            this.question2.Text = "Question 2: What is your email?";
            // 
            // question3
            // 
            this.question3.AutoSize = true;
            this.question3.Location = new System.Drawing.Point(418, 84);
            this.question3.Name = "question3";
            this.question3.Size = new System.Drawing.Size(245, 13);
            this.question3.TabIndex = 11;
            this.question3.Text = "Question 3: What level of threat are you reporting?";
            // 
            // question1Answer
            // 
            this.question1Answer.AutoSize = true;
            this.question1Answer.Location = new System.Drawing.Point(9, 101);
            this.question1Answer.Name = "question1Answer";
            this.question1Answer.Size = new System.Drawing.Size(43, 13);
            this.question1Answer.TabIndex = 12;
            this.question1Answer.Text = "Q1ANS";
            // 
            // question2Answer
            // 
            this.question2Answer.AutoSize = true;
            this.question2Answer.Location = new System.Drawing.Point(210, 101);
            this.question2Answer.Name = "question2Answer";
            this.question2Answer.Size = new System.Drawing.Size(43, 13);
            this.question2Answer.TabIndex = 13;
            this.question2Answer.Text = "Q2ANS";
            // 
            // question3Answer
            // 
            this.question3Answer.AutoSize = true;
            this.question3Answer.Location = new System.Drawing.Point(418, 101);
            this.question3Answer.Name = "question3Answer";
            this.question3Answer.Size = new System.Drawing.Size(43, 13);
            this.question3Answer.TabIndex = 14;
            this.question3Answer.Text = "Q3ANS";
            // 
            // TrubshawEngineerCodingTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 374);
            this.Controls.Add(this.question3Answer);
            this.Controls.Add(this.question2Answer);
            this.Controls.Add(this.question1Answer);
            this.Controls.Add(this.question3);
            this.Controls.Add(this.question2);
            this.Controls.Add(this.question1);
            this.Controls.Add(this.highCheckBox);
            this.Controls.Add(this.mediumCheckBox);
            this.Controls.Add(this.lowCheckBox);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.answerEntryBox);
            this.Controls.Add(this.questionText);
            this.Controls.Add(this.questionNo);
            this.Controls.Add(this.nextButton);
            this.Name = "TrubshawEngineerCodingTest";
            this.Text = "Trubshaw Engineer Coding Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label questionNo;
        private System.Windows.Forms.Label questionText;
        private System.Windows.Forms.TextBox answerEntryBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.CheckBox lowCheckBox;
        private System.Windows.Forms.CheckBox mediumCheckBox;
        private System.Windows.Forms.CheckBox highCheckBox;
        private System.Windows.Forms.Label question1;
        private System.Windows.Forms.Label question2;
        private System.Windows.Forms.Label question3;
        private System.Windows.Forms.Label question1Answer;
        private System.Windows.Forms.Label question2Answer;
        private System.Windows.Forms.Label question3Answer;
    }
}

