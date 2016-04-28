namespace StudyBuddy
{
    partial class NewQuestionsForm
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
            this.backButton = new System.Windows.Forms.Button();
            this.questionHeaderLabel = new System.Windows.Forms.Label();
            this.answerHeaderLabel = new System.Windows.Forms.Label();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.nextQuestionButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.currentQuestionLabel = new System.Windows.Forms.Label();
            this.previousQuestionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 214);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(70, 35);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // questionHeaderLabel
            // 
            this.questionHeaderLabel.AutoSize = true;
            this.questionHeaderLabel.Location = new System.Drawing.Point(9, 81);
            this.questionHeaderLabel.Name = "questionHeaderLabel";
            this.questionHeaderLabel.Size = new System.Drawing.Size(65, 13);
            this.questionHeaderLabel.TabIndex = 1;
            this.questionHeaderLabel.Text = "Question #1";
            // 
            // answerHeaderLabel
            // 
            this.answerHeaderLabel.AutoSize = true;
            this.answerHeaderLabel.Location = new System.Drawing.Point(9, 143);
            this.answerHeaderLabel.Name = "answerHeaderLabel";
            this.answerHeaderLabel.Size = new System.Drawing.Size(58, 13);
            this.answerHeaderLabel.TabIndex = 2;
            this.answerHeaderLabel.Text = "Answer #1";
            // 
            // questionTextBox
            // 
            this.questionTextBox.Location = new System.Drawing.Point(12, 97);
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(260, 20);
            this.questionTextBox.TabIndex = 3;
            // 
            // answerTextBox
            // 
            this.answerTextBox.Location = new System.Drawing.Point(12, 159);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(260, 20);
            this.answerTextBox.TabIndex = 4;
            // 
            // nextQuestionButton
            // 
            this.nextQuestionButton.Location = new System.Drawing.Point(202, 214);
            this.nextQuestionButton.Name = "nextQuestionButton";
            this.nextQuestionButton.Size = new System.Drawing.Size(70, 35);
            this.nextQuestionButton.TabIndex = 5;
            this.nextQuestionButton.Text = "Next Question";
            this.nextQuestionButton.UseVisualStyleBackColor = true;
            this.nextQuestionButton.Click += new System.EventHandler(this.nextQuestionButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fill out the questions and answers to\nadd them.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentQuestionLabel
            // 
            this.currentQuestionLabel.AutoSize = true;
            this.currentQuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentQuestionLabel.Location = new System.Drawing.Point(77, 50);
            this.currentQuestionLabel.Name = "currentQuestionLabel";
            this.currentQuestionLabel.Size = new System.Drawing.Size(130, 16);
            this.currentQuestionLabel.TabIndex = 7;
            this.currentQuestionLabel.Text = "Current Question: 0/1";
            // 
            // previousQuestionButton
            // 
            this.previousQuestionButton.Location = new System.Drawing.Point(107, 214);
            this.previousQuestionButton.Name = "previousQuestionButton";
            this.previousQuestionButton.Size = new System.Drawing.Size(70, 35);
            this.previousQuestionButton.TabIndex = 8;
            this.previousQuestionButton.Text = "Previous Question";
            this.previousQuestionButton.UseVisualStyleBackColor = true;
            this.previousQuestionButton.Visible = false;
            this.previousQuestionButton.Click += new System.EventHandler(this.previousQuestionButton_Click);
            // 
            // NewQuestionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.previousQuestionButton);
            this.Controls.Add(this.currentQuestionLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nextQuestionButton);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.questionTextBox);
            this.Controls.Add(this.answerHeaderLabel);
            this.Controls.Add(this.questionHeaderLabel);
            this.Controls.Add(this.backButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NewQuestionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Questions";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewQuestionsForm_FormClosing);
            this.Load += new System.EventHandler(this.NewQuestionsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label questionHeaderLabel;
        private System.Windows.Forms.Label answerHeaderLabel;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Button nextQuestionButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label currentQuestionLabel;
        private System.Windows.Forms.Button previousQuestionButton;
    }
}