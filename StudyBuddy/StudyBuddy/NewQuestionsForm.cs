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
    }
}
