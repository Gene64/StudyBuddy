using System;
using System.IO;
using System.Windows.Forms;

namespace StudyBuddy
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }


        // Mouse hover effects (I used the MoveMouse event shandler instead of MouseHover because it responds quicker.)
        private void createButton_MouseMove(object sender, MouseEventArgs e)
        {
            descriptionLabel.Visible = true;
            descriptionLabel.Text = "Create study cards about a topic that you\nneed to review.";
            centerDescriptionLabel();
        }

        private void editButton_MouseMove(object sender, MouseEventArgs e)
        {
            descriptionLabel.Visible = true;
            descriptionLabel.Text = "Load previously saved study cards to\ncontinue studying.";
            centerDescriptionLabel();
        }

        private void practiceButton_MouseMove(object sender, MouseEventArgs e)
        {
            descriptionLabel.Visible = true;
            descriptionLabel.Text = "Practice your saved flash cards to master\nthe topic.";
            centerDescriptionLabel();
        }

        // The description label turns invisible when the user isn't hovering over any of the buttons.
        private void createButton_MouseLeave(object sender, EventArgs e)
        {
            descriptionLabel.Visible = false;
        }

        private void editButton_MouseLeave(object sender, EventArgs e)
        {
            descriptionLabel.Visible = false;
        }

        private void practiceButton_MouseLeave(object sender, EventArgs e)
        {
            descriptionLabel.Visible = false;
        }

        /*
        This gets the descriptionLabel width and subtracts it from the applications width, then divides by two.
        It sets the left side of the label to that amount, which will be equivalent to the right side.
        */
        private void centerDescriptionLabel()
        {
            descriptionLabel.Left = (ClientSize.Width - descriptionLabel.Size.Width) / 2;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.editMode = false;
            Properties.Settings.Default.Save();
            NewCardsForm ncf = new NewCardsForm();
            ncf.ShowDialog();
        }

        private void practiceButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.editMode = false;
            Properties.Settings.Default.Save();
            CardSelectionForm csf = new CardSelectionForm();
            csf.ShowDialog();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(Application.StartupPath + @"\saved cards"))
            {
                Directory.CreateDirectory(Application.StartupPath + @"\saved cards");
            }
            Properties.Settings.Default.backButtonPressed = false;
            Properties.Settings.Default.Save();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.editMode = true;
            Properties.Settings.Default.Save();
            CardSelectionForm csf = new CardSelectionForm();
            csf.ShowDialog();
        }
    }
}
