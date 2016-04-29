namespace StudyBuddy
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            WelcomeLabel = new System.Windows.Forms.Label();
            createButton = new System.Windows.Forms.Button();
            editButton = new System.Windows.Forms.Button();
            descriptionLabel = new System.Windows.Forms.Label();
            practiceButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.BackColor = System.Drawing.Color.Transparent;
            WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            WelcomeLabel.Location = new System.Drawing.Point(42, 9);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new System.Drawing.Size(201, 18);
            WelcomeLabel.TabIndex = 0;
            WelcomeLabel.Text = "Welcome to Study Buddy!";
            WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createButton
            // 
            createButton.Location = new System.Drawing.Point(12, 214);
            createButton.Name = "createButton";
            createButton.Size = new System.Drawing.Size(75, 35);
            createButton.TabIndex = 2;
            createButton.Text = "Create Study Cards";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += new System.EventHandler(createButton_Click);
            createButton.MouseLeave += new System.EventHandler(createButton_MouseLeave);
            createButton.MouseMove += new System.Windows.Forms.MouseEventHandler(createButton_MouseMove);
            // 
            // editButton
            // 
            editButton.Location = new System.Drawing.Point(197, 214);
            editButton.Name = "editButton";
            editButton.Size = new System.Drawing.Size(75, 35);
            editButton.TabIndex = 3;
            editButton.Text = "Edit Study Cards";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += new System.EventHandler(editButton_Click);
            editButton.MouseLeave += new System.EventHandler(editButton_MouseLeave);
            editButton.MouseMove += new System.Windows.Forms.MouseEventHandler(editButton_MouseMove);
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.BackColor = System.Drawing.Color.Transparent;
            descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionLabel.Location = new System.Drawing.Point(60, 164);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(165, 15);
            descriptionLabel.TabIndex = 5;
            descriptionLabel.Text = "Button Description Label";
            descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            descriptionLabel.Visible = false;
            // 
            // practiceButton
            // 
            practiceButton.Location = new System.Drawing.Point(105, 214);
            practiceButton.Name = "practiceButton";
            practiceButton.Size = new System.Drawing.Size(75, 35);
            practiceButton.TabIndex = 6;
            practiceButton.Text = "Practice Study Cards";
            practiceButton.UseVisualStyleBackColor = true;
            practiceButton.Click += new System.EventHandler(practiceButton_Click);
            practiceButton.MouseLeave += new System.EventHandler(practiceButton_MouseLeave);
            practiceButton.MouseMove += new System.Windows.Forms.MouseEventHandler(practiceButton_MouseMove);
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.A;
            ClientSize = new System.Drawing.Size(284, 261);
            Controls.Add(practiceButton);
            Controls.Add(descriptionLabel);
            Controls.Add(editButton);
            Controls.Add(createButton);
            Controls.Add(WelcomeLabel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainMenuForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Study Buddy";
            Load += new System.EventHandler(MainMenuForm_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Button practiceButton;
    }
}