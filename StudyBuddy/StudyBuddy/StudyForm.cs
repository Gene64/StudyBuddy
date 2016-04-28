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
    public partial class StudyForm : Form
    {
        public StudyForm()
        {
            InitializeComponent();
        }

        private void StudyForm_Load(object sender, EventArgs e)
        {
            //questionLabel.Text = Properties.Settings.Default.index1Question1;
        }

        private void nextQuestionButton_Click(object sender, EventArgs e)
        {
            //if (questionLabel.Text == Properties.Settings.Default.index1Question1)
            {
                //if (answerTextBox.Text == Properties.Settings.Default.index1Question1)
                {
                    MessageBox.Show("Correct answer!");
                }
                //else
                {
                    MessageBox.Show("Sorry, wrong answer.");
                }
            }
        }
    }
}
