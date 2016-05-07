namespace StudyBuddy
{
    partial class ChangeQuizDirForm
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
            this.changeDirButton = new System.Windows.Forms.Button();
            this.directoryTextBox = new System.Windows.Forms.TextBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // changeDirButton
            // 
            this.changeDirButton.Location = new System.Drawing.Point(12, 38);
            this.changeDirButton.Name = "changeDirButton";
            this.changeDirButton.Size = new System.Drawing.Size(75, 23);
            this.changeDirButton.TabIndex = 0;
            this.changeDirButton.Text = "Change";
            this.changeDirButton.UseVisualStyleBackColor = true;
            this.changeDirButton.Click += new System.EventHandler(this.changeDirButton_Click);
            // 
            // directoryTextBox
            // 
            this.directoryTextBox.Location = new System.Drawing.Point(12, 12);
            this.directoryTextBox.Name = "directoryTextBox";
            this.directoryTextBox.ReadOnly = true;
            this.directoryTextBox.Size = new System.Drawing.Size(260, 20);
            this.directoryTextBox.TabIndex = 1;
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(105, 226);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 2;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // ChangeQuizDirForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudyBuddy.Properties.Resources.A;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.directoryTextBox);
            this.Controls.Add(this.changeDirButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeQuizDirForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Change Quiz Directory";
            this.Load += new System.EventHandler(this.ChangeQuizDirForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changeDirButton;
        private System.Windows.Forms.TextBox directoryTextBox;
        private System.Windows.Forms.Button applyButton;
    }
}