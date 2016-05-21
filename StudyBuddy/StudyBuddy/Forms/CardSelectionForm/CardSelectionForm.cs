using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace StudyBuddy
{
    public partial class CardSelectionForm : Form
    {
        public CardSelectionForm()
        {
            InitializeComponent();
        }

        string userType;

        private void checkBackground()
        {
            if (Properties.Settings.Default.nightMode)
            {
                BackColor = Color.Black;
                directionsLabel.ForeColor = Color.White;
            }
            else
            {
                BackColor = Color.White;
                directionsLabel.ForeColor = Color.Black;
            }
        }

        private void CardSelectionForm_Load(object sender, EventArgs e)
        {
            checkBackground();
            if (Properties.Settings.Default.editMode)
            {
                Text = "Study Quiz Editor";
                startStudyingButton.Text = "Begin Editing";
                userType = "edit";
            }
            else
            {
                Text = "Study Quiz Selection";
                startStudyingButton.Text = "Start Studying";
                userType = "study";
            }
            directionsLabel.Text = "Pick one of your quizzes from the box\nbelow to begin " + userType + "ing!";

            string[] availableQuizDir = Directory.GetFiles(Properties.Settings.Default.QuizDirectory);
            
            foreach (string availableQuizzes in availableQuizDir)
                quizSelectionComboBox.Items.Add(Path.GetFileNameWithoutExtension(availableQuizzes));
        }

        private void topic1Button_Click(object sender, EventArgs e)
        {
            if (quizSelectionComboBox.Text != "")
            {
                Properties.Settings.Default.currentSelectedQuiz = quizSelectionComboBox.Text;
                Properties.Settings.Default.Save();
                Dispose();
                if (userType == "study")
                {
                    StudyForm sf = new StudyForm();
                    sf.ShowDialog();
                }
                else if (userType == "edit")
                {
                    NewCardsForm ncf = new NewCardsForm();
                    ncf.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Something has gone wrong. The program will now close now.", "Something has gone wrong");
                    Application.Exit();
                }
            }
            else
                MessageBox.Show("Please select a quiz to " + userType + ".", "No Quiz Selected");
        }
    }
}
