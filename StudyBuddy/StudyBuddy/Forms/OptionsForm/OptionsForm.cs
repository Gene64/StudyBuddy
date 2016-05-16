using System;
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
            enableHintCheckBox.Checked = Properties.Settings.Default.enableHintsCheckBox;
            checkInvisibleItems();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.timerEnabled = timerCheckBox.Checked;
            Properties.Settings.Default.timerVisibilityEnabled = timerVisibilityCheckBox.Checked;
            Properties.Settings.Default.enableHintsCheckBox = enableHintCheckBox.Checked;
            Properties.Settings.Default.Save();
            Dispose();
        }

        private void checkInvisibleItems()
        {
            if (timerCheckBox.Checked)
                timerVisibilityCheckBox.Visible = true;
            else
            {
                timerVisibilityCheckBox.Visible = false;
                timerVisibilityCheckBox.Checked = false;
            }

            if (enableHintCheckBox.Checked)
                hintOptionsButton.Visible = true;
            else
                hintOptionsButton.Visible = false;
        }

        private void timerCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            checkInvisibleItems();
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

        private void enableHintCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkInvisibleItems();
        }
    }
}
