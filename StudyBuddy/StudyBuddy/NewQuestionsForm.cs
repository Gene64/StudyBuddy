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
    public partial class NewQuestionsForm : Form
    {
        public NewQuestionsForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.backButtonPressed = true;
            Properties.Settings.Default.Save();
            Dispose();
            NewCardsForm ncf = new NewCardsForm();
            ncf.ShowDialog();
        }

        private void NewQuestionsForm_Load(object sender, EventArgs e)
        {
            Text = Properties.Settings.Default.index1Name + " Question Adder";
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.index1Question1 = question1TextBox.Text;
            Properties.Settings.Default.index1Answer1 = answer1TextBox.Text;
            Properties.Settings.Default.Save();
            Dispose();
        }
    }
}
