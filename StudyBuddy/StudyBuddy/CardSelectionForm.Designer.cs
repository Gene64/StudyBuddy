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
            this.topic1Button = new System.Windows.Forms.Button();
            this.quizSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // topic1Button
            // 
            this.topic1Button.Location = new System.Drawing.Point(97, 162);
            this.topic1Button.Name = "topic1Button";
            this.topic1Button.Size = new System.Drawing.Size(89, 23);
            this.topic1Button.TabIndex = 1;
            this.topic1Button.Text = "Start Studying";
            this.topic1Button.UseVisualStyleBackColor = true;
            this.topic1Button.Click += new System.EventHandler(this.topic1Button_Click);
            // 
            // quizSelectionComboBox
            // 
            this.quizSelectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.quizSelectionComboBox.FormattingEnabled = true;
            this.quizSelectionComboBox.Location = new System.Drawing.Point(82, 37);
            this.quizSelectionComboBox.Name = "quizSelectionComboBox";
            this.quizSelectionComboBox.Size = new System.Drawing.Size(121, 21);
            this.quizSelectionComboBox.TabIndex = 2;
            // 
            // CardSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.quizSelectionComboBox);
            this.Controls.Add(this.topic1Button);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CardSelectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StudyCardSelectionForm";
            this.Load += new System.EventHandler(this.CardSelectionForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button topic1Button;
        private System.Windows.Forms.ComboBox quizSelectionComboBox;
    }
}