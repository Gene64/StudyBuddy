using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudyBuddy.Forms.OptionsForm
{
    public partial class UniversalExtraOptions : Form
    {
        public UniversalExtraOptions()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.currentSelectedOption == 1 || Properties.Settings.Default.currentSelectedOption == 2)
            {
                int selectedNumber;
                if (int.TryParse(universalTextBox.Text, out selectedNumber))
                {
                    if (Properties.Settings.Default.currentSelectedOption == 1)
                        Properties.Settings.Default.hintTries = selectedNumber;
                }
            }
            else if (Properties.Settings.Default.currentUser == "")
            {
                if (universalTextBox.Text.Length >= 20)
                    MessageBox.Show("Please choose a username that's 20 characters or less.");
                else
                    Properties.Settings.Default.currentUser = universalTextBox.Text;
            }
            Properties.Settings.Default.Save();
            Dispose();
        }

        private void UniversalExtraOptions_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.currentSelectedOption == 1)
            {
                universalLabel.Text = "Give hint after this many tries:";
                universalTextBox.Location = new Point(163, 6);
                if (Properties.Settings.Default.hintTries == 0)
                {
                    Properties.Settings.Default.hintTries = 1; // 1 is the default number of tries
                    Properties.Settings.Default.Save();
                }
                universalTextBox.Text = Properties.Settings.Default.hintTries.ToString();
            }
            else if (Properties.Settings.Default.currentSelectedOption == 2)
                universalLabel.Text = "Number of available skips:";
            else if (Properties.Settings.Default.currentUser == "")
            {
                saveButton.Text = "Next";
                universalLabel.Text = "Please enter a username:";
                universalTextBox.Size = new Size(100, 20);
                universalTextBox.Location = new Point(140, 6);
            }
            
            else
            {
                MessageBox.Show("Whoops, something went wrong. The application will now close.");
                Application.Exit();
            }
        }
    }
}
