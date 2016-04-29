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
            startStudyingButton = new System.Windows.Forms.Button();
            quizSelectionComboBox = new System.Windows.Forms.ComboBox();
            directionsLabel = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // startStudyingButton
            // 
            startStudyingButton.Location = new System.Drawing.Point(98, 226);
            startStudyingButton.Name = "startStudyingButton";
            startStudyingButton.Size = new System.Drawing.Size(89, 23);
            startStudyingButton.TabIndex = 1;
            startStudyingButton.Text = "Start Studying";
            startStudyingButton.UseVisualStyleBackColor = true;
            startStudyingButton.Click += new System.EventHandler(topic1Button_Click);
            // 
            // quizSelectionComboBox
            // 
            quizSelectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            quizSelectionComboBox.FormattingEnabled = true;
            quizSelectionComboBox.Location = new System.Drawing.Point(82, 44);
            quizSelectionComboBox.Name = "quizSelectionComboBox";
            quizSelectionComboBox.Size = new System.Drawing.Size(121, 21);
            quizSelectionComboBox.TabIndex = 2;
            // 
            // directionsLabel
            // 
            directionsLabel.AutoSize = true;
            directionsLabel.BackColor = System.Drawing.Color.Transparent;
            directionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            directionsLabel.Location = new System.Drawing.Point(14, 9);
            directionsLabel.Name = "directionsLabel";
            directionsLabel.Size = new System.Drawing.Size(256, 32);
            directionsLabel.TabIndex = 3;
            directionsLabel.Text = "Pick one of your quizes from the box\nbelow to begin studying!";
            directionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CardSelectionForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.A;
            ClientSize = new System.Drawing.Size(284, 261);
            Controls.Add(directionsLabel);
            Controls.Add(quizSelectionComboBox);
            Controls.Add(startStudyingButton);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CardSelectionForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Study Quiz Selection";
            Load += new System.EventHandler(CardSelectionForm_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button startStudyingButton;
        private System.Windows.Forms.ComboBox quizSelectionComboBox;
        private System.Windows.Forms.Label directionsLabel;
    }
}