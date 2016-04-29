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
            this.label1 = new System.Windows.Forms.Label();
            this.quizNameTextBox = new System.Windows.Forms.TextBox();
            this.questionNumbersComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.alreadyExistsLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quiz Name";
            // 
            // quizNameTextBox
            // 
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of Questions";
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
            this.alreadyExistsLabel.BackColor = System.Drawing.Color.Black;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Create a new quiz by filling out the information\nbelow to help you study.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewCardsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudyBuddy.Properties.Resources.A;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.alreadyExistsLabel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.questionNumbersComboBox);
            this.Controls.Add(this.quizNameTextBox);
            this.Controls.Add(this.label1);
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox quizNameTextBox;
        private System.Windows.Forms.ComboBox questionNumbersComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label alreadyExistsLabel;
        private System.Windows.Forms.Label label3;
    }
}