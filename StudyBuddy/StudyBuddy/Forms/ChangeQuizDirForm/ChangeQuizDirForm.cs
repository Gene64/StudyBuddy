using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace StudyBuddy
{
    public partial class ChangeQuizDirForm : Form
    {
        public ChangeQuizDirForm()
        {
            InitializeComponent();
        }

        private void checkBackground()
        {
            if (Properties.Settings.Default.nightMode)
            {
                BackColor = Color.Black;
                directoryTextBox.BackColor = Color.Black;
                directoryTextBox.ForeColor = Color.White;
            }
            else
            {
                BackColor = Color.White;
                directoryTextBox.BackColor = Color.White;
                directoryTextBox.ForeColor = Color.Black;
            }
        }

        private void ChangeQuizDirForm_Load(object sender, EventArgs e)
        {
            checkBackground();
            directoryTextBox.Text = Properties.Settings.Default.QuizDirectory;
        }

        private void changeDirButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Please select a new folder to save your quizzes in.";

            if (fbd.ShowDialog() == DialogResult.OK && Directory.Exists(fbd.SelectedPath))
            {
                directoryTextBox.Text = fbd.SelectedPath;
            }
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.QuizDirectory = directoryTextBox.Text;
            Properties.Settings.Default.Save();
            Dispose();
        }
    }
}
