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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudyForm));
            this.questionLabel = new System.Windows.Forms.Label();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.nextQuestionButton = new System.Windows.Forms.Button();
            this.currentQuestionLabel = new System.Windows.Forms.Label();
            this.questionTimer = new System.Windows.Forms.Timer(this.components);
            this.timerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.BackColor = System.Drawing.Color.White;
            this.questionLabel.Location = new System.Drawing.Point(107, 60);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(71, 13);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "First Question";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answerTextBox
            // 
            this.answerTextBox.Location = new System.Drawing.Point(79, 177);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(127, 20);
            this.answerTextBox.TabIndex = 1;
            // 
            // nextQuestionButton
            // 
            this.nextQuestionButton.Location = new System.Drawing.Point(98, 226);
            this.nextQuestionButton.Name = "nextQuestionButton";
            this.nextQuestionButton.Size = new System.Drawing.Size(88, 23);
            this.nextQuestionButton.TabIndex = 2;
            this.nextQuestionButton.Text = "Next Question";
            this.nextQuestionButton.UseVisualStyleBackColor = true;
            this.nextQuestionButton.Click += new System.EventHandler(this.nextQuestionButton_Click);
            // 
            // currentQuestionLabel
            // 
            this.currentQuestionLabel.AutoSize = true;
            this.currentQuestionLabel.BackColor = System.Drawing.Color.White;
            this.currentQuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentQuestionLabel.Location = new System.Drawing.Point(102, 15);
            this.currentQuestionLabel.Name = "currentQuestionLabel";
            this.currentQuestionLabel.Size = new System.Drawing.Size(81, 16);
            this.currentQuestionLabel.TabIndex = 3;
            this.currentQuestionLabel.Text = "Question 1";
            // 
            // questionTimer
            // 
            this.questionTimer.Interval = 1000;
            this.questionTimer.Tick += new System.EventHandler(this.questionTimer_Tick);
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.BackColor = System.Drawing.Color.White;
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.Location = new System.Drawing.Point(236, 9);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(36, 16);
            this.timerLabel.TabIndex = 4;
            this.timerLabel.Text = "0:00";
            // 
            // StudyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudyBuddy.Properties.Resources.A;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.currentQuestionLabel);
            this.Controls.Add(this.nextQuestionButton);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.questionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Study Quiz";
            this.Load += new System.EventHandler(this.StudyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Button nextQuestionButton;
        private System.Windows.Forms.Label currentQuestionLabel;
        private System.Windows.Forms.Timer questionTimer;
        private System.Windows.Forms.Label timerLabel;
    }
}