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
            if (Properties.Settings.Default.backButtonPressed)
            {
                cardGroupNameTextBox.Text = Properties.Settings.Default.index1Name;
                questionNumbersComboBox.Text = Properties.Settings.Default.index1QuestionNumber.ToString();
            }
            else
            {
                questionNumbersComboBox.SelectedIndex = 0;
            }
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
            Properties.Settings.Default.index1Name = cardGroupNameTextBox.Text;
            Properties.Settings.Default.index1QuestionNumber = questionNumbersComboBox.SelectedIndex + 1; // Since the index starts at 0, we just add 1 to match the text.
            Properties.Settings.Default.Save();

            Dispose();
            NewQuestionsForm nqf = new NewQuestionsForm();
            nqf.ShowDialog();
        }

        private void NewCardsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.backButtonPressed = false;
            Properties.Settings.Default.Save();
        }
    }
}
