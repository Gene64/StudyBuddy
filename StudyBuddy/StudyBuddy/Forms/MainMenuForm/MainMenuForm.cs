using StudyBuddy.Forms.OptionsForm;
using System;
using System.Drawing;
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
            checkBackground();
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

        private void checkBackground()
        {
            if (Properties.Settings.Default.nightMode)
            {
                BackColor = Color.Black;
                descriptionLabel.ForeColor = Color.White;
                welcomeLabel.ForeColor = Color.White;
            }  
            else
            {
                BackColor = Color.White;
                descriptionLabel.ForeColor = Color.Black;
                welcomeLabel.ForeColor = Color.Black;
            }  
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            checkBackground();
            checkUser();
            setWelcomeLabel();
            if (!Directory.Exists(Properties.Settings.Default.QuizDirectory))
            {
                DialogResult dr = MessageBox.Show("There is currently no quiz folder configured. Would you like to manually choose?", "Choose Quiz Directory", MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                {
                    FolderBrowserDialog fbd = new FolderBrowserDialog();
                    fbd.Description = "Please select a folder for your saved quizzes to go.";
                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        if (Directory.Exists(fbd.SelectedPath))
                        {
                            Properties.Settings.Default.QuizDirectory = fbd.SelectedPath;
                            MessageBox.Show("Choosing the directory was a success.", "Success");
                        }
                        else
                            MessageBox.Show("Choosing the directory was a failure. Please select a valid directory.", "Failure");
                    }   
                }
                else if (dr == DialogResult.No)
                {
                    string defaultDir = Application.StartupPath + @"\saved quizzes";
                    Directory.CreateDirectory(defaultDir);
                    Properties.Settings.Default.QuizDirectory = defaultDir;  
                }
                Properties.Settings.Default.Save();
            }
            Properties.Settings.Default.backButtonPressed = false;
        }

        private void optionsButton_Click(object sender, EventArgs e)
        {
            OptionsForm options = new OptionsForm();
            options.ShowDialog();
        }

        private void checkUser()
        {
            if (Properties.Settings.Default.currentUser == "")
            {
                UniversalExtraOptions extraOptions = new UniversalExtraOptions();
                extraOptions.ShowDialog();
            }
        }

        private void MainMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Properties.Settings.Default.rememberUser)
            {
                Properties.Settings.Default.currentUser = ""; // Log the user off when the application shuts down.
                Properties.Settings.Default.Save();
            }
        }

        private void setWelcomeLabel()
        {
            welcomeLabel.Text = "Welcome to Study Buddy, " + Properties.Settings.Default.currentUser + "!";
            welcomeLabel.MaximumSize = new Size(280, 0);
            welcomeLabel.Left = (ClientSize.Width - welcomeLabel.Size.Width) / 2;
        }
    }
}
