namespace StudyBuddy
{
    partial class OptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.timerCheckBox = new System.Windows.Forms.CheckBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.timerVisibilityCheckBox = new System.Windows.Forms.CheckBox();
            this.editButton = new System.Windows.Forms.Button();
            this.changeQuizDirButton = new System.Windows.Forms.Button();
            this.enableHintCheckBox = new System.Windows.Forms.CheckBox();
            this.hintOptionsButton = new System.Windows.Forms.Button();
            this.nightModeCheckBox = new System.Windows.Forms.CheckBox();
            this.skipEnabledCheckBox = new System.Windows.Forms.CheckBox();
            this.skipOptionsButton = new System.Windows.Forms.Button();
            this.changeCurrentUserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timerCheckBox
            // 
            this.timerCheckBox.AutoSize = true;
            this.timerCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.timerCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerCheckBox.Location = new System.Drawing.Point(12, 12);
            this.timerCheckBox.Name = "timerCheckBox";
            this.timerCheckBox.Size = new System.Drawing.Size(100, 19);
            this.timerCheckBox.TabIndex = 0;
            this.timerCheckBox.Text = "Enable Timer";
            this.timerCheckBox.UseVisualStyleBackColor = false;
            this.timerCheckBox.CheckStateChanged += new System.EventHandler(this.timerCheckBox_CheckStateChanged);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(105, 226);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // timerVisibilityCheckBox
            // 
            this.timerVisibilityCheckBox.AutoSize = true;
            this.timerVisibilityCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.timerVisibilityCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerVisibilityCheckBox.Location = new System.Drawing.Point(118, 12);
            this.timerVisibilityCheckBox.Name = "timerVisibilityCheckBox";
            this.timerVisibilityCheckBox.Size = new System.Drawing.Size(146, 19);
            this.timerVisibilityCheckBox.TabIndex = 2;
            this.timerVisibilityCheckBox.Text = "Enable Timer Visibility";
            this.timerVisibilityCheckBox.UseVisualStyleBackColor = false;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(12, 112);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(80, 35);
            this.editButton.TabIndex = 4;
            this.editButton.Text = "Edit Quiz";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // changeQuizDirButton
            // 
            this.changeQuizDirButton.Location = new System.Drawing.Point(12, 153);
            this.changeQuizDirButton.Name = "changeQuizDirButton";
            this.changeQuizDirButton.Size = new System.Drawing.Size(80, 35);
            this.changeQuizDirButton.TabIndex = 5;
            this.changeQuizDirButton.Text = "Change Quiz Directory";
            this.changeQuizDirButton.UseVisualStyleBackColor = true;
            this.changeQuizDirButton.Click += new System.EventHandler(this.changeQuizDirButton_Click);
            // 
            // enableHintCheckBox
            // 
            this.enableHintCheckBox.AutoSize = true;
            this.enableHintCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.enableHintCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableHintCheckBox.Location = new System.Drawing.Point(12, 37);
            this.enableHintCheckBox.Name = "enableHintCheckBox";
            this.enableHintCheckBox.Size = new System.Drawing.Size(96, 19);
            this.enableHintCheckBox.TabIndex = 6;
            this.enableHintCheckBox.Text = "Enable Hints";
            this.enableHintCheckBox.UseVisualStyleBackColor = false;
            this.enableHintCheckBox.CheckedChanged += new System.EventHandler(this.enableHintCheckBox_CheckedChanged);
            // 
            // hintOptionsButton
            // 
            this.hintOptionsButton.Location = new System.Drawing.Point(118, 35);
            this.hintOptionsButton.Name = "hintOptionsButton";
            this.hintOptionsButton.Size = new System.Drawing.Size(79, 23);
            this.hintOptionsButton.TabIndex = 7;
            this.hintOptionsButton.Text = "Hint Options";
            this.hintOptionsButton.UseVisualStyleBackColor = true;
            this.hintOptionsButton.Visible = false;
            this.hintOptionsButton.Click += new System.EventHandler(this.hintOptionsButton_Click);
            // 
            // nightModeCheckBox
            // 
            this.nightModeCheckBox.AutoSize = true;
            this.nightModeCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.nightModeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightModeCheckBox.Location = new System.Drawing.Point(12, 87);
            this.nightModeCheckBox.Name = "nightModeCheckBox";
            this.nightModeCheckBox.Size = new System.Drawing.Size(90, 19);
            this.nightModeCheckBox.TabIndex = 8;
            this.nightModeCheckBox.Text = "Night Mode";
            this.nightModeCheckBox.UseVisualStyleBackColor = false;
            this.nightModeCheckBox.CheckStateChanged += new System.EventHandler(this.nightModeCheckBox_CheckStateChanged);
            // 
            // skipEnabledCheckBox
            // 
            this.skipEnabledCheckBox.AutoSize = true;
            this.skipEnabledCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.skipEnabledCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skipEnabledCheckBox.Location = new System.Drawing.Point(12, 62);
            this.skipEnabledCheckBox.Name = "skipEnabledCheckBox";
            this.skipEnabledCheckBox.Size = new System.Drawing.Size(105, 19);
            this.skipEnabledCheckBox.TabIndex = 9;
            this.skipEnabledCheckBox.Text = "Skips Enabled";
            this.skipEnabledCheckBox.UseVisualStyleBackColor = false;
            this.skipEnabledCheckBox.CheckedChanged += new System.EventHandler(this.skipEnabledCheckBox_CheckedChanged);
            // 
            // skipOptionsButton
            // 
            this.skipOptionsButton.Location = new System.Drawing.Point(118, 60);
            this.skipOptionsButton.Name = "skipOptionsButton";
            this.skipOptionsButton.Size = new System.Drawing.Size(79, 23);
            this.skipOptionsButton.TabIndex = 10;
            this.skipOptionsButton.Text = "Skip Options";
            this.skipOptionsButton.UseVisualStyleBackColor = true;
            this.skipOptionsButton.Visible = false;
            this.skipOptionsButton.Click += new System.EventHandler(this.skipOptionsButton_Click);
            // 
            // changeCurrentUserButton
            // 
            this.changeCurrentUserButton.Location = new System.Drawing.Point(12, 194);
            this.changeCurrentUserButton.Name = "changeCurrentUserButton";
            this.changeCurrentUserButton.Size = new System.Drawing.Size(80, 35);
            this.changeCurrentUserButton.TabIndex = 11;
            this.changeCurrentUserButton.Text = "Change Current User";
            this.changeCurrentUserButton.UseVisualStyleBackColor = true;
            this.changeCurrentUserButton.Click += new System.EventHandler(this.changeCurrentUserButton_Click);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.changeCurrentUserButton);
            this.Controls.Add(this.skipOptionsButton);
            this.Controls.Add(this.skipEnabledCheckBox);
            this.Controls.Add(this.nightModeCheckBox);
            this.Controls.Add(this.hintOptionsButton);
            this.Controls.Add(this.enableHintCheckBox);
            this.Controls.Add(this.changeQuizDirButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.timerVisibilityCheckBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.timerCheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox timerCheckBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.CheckBox timerVisibilityCheckBox;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button changeQuizDirButton;
        private System.Windows.Forms.CheckBox enableHintCheckBox;
        private System.Windows.Forms.Button hintOptionsButton;
        private System.Windows.Forms.CheckBox nightModeCheckBox;
        private System.Windows.Forms.CheckBox skipEnabledCheckBox;
        private System.Windows.Forms.Button skipOptionsButton;
        private System.Windows.Forms.Button changeCurrentUserButton;
    }
}
