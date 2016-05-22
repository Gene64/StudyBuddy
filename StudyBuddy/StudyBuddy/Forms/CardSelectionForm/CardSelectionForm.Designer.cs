namespace StudyBuddy
{
    partial class CardSelectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardSelectionForm));
            this.startStudyingButton = new System.Windows.Forms.Button();
            this.quizSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.directionsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startStudyingButton
            // 
            this.startStudyingButton.Location = new System.Drawing.Point(98, 226);
            this.startStudyingButton.Name = "startStudyingButton";
            this.startStudyingButton.Size = new System.Drawing.Size(89, 23);
            this.startStudyingButton.TabIndex = 1;
            this.startStudyingButton.Text = "Start Studying";
            this.startStudyingButton.UseVisualStyleBackColor = true;
            this.startStudyingButton.Click += new System.EventHandler(this.topic1Button_Click);
            // 
            // quizSelectionComboBox
            // 
            this.quizSelectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.quizSelectionComboBox.FormattingEnabled = true;
            this.quizSelectionComboBox.Location = new System.Drawing.Point(82, 44);
            this.quizSelectionComboBox.Name = "quizSelectionComboBox";
            this.quizSelectionComboBox.Size = new System.Drawing.Size(121, 21);
            this.quizSelectionComboBox.TabIndex = 2;
            // 
            // directionsLabel
            // 
            this.directionsLabel.AutoSize = true;
            this.directionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.directionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directionsLabel.Location = new System.Drawing.Point(11, 9);
            this.directionsLabel.Name = "directionsLabel";
            this.directionsLabel.Size = new System.Drawing.Size(263, 32);
            this.directionsLabel.TabIndex = 3;
            this.directionsLabel.Text = "Pick one of your quizzes from the box\nbelow to begin studying!";
            this.directionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CardSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.directionsLabel);
            this.Controls.Add(this.quizSelectionComboBox);
            this.Controls.Add(this.startStudyingButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CardSelectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Study Quiz Selection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CardSelectionForm_FormClosing);
            this.Load += new System.EventHandler(this.CardSelectionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button startStudyingButton;
        private System.Windows.Forms.ComboBox quizSelectionComboBox;
        private System.Windows.Forms.Label directionsLabel;
    }
}
