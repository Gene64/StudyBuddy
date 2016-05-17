namespace StudyBuddy.Forms.OptionsForm
{
    partial class UniversalExtraOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UniversalExtraOptions));
            this.universalTextBox = new System.Windows.Forms.TextBox();
            this.universalLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // universalTextBox
            // 
            this.universalTextBox.Location = new System.Drawing.Point(163, 6);
            this.universalTextBox.Name = "universalTextBox";
            this.universalTextBox.Size = new System.Drawing.Size(37, 20);
            this.universalTextBox.TabIndex = 0;
            // 
            // universalLabel
            // 
            this.universalLabel.AutoSize = true;
            this.universalLabel.Location = new System.Drawing.Point(12, 9);
            this.universalLabel.Name = "universalLabel";
            this.universalLabel.Size = new System.Drawing.Size(145, 13);
            this.universalLabel.TabIndex = 1;
            this.universalLabel.Text = "Give hint after this many tries:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(105, 71);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // UniversalExtraOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 106);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.universalLabel);
            this.Controls.Add(this.universalTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UniversalExtraOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Extra Options";
            this.Load += new System.EventHandler(this.UniversalExtraOptions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox universalTextBox;
        private System.Windows.Forms.Label universalLabel;
        private System.Windows.Forms.Button saveButton;
    }
}