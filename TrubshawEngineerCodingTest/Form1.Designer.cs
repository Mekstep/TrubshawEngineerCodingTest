
namespace TrubshawEngineerCodingTest
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(620, 387);
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
            this.questionNo.Location = new System.Drawing.Point(3, 31);
            this.questionNo.Name = "questionNo";
            this.questionNo.Size = new System.Drawing.Size(195, 51);
            this.questionNo.TabIndex = 1;
            this.questionNo.Text = "Question";
            // 
            // questionText
            // 
            this.questionText.AutoSize = true;
            this.questionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionText.Location = new System.Drawing.Point(4, 82);
            this.questionText.Name = "questionText";
            this.questionText.Size = new System.Drawing.Size(257, 44);
            this.questionText.TabIndex = 2;
            this.questionText.Text = "Question Text";
            // 
            // answerEntryBox
            // 
            this.answerEntryBox.Location = new System.Drawing.Point(12, 168);
            this.answerEntryBox.Name = "answerEntryBox";
            this.answerEntryBox.Size = new System.Drawing.Size(347, 20);
            this.answerEntryBox.TabIndex = 3;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 387);
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
            this.warningLabel.Location = new System.Drawing.Point(12, 143);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(70, 13);
            this.warningLabel.TabIndex = 5;
            this.warningLabel.Text = "warningLabel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.answerEntryBox);
            this.Controls.Add(this.questionText);
            this.Controls.Add(this.questionNo);
            this.Controls.Add(this.nextButton);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

