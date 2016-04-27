namespace StudyBuddy
{
    partial class LoadInForm
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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.DirectionsLabel = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.practiceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.Location = new System.Drawing.Point(50, 9);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(185, 16);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Welcome to Study Buddy!";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DirectionsLabel
            // 
            this.DirectionsLabel.AutoSize = true;
            this.DirectionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirectionsLabel.Location = new System.Drawing.Point(39, 25);
            this.DirectionsLabel.Name = "DirectionsLabel";
            this.DirectionsLabel.Size = new System.Drawing.Size(207, 32);
            this.DirectionsLabel.TabIndex = 1;
            this.DirectionsLabel.Text = "Select one of the options below to\nstart studying!";
            this.DirectionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(163, 133);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(115, 30);
            this.createButton.TabIndex = 2;
            this.createButton.Text = "Create Study Cards";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            this.createButton.MouseLeave += new System.EventHandler(this.createButton_MouseLeave);
            this.createButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.createButton_MouseMove);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(9, 133);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(115, 30);
            this.editButton.TabIndex = 3;
            this.editButton.Text = "Edit Study Cards";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.MouseLeave += new System.EventHandler(this.loadButton_MouseLeave);
            this.editButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.loadButton_MouseMove);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(81, 199);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(123, 13);
            this.descriptionLabel.TabIndex = 5;
            this.descriptionLabel.Text = "Button Description Label";
            this.descriptionLabel.Visible = false;
            // 
            // practiceButton
            // 
            this.practiceButton.Location = new System.Drawing.Point(89, 97);
            this.practiceButton.Name = "practiceButton";
            this.practiceButton.Size = new System.Drawing.Size(115, 30);
            this.practiceButton.TabIndex = 6;
            this.practiceButton.Text = "Practice Study Cards";
            this.practiceButton.UseVisualStyleBackColor = true;
            this.practiceButton.Click += new System.EventHandler(this.useButton_Click);
            // 
            // LoadInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.practiceButton);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.DirectionsLabel);
            this.Controls.Add(this.WelcomeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Study Buddy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label DirectionsLabel;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Button practiceButton;
    }
}