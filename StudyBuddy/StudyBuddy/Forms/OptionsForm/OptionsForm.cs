using StudyBuddy.Forms.OptionsForm;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudyBuddy
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
        }

        private void checkBackground()
        {
            if (nightModeCheckBox.Checked)
            {
                BackColor = Color.Black;
                timerCheckBox.BackColor = Color.Black;
                timerCheckBox.ForeColor = Color.White;
                timerVisibilityCheckBox.BackColor = Color.Black;
                timerVisibilityCheckBox.ForeColor = Color.White;
                enableHintCheckBox.BackColor = Color.Black;
                enableHintCheckBox.ForeColor = Color.White;
                skipEnabledCheckBox.BackColor = Color.Black;
                skipEnabledCheckBox.ForeColor = Color.White;
                nightModeCheckBox.BackColor = Color.Black;
                nightModeCheckBox.ForeColor = Color.White;
            }
            else
            {
                BackColor = Color.White;
                timerCheckBox.BackColor = Color.White;
                timerCheckBox.ForeColor = Color.Black;
                timerVisibilityCheckBox.BackColor = Color.White;
                timerVisibilityCheckBox.ForeColor = Color.Black;
                enableHintCheckBox.BackColor = Color.White;
                enableHintCheckBox.ForeColor = Color.Black;
                skipEnabledCheckBox.BackColor = Color.White;
                skipEnabledCheckBox.ForeColor = Color.Black;
                nightModeCheckBox.BackColor = Color.White;
                nightModeCheckBox.ForeColor = Color.Black;
            }
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            checkBackground();
            skipEnabledCheckBox.Checked = Properties.Settings.Default.skipEnabled;
            timerCheckBox.Checked = Properties.Settings.Default.timerEnabled;
            timerVisibilityCheckBox.Checked = Properties.Settings.Default.timerVisibilityEnabled;
            enableHintCheckBox.Checked = Properties.Settings.Default.enableHintsCheckBox;
            nightModeCheckBox.Checked = Properties.Settings.Default.nightMode;
            checkInvisibleItems();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.timerEnabled = timerCheckBox.Checked;
            Properties.Settings.Default.timerVisibilityEnabled = timerVisibilityCheckBox.Checked;
            Properties.Settings.Default.enableHintsCheckBox = enableHintCheckBox.Checked;
            Properties.Settings.Default.nightMode = nightModeCheckBox.Checked;
            Properties.Settings.Default.skipEnabled = skipEnabledCheckBox.Checked;
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

            if (skipEnabledCheckBox.Checked)
            {
                skipOptionsButton.Visible = true;
            }
            else
                skipOptionsButton.Visible = false;
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

        private void skipEnabledCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkInvisibleItems();
        }

        private void hintOptionsButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.currentSelectedOption = 1;
            Properties.Settings.Default.Save();
            UniversalExtraOptions extraOptions = new UniversalExtraOptions();
            extraOptions.ShowDialog();
        }

        private void nightModeCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            checkBackground();
        }

        private void changeCurrentUserButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.changeCurrentUser = true;
            Properties.Settings.Default.Save();
            UniversalExtraOptions extraOptions = new UniversalExtraOptions();
            extraOptions.ShowDialog();
        }

        private void skipOptionsButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.currentSelectedOption = 2;
            Properties.Settings.Default.Save();
            UniversalExtraOptions extraOptions = new UniversalExtraOptions();
            extraOptions.ShowDialog();
        }
    }
}
