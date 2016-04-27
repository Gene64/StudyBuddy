using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyBuddy
{
    public partial class NewCardsForm : Form
    {
        public NewCardsForm()
        {
            InitializeComponent();
        }

        private void NewCardsForm_Load(object sender, EventArgs e)
        {
            questionNumbersComboBox.SelectedIndex = 0;
        }

        private void cardGroupNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (cardGroupNameTextBox.Text == "")
            {
                nextButton.Enabled = false;
            }
            else
            {
                nextButton.Enabled = true;
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Name1 = cardGroupNameTextBox.Text;
            int numVal = int.Parse(questionNumbersComboBox.Text); // We needed to change the text string to a valid integer.
            Properties.Settings.Default.Questions1 = numVal;
            Properties.Settings.Default.Save();
            Dispose();
        }
    }
}
