using System;
using System.Windows.Forms;
using System.Xml;

namespace StudyBuddy
{
    public partial class StudyForm : Form
    {
        public StudyForm()
        {
            InitializeComponent();
        }

        XmlDocument xmlDoc = new XmlDocument();
        int totalQuestions;
        int currentIndex = 1;
        int wrongAnswers;
        int rightAnswers;
        double totalSeconds;
        double totalMinutes;

        string currentQuizFile = Application.StartupPath + @"\saved cards\" + Properties.Settings.Default.currentSelectedQuiz + ".xml";

        private void StudyForm_Load(object sender, EventArgs e)
        {
            xmlDoc.Load(currentQuizFile); // Loads the XML
            totalQuestions = int.Parse(xmlDoc.SelectSingleNode("StudyBuddy/TestInfo/NumberOfTestQuestions").InnerText); // Gets the number of questions.
            questionLabel.Text = xmlDoc.SelectSingleNode("StudyBuddy/QuestionInfo/Question1").InnerText; // Sets the question to the first question.
            centerQuestionLabel();

            if (Properties.Settings.Default.timerEnabled)
            {
                questionTimer.Enabled = true;

                if (Properties.Settings.Default.timerVisibilityEnabled)
                    timerLabel.Visible = true;
            }
            else
                timerLabel.Visible = false;
        }

        private void nextQuestionButton_Click(object sender, EventArgs e)
        {
            if (xmlDoc.SelectSingleNode("StudyBuddy/AnswerInfo/Answer" + currentIndex).InnerText != answerTextBox.Text)
            {
                wrongAnswers++;
            }
            else
            {
                rightAnswers++;
                nextQuestion();
            }
        }

        private void nextQuestion()
        {
            if (totalQuestions > currentIndex)
            {
                currentIndex++;
                questionLabel.Text = xmlDoc.SelectSingleNode("StudyBuddy/QuestionInfo/Question" + currentIndex).InnerText; // Sets the question to the next question.
                answerTextBox.Text = "";
                centerQuestionLabel();
            }
            else
            {
                int percentScore = (rightAnswers / totalQuestions) * 100;
                string timeResults = null;

                // Set the format of the time results
                if (totalMinutes == 0 && totalSeconds > 0)
                    timeResults = " It took you " + totalSeconds + " seconds to complete this study quiz.";
                else if (totalMinutes > 0 && totalSeconds == 0)
                    timeResults = " It took you " + totalMinutes + " minutes to complete this study quiz.";
                else if (totalMinutes > 0 && totalSeconds > 0)
                    timeResults = " It took you " + totalMinutes + " minutes and " + totalSeconds + " seconds to complete this study quiz.";

                MessageBox.Show("Congratulations, you have finished this study session! You got " + rightAnswers + " correct and " + wrongAnswers + " wrong. Your final score is a " + percentScore + "%." + timeResults, "Study Quiz Finished");
                Dispose();
            }
        }

        private void centerQuestionLabel()
        {
            questionLabel.Left = (ClientSize.Width - questionLabel.Size.Width) / 2;
        }

        private void questionTimer_Tick(object sender, EventArgs e)
        {
            if (totalSeconds < 60)
            {
                totalSeconds++;
            }
            else if (totalSeconds == 60)
            {
                totalMinutes++;
                totalSeconds = 0;
            }
            
            if (Properties.Settings.Default.timerVisibilityEnabled)
            {
                if (totalSeconds <= 9)
                    timerLabel.Text = totalMinutes + ":0" + totalSeconds;
                else
                    timerLabel.Text = totalMinutes + ":" + totalSeconds;
            }
        }
    }
}
