using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace StudyBuddy
{
    public partial class CardSelectionForm : Form
    {
        public CardSelectionForm()
        {
            InitializeComponent();
        }

        string userType;
        XmlDocument xmlDoc = new XmlDocument();

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
            else if (Properties.Settings.Default.highScoreViewer)
            {
                Text = "High Score Viewer";
                startStudyingButton.Text = "View High Score";
                directionsLabel.Text = "Pick one of your quizzes from the box\nbelow to view the current high score!";
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
                else if (Properties.Settings.Default.highScoreViewer)
                {
                    if (quizSelectionComboBox.Text != "")
                    {
                        string currentQuiz = Properties.Settings.Default.QuizDirectory + @"\" + quizSelectionComboBox.Text + ".xml";
                        xmlDoc.LoadXml(currentQuiz);
                        if (xmlDoc.SelectSingleNode("StudyBuddy/TopScoreInfo/BestUser").InnerText == "")
                            MessageBox.Show("There is current no high score for this study quiz.");
                        else
                        {
                            string highUser = xmlDoc.SelectSingleNode("StudyBuddy/TopScoreInfo/BestUser").InnerText;
                            string highScore = xmlDoc.SelectSingleNode("StudyBuddy/TopScoreInfo/BestScore").InnerText;
                            string highTime = xmlDoc.SelectSingleNode("StudyBuddy/TopScoreInfo/BestTime").InnerText;
                            MessageBox.Show("Top User: " + highUser + "\nHigh Score: " + highScore + "\nTime: " + highTime);
                        }
                    }
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
