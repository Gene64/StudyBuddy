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
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            timerCheckBox.Checked = Properties.Settings.Default.timerEnabled;
            timerVisibilityCheckBox.Checked = Properties.Settings.Default.timerVisibilityEnabled;

            checkTimerCheckBox();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.timerEnabled = timerCheckBox.Checked;
            Properties.Settings.Default.timerVisibilityEnabled = timerVisibilityCheckBox.Checked;
            Properties.Settings.Default.Save();
            Dispose();
        }

        private void checkTimerCheckBox()
        {
            if (timerCheckBox.Checked)
                timerVisibilityCheckBox.Visible = true;
            else
            {
                timerVisibilityCheckBox.Visible = false;
                timerVisibilityCheckBox.Checked = false;
            }
        }

        private void timerCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            checkTimerCheckBox();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Dispose();
            Properties.Settings.Default.editMode = true;
            Properties.Settings.Default.Save();
            CardSelectionForm csf = new CardSelectionForm();
            csf.ShowDialog();
        }

        private void changeQuizDirButton_Click(object sender, EventArgs e)
        {
            ChangeQuizDirForm changeQuizForm = new ChangeQuizDirForm();
            changeQuizForm.ShowDialog();
        }
    }
}
