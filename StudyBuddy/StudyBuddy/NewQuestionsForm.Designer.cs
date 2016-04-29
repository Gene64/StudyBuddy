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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewQuestionsForm));
            backButton = new System.Windows.Forms.Button();
            questionHeaderLabel = new System.Windows.Forms.Label();
            answerHeaderLabel = new System.Windows.Forms.Label();
            questionTextBox = new System.Windows.Forms.TextBox();
            answerTextBox = new System.Windows.Forms.TextBox();
            nextQuestionButton = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            currentQuestionLabel = new System.Windows.Forms.Label();
            previousQuestionButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.Location = new System.Drawing.Point(12, 214);
            backButton.Name = "backButton";
            backButton.Size = new System.Drawing.Size(70, 35);
            backButton.TabIndex = 0;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += new System.EventHandler(backButton_Click);
            // 
            // questionHeaderLabel
            // 
            questionHeaderLabel.AutoSize = true;
            questionHeaderLabel.Location = new System.Drawing.Point(9, 81);
            questionHeaderLabel.Name = "questionHeaderLabel";
            questionHeaderLabel.Size = new System.Drawing.Size(65, 13);
            questionHeaderLabel.TabIndex = 1;
            questionHeaderLabel.Text = "Question #1";
            // 
            // answerHeaderLabel
            // 
            answerHeaderLabel.AutoSize = true;
            answerHeaderLabel.Location = new System.Drawing.Point(9, 143);
            answerHeaderLabel.Name = "answerHeaderLabel";
            answerHeaderLabel.Size = new System.Drawing.Size(58, 13);
            answerHeaderLabel.TabIndex = 2;
            answerHeaderLabel.Text = "Answer #1";
            // 
            // questionTextBox
            // 
            questionTextBox.Location = new System.Drawing.Point(12, 97);
            questionTextBox.Name = "questionTextBox";
            questionTextBox.Size = new System.Drawing.Size(260, 20);
            questionTextBox.TabIndex = 3;
            // 
            // answerTextBox
            // 
            answerTextBox.Location = new System.Drawing.Point(12, 159);
            answerTextBox.Name = "answerTextBox";
            answerTextBox.Size = new System.Drawing.Size(260, 20);
            answerTextBox.TabIndex = 4;
            // 
            // nextQuestionButton
            // 
            nextQuestionButton.Location = new System.Drawing.Point(202, 214);
            nextQuestionButton.Name = "nextQuestionButton";
            nextQuestionButton.Size = new System.Drawing.Size(70, 35);
            nextQuestionButton.TabIndex = 5;
            nextQuestionButton.Text = "Next Question";
            nextQuestionButton.UseVisualStyleBackColor = true;
            nextQuestionButton.Click += new System.EventHandler(nextQuestionButton_Click);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(13, 9);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(258, 32);
            label3.TabIndex = 6;
            label3.Text = "Fill out the questions and answers to\nadd them.";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentQuestionLabel
            // 
            currentQuestionLabel.AutoSize = true;
            currentQuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            currentQuestionLabel.Location = new System.Drawing.Point(77, 50);
            currentQuestionLabel.Name = "currentQuestionLabel";
            currentQuestionLabel.Size = new System.Drawing.Size(130, 16);
            currentQuestionLabel.TabIndex = 7;
            currentQuestionLabel.Text = "Current Question: 0/1";
            // 
            // previousQuestionButton
            // 
            previousQuestionButton.Location = new System.Drawing.Point(107, 214);
            previousQuestionButton.Name = "previousQuestionButton";
            previousQuestionButton.Size = new System.Drawing.Size(70, 35);
            previousQuestionButton.TabIndex = 8;
            previousQuestionButton.Text = "Previous Question";
            previousQuestionButton.UseVisualStyleBackColor = true;
            previousQuestionButton.Visible = false;
            previousQuestionButton.Click += new System.EventHandler(previousQuestionButton_Click);
            // 
            // NewQuestionsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.A;
            ClientSize = new System.Drawing.Size(284, 261);
            Controls.Add(previousQuestionButton);
            Controls.Add(currentQuestionLabel);
            Controls.Add(label3);
            Controls.Add(nextQuestionButton);
            Controls.Add(answerTextBox);
            Controls.Add(questionTextBox);
            Controls.Add(answerHeaderLabel);
            Controls.Add(questionHeaderLabel);
            Controls.Add(backButton);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            Name = "NewQuestionsForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "New Questions";
            FormClosing += new System.Windows.Forms.FormClosingEventHandler(NewQuestionsForm_FormClosing);
            Load += new System.EventHandler(NewQuestionsForm_Load);
            ResumeLayout(false);
            PerformLayout();

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