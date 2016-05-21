namespace StudyBuddy
{
    partial class NewCardsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewCardsForm));
            this.quizNameLabel = new System.Windows.Forms.Label();
            this.quizNameTextBox = new System.Windows.Forms.TextBox();
            this.questionNumbersComboBox = new System.Windows.Forms.ComboBox();
            this.numberOfQuestionsLabel = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.alreadyExistsLabel = new System.Windows.Forms.Label();
            this.newQuizDescriptionLabel = new System.Windows.Forms.Label();
            this.hintCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // quizNameLabel
            // 
            this.quizNameLabel.AutoSize = true;
            this.quizNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.quizNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quizNameLabel.Location = new System.Drawing.Point(108, 67);
            this.quizNameLabel.Name = "quizNameLabel";
            this.quizNameLabel.Size = new System.Drawing.Size(69, 15);
            this.quizNameLabel.TabIndex = 0;
            this.quizNameLabel.Text = "Quiz Name";
            // 
            // quizNameTextBox
            // 
            this.quizNameTextBox.BackColor = System.Drawing.Color.White;
            this.quizNameTextBox.Location = new System.Drawing.Point(82, 85);
            this.quizNameTextBox.Name = "quizNameTextBox";
            this.quizNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.quizNameTextBox.TabIndex = 1;
            this.quizNameTextBox.TextChanged += new System.EventHandler(this.cardGroupNameTextBox_TextChanged);
            // 
            // questionNumbersComboBox
            // 
            this.questionNumbersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.questionNumbersComboBox.FormattingEnabled = true;
            this.questionNumbersComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.questionNumbersComboBox.Location = new System.Drawing.Point(82, 150);
            this.questionNumbersComboBox.Name = "questionNumbersComboBox";
            this.questionNumbersComboBox.Size = new System.Drawing.Size(121, 21);
            this.questionNumbersComboBox.TabIndex = 2;
            // 
            // numberOfQuestionsLabel
            // 
            this.numberOfQuestionsLabel.AutoSize = true;
            this.numberOfQuestionsLabel.BackColor = System.Drawing.Color.White;
            this.numberOfQuestionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfQuestionsLabel.Location = new System.Drawing.Point(79, 132);
            this.numberOfQuestionsLabel.Name = "numberOfQuestionsLabel";
            this.numberOfQuestionsLabel.Size = new System.Drawing.Size(123, 15);
            this.numberOfQuestionsLabel.TabIndex = 3;
            this.numberOfQuestionsLabel.Text = "Number of Questions";
            // 
            // nextButton
            // 
            this.nextButton.Enabled = false;
            this.nextButton.Location = new System.Drawing.Point(105, 226);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 4;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // alreadyExistsLabel
            // 
            this.alreadyExistsLabel.AutoSize = true;
            this.alreadyExistsLabel.BackColor = System.Drawing.Color.Transparent;
            this.alreadyExistsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alreadyExistsLabel.ForeColor = System.Drawing.Color.Red;
            this.alreadyExistsLabel.Location = new System.Drawing.Point(30, 190);
            this.alreadyExistsLabel.Name = "alreadyExistsLabel";
            this.alreadyExistsLabel.Size = new System.Drawing.Size(225, 16);
            this.alreadyExistsLabel.TabIndex = 5;
            this.alreadyExistsLabel.Text = "Please enter a valid quiz name.";
            this.alreadyExistsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.alreadyExistsLabel.Visible = false;
            // 
            // newQuizDescriptionLabel
            // 
            this.newQuizDescriptionLabel.AutoSize = true;
            this.newQuizDescriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.newQuizDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newQuizDescriptionLabel.Location = new System.Drawing.Point(5, 9);
            this.newQuizDescriptionLabel.Name = "newQuizDescriptionLabel";
            this.newQuizDescriptionLabel.Size = new System.Drawing.Size(274, 32);
            this.newQuizDescriptionLabel.TabIndex = 6;
            this.newQuizDescriptionLabel.Text = "Create a new quiz by filling out the information\nbelow to help you study.";
            this.newQuizDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hintCheckBox
            // 
            this.hintCheckBox.AutoSize = true;
            this.hintCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.hintCheckBox.Location = new System.Drawing.Point(209, 85);
            this.hintCheckBox.Name = "hintCheckBox";
            this.hintCheckBox.Size = new System.Drawing.Size(50, 17);
            this.hintCheckBox.TabIndex = 7;
            this.hintCheckBox.Text = "Hints";
            this.hintCheckBox.UseVisualStyleBackColor = false;
            // 
            // NewCardsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.hintCheckBox);
            this.Controls.Add(this.newQuizDescriptionLabel);
            this.Controls.Add(this.alreadyExistsLabel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.numberOfQuestionsLabel);
            this.Controls.Add(this.questionNumbersComboBox);
            this.Controls.Add(this.quizNameTextBox);
            this.Controls.Add(this.quizNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewCardsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Quiz Creation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewCardsForm_FormClosing);
            this.Load += new System.EventHandler(this.NewCardsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label quizNameLabel;
        private System.Windows.Forms.TextBox quizNameTextBox;
        private System.Windows.Forms.ComboBox questionNumbersComboBox;
        private System.Windows.Forms.Label numberOfQuestionsLabel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label alreadyExistsLabel;
        private System.Windows.Forms.Label newQuizDescriptionLabel;
        private System.Windows.Forms.CheckBox hintCheckBox;
    }
}
