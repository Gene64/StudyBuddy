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

        private void practiceButton_MouseMove(object sender, MouseEventArgs e)
        {
            descriptionLabel.Visible = true;
            descriptionLabel.Text = "Practice your saved flash cards to master\nthe topic.";
            centerDescriptionLabel();
        }

        private void optionsButton_MouseMove(object sender, MouseEventArgs e)
        {
            descriptionLabel.Visible = true;
            descriptionLabel.Text = "Change Study Buddy's options to fit your\nlearning style.";
            centerDescriptionLabel();
        }

        // The description label turns invisible when the user isn't hovering over any of the buttons.
        private void createButton_MouseLeave(object sender, EventArgs e)
        {
            descriptionLabel.Visible = false;
        }

        private void practiceButton_MouseLeave(object sender, EventArgs e)
        {
            descriptionLabel.Visible = false;
        }

        private void optionsButton_MouseLeave(object sender, EventArgs e)
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
            if (!Directory.Exists(Properties.Settings.Default.QuizDirectory))
            {
                DialogResult dr = MessageBox.Show("There is currently no quiz folder configured. Would you like to manually choose?", "Choose Quiz Directory", MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                {
                    string dirStatus;
                    FolderBrowserDialog fbd = new FolderBrowserDialog();
                    fbd.Description = "Please select a folder for your saved quizes to go.";
                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        if (Directory.Exists(fbd.SelectedPath))
                        {
                            Properties.Settings.Default.QuizDirectory = fbd.SelectedPath;
                            dirStatus = "success";
                        }
                        else
                            dirStatus = "failure";
                        MessageBox.Show("Choosing the directory was a " + dirStatus);
                    }   
                }
                else if (dr == DialogResult.No)
                {
                    string defaultDir = Application.StartupPath + @"\saved quizes";
                    Directory.CreateDirectory(defaultDir);
                    Properties.Settings.Default.QuizDirectory = defaultDir;
                }
            }
            Properties.Settings.Default.backButtonPressed = false;
            Properties.Settings.Default.Save();
        }

        private void optionsButton_Click(object sender, EventArgs e)
        {
            OptionsForm options = new OptionsForm();
            options.ShowDialog();
        }
    }
}
