namespace QuadraticEquationSolver
{
    partial class MainPage
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
            this.aValueLabel = new System.Windows.Forms.Label();
            this.aValueTextBox = new System.Windows.Forms.TextBox();
            this.bValueLabel = new System.Windows.Forms.Label();
            this.cValueLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.BValueTextBox = new System.Windows.Forms.TextBox();
            this.CValueTextBox = new System.Windows.Forms.TextBox();
            this.solutionsLabel = new System.Windows.Forms.Label();
            this.solutionOut = new System.Windows.Forms.TextBox();
            this.solveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aValueLabel
            // 
            this.aValueLabel.AutoSize = true;
            this.aValueLabel.Location = new System.Drawing.Point(12, 54);
            this.aValueLabel.Name = "aValueLabel";
            this.aValueLabel.Size = new System.Drawing.Size(44, 13);
            this.aValueLabel.TabIndex = 0;
            this.aValueLabel.Text = "A Value";
            // 
            // aValueTextBox
            // 
            this.aValueTextBox.Location = new System.Drawing.Point(15, 70);
            this.aValueTextBox.Name = "aValueTextBox";
            this.aValueTextBox.Size = new System.Drawing.Size(41, 20);
            this.aValueTextBox.TabIndex = 1;
            // 
            // bValueLabel
            // 
            this.bValueLabel.AutoSize = true;
            this.bValueLabel.Location = new System.Drawing.Point(120, 54);
            this.bValueLabel.Name = "bValueLabel";
            this.bValueLabel.Size = new System.Drawing.Size(44, 13);
            this.bValueLabel.TabIndex = 4;
            this.bValueLabel.Text = "B Value";
            // 
            // cValueLabel
            // 
            this.cValueLabel.AutoSize = true;
            this.cValueLabel.Location = new System.Drawing.Point(228, 54);
            this.cValueLabel.Name = "cValueLabel";
            this.cValueLabel.Size = new System.Drawing.Size(44, 13);
            this.cValueLabel.TabIndex = 5;
            this.cValueLabel.Text = "C Value";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(48, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(189, 16);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "Quadratic Equation Solver";
            // 
            // BValueTextBox
            // 
            this.BValueTextBox.Location = new System.Drawing.Point(123, 70);
            this.BValueTextBox.Name = "BValueTextBox";
            this.BValueTextBox.Size = new System.Drawing.Size(41, 20);
            this.BValueTextBox.TabIndex = 7;
            // 
            // CValueTextBox
            // 
            this.CValueTextBox.Location = new System.Drawing.Point(231, 70);
            this.CValueTextBox.Name = "CValueTextBox";
            this.CValueTextBox.Size = new System.Drawing.Size(41, 20);
            this.CValueTextBox.TabIndex = 8;
            // 
            // solutionsLabel
            // 
            this.solutionsLabel.AutoSize = true;
            this.solutionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solutionsLabel.Location = new System.Drawing.Point(62, 177);
            this.solutionsLabel.Name = "solutionsLabel";
            this.solutionsLabel.Size = new System.Drawing.Size(161, 20);
            this.solutionsLabel.TabIndex = 9;
            this.solutionsLabel.Text = "There are 2 solutions:";
            // 
            // solutionOut
            // 
            this.solutionOut.Location = new System.Drawing.Point(92, 219);
            this.solutionOut.Name = "solutionOut";
            this.solutionOut.ReadOnly = true;
            this.solutionOut.Size = new System.Drawing.Size(100, 20);
            this.solutionOut.TabIndex = 10;
            // 
            // solveButton
            // 
            this.solveButton.Location = new System.Drawing.Point(105, 113);
            this.solveButton.Name = "solveButton";
            this.solveButton.Size = new System.Drawing.Size(75, 23);
            this.solveButton.TabIndex = 11;
            this.solveButton.Text = "Solve";
            this.solveButton.UseVisualStyleBackColor = true;
            this.solveButton.Click += new System.EventHandler(this.solveButton_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.solveButton);
            this.Controls.Add(this.solutionOut);
            this.Controls.Add(this.solutionsLabel);
            this.Controls.Add(this.CValueTextBox);
            this.Controls.Add(this.BValueTextBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.cValueLabel);
            this.Controls.Add(this.bValueLabel);
            this.Controls.Add(this.aValueTextBox);
            this.Controls.Add(this.aValueLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quadratic Equation Solver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aValueLabel;
        private System.Windows.Forms.TextBox aValueTextBox;
        private System.Windows.Forms.Label bValueLabel;
        private System.Windows.Forms.Label cValueLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox BValueTextBox;
        private System.Windows.Forms.TextBox CValueTextBox;
        private System.Windows.Forms.Label solutionsLabel;
        private System.Windows.Forms.TextBox solutionOut;
        private System.Windows.Forms.Button solveButton;
    }
}

