namespace StudyBuddy
{
    partial class StudyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudyForm));
            questionLabel = new System.Windows.Forms.Label();
            answerTextBox = new System.Windows.Forms.TextBox();
            nextQuestionButton = new System.Windows.Forms.Button();
            currentQuestionLabel = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // questionLabel
            // 
            questionLabel.AutoSize = true;
            questionLabel.Location = new System.Drawing.Point(107, 60);
            questionLabel.Name = "questionLabel";
            questionLabel.Size = new System.Drawing.Size(71, 13);
            questionLabel.TabIndex = 0;
            questionLabel.Text = "First Question";
            questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answerTextBox
            // 
            answerTextBox.Location = new System.Drawing.Point(79, 177);
            answerTextBox.Name = "answerTextBox";
            answerTextBox.Size = new System.Drawing.Size(127, 20);
            answerTextBox.TabIndex = 1;
            // 
            // nextQuestionButton
            // 
            nextQuestionButton.Location = new System.Drawing.Point(98, 226);
            nextQuestionButton.Name = "nextQuestionButton";
            nextQuestionButton.Size = new System.Drawing.Size(88, 23);
            nextQuestionButton.TabIndex = 2;
            nextQuestionButton.Text = "Next Question";
            nextQuestionButton.UseVisualStyleBackColor = true;
            nextQuestionButton.Click += new System.EventHandler(nextQuestionButton_Click);
            // 
            // currentQuestionLabel
            // 
            currentQuestionLabel.AutoSize = true;
            currentQuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            currentQuestionLabel.Location = new System.Drawing.Point(102, 15);
            currentQuestionLabel.Name = "currentQuestionLabel";
            currentQuestionLabel.Size = new System.Drawing.Size(81, 16);
            currentQuestionLabel.TabIndex = 3;
            currentQuestionLabel.Text = "Question 1";
            // 
            // StudyForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.A;
            ClientSize = new System.Drawing.Size(284, 261);
            Controls.Add(currentQuestionLabel);
            Controls.Add(nextQuestionButton);
            Controls.Add(answerTextBox);
            Controls.Add(questionLabel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StudyForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Study Quiz";
            Load += new System.EventHandler(StudyForm_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Button nextQuestionButton;
        private System.Windows.Forms.Label currentQuestionLabel;
    }
}