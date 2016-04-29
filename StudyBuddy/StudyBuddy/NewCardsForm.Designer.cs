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
            label1 = new System.Windows.Forms.Label();
            quizNameTextBox = new System.Windows.Forms.TextBox();
            questionNumbersComboBox = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            nextButton = new System.Windows.Forms.Button();
            alreadyExistsLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.White;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(108, 67);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(69, 15);
            label1.TabIndex = 0;
            label1.Text = "Quiz Name";
            // 
            // quizNameTextBox
            // 
            quizNameTextBox.Location = new System.Drawing.Point(82, 85);
            quizNameTextBox.Name = "quizNameTextBox";
            quizNameTextBox.Size = new System.Drawing.Size(121, 20);
            quizNameTextBox.TabIndex = 1;
            quizNameTextBox.TextChanged += new System.EventHandler(cardGroupNameTextBox_TextChanged);
            // 
            // questionNumbersComboBox
            // 
            questionNumbersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            questionNumbersComboBox.FormattingEnabled = true;
            questionNumbersComboBox.Items.AddRange(new object[] {
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
            questionNumbersComboBox.Location = new System.Drawing.Point(82, 150);
            questionNumbersComboBox.Name = "questionNumbersComboBox";
            questionNumbersComboBox.Size = new System.Drawing.Size(121, 21);
            questionNumbersComboBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.White;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(79, 132);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(123, 15);
            label2.TabIndex = 3;
            label2.Text = "Number of Questions";
            // 
            // nextButton
            // 
            nextButton.Enabled = false;
            nextButton.Location = new System.Drawing.Point(105, 226);
            nextButton.Name = "nextButton";
            nextButton.Size = new System.Drawing.Size(75, 23);
            nextButton.TabIndex = 4;
            nextButton.Text = "Next";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += new System.EventHandler(nextButton_Click);
            // 
            // alreadyExistsLabel
            // 
            alreadyExistsLabel.AutoSize = true;
            alreadyExistsLabel.BackColor = System.Drawing.Color.Black;
            alreadyExistsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            alreadyExistsLabel.ForeColor = System.Drawing.Color.Red;
            alreadyExistsLabel.Location = new System.Drawing.Point(30, 190);
            alreadyExistsLabel.Name = "alreadyExistsLabel";
            alreadyExistsLabel.Size = new System.Drawing.Size(225, 16);
            alreadyExistsLabel.TabIndex = 5;
            alreadyExistsLabel.Text = "Please enter a valid quiz name.";
            alreadyExistsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            alreadyExistsLabel.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.White;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(5, 9);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(274, 32);
            label3.TabIndex = 6;
            label3.Text = "Create a new quiz by filling out the information\nbelow to help you study.";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewCardsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.A;
            ClientSize = new System.Drawing.Size(284, 261);
            Controls.Add(label3);
            Controls.Add(alreadyExistsLabel);
            Controls.Add(nextButton);
            Controls.Add(label2);
            Controls.Add(questionNumbersComboBox);
            Controls.Add(quizNameTextBox);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NewCardsForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "New Quiz Creation";
            FormClosing += new System.Windows.Forms.FormClosingEventHandler(NewCardsForm_FormClosing);
            Load += new System.EventHandler(NewCardsForm_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox quizNameTextBox;
        private System.Windows.Forms.ComboBox questionNumbersComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label alreadyExistsLabel;
        private System.Windows.Forms.Label label3;
    }
}