using System;
using System.Drawing;
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
        int skipsLeft = Properties.Settings.Default.skipsLeft; // Total skips that are available for the user to use
        int totalQuestions;
        int totalSkips; // Total skips that were used
        int currentIndex = 1;
        int wrongAnswers;
        int rightAnswers;
        int currentQuestionTimes; // Counts wrong answer for the current question
        double totalSeconds;
        double totalMinutes;
        bool confirmed = false; // Confirm of closing while studying

        string currentQuizFile = Properties.Settings.Default.QuizDirectory + @"\" +Properties.Settings.Default.currentSelectedQuiz + ".xml";

        private bool quizHasHints()
        {
            xmlDoc.Load(currentQuizFile); // Loads the XML
            if (xmlDoc.SelectSingleNode("StudyBuddy/HintInfo") == null)
                return false;
            return true;
        }

        private void checkBackground()
        {
            if (Properties.Settings.Default.nightMode)
            {
                BackColor = Color.Black;
                currentQuestionLabel.ForeColor = Color.White;
                timerLabel.ForeColor = Color.White;
                questionLabel.ForeColor = Color.White;
                hintLabel.ForeColor = Color.White;
                answerTextBox.BackColor = Color.Black;
                answerTextBox.ForeColor = Color.White;
                skipsLeftLabel.ForeColor = Color.White;
            }
            else
            {
                BackColor = Color.White;
                currentQuestionLabel.ForeColor = Color.Black;
                timerLabel.ForeColor = Color.White;
                questionLabel.ForeColor = Color.Black;
                hintLabel.ForeColor = Color.Black;
                answerTextBox.BackColor = Color.White;
                answerTextBox.ForeColor = Color.Black;
                skipsLeftLabel.ForeColor = Color.Black;
            }
        }

        private void StudyForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.skipsLeft == 0)
            {
                Properties.Settings.Default.skipsLeft = 3;
                Properties.Settings.Default.Save();
            }
            checkBackground();
            xmlDoc.Load(currentQuizFile); // Loads the XML
            totalQuestions = int.Parse(xmlDoc.SelectSingleNode("StudyBuddy/TestInfo/NumberOfTestQuestions").InnerText); // Gets the number of questions.
            questionLabel.Text = xmlDoc.SelectSingleNode("StudyBuddy/QuestionInfo/Question1").InnerText; // Sets the question to the first question.
            centerQuestionLabel();

            if (totalQuestions == 1)
                nextQuestionButton.Text = "Finish";

            if (Properties.Settings.Default.timerEnabled)
            {
                questionTimer.Enabled = true;

                if (Properties.Settings.Default.timerVisibilityEnabled)
                    timerLabel.Visible = true;
            }
            else
                timerLabel.Visible = false;

            if (Properties.Settings.Default.skipEnabled)
            {
                skipButton.Visible = true;
                skipsLeftLabel.Visible = true;
                skipsLeftLabel.Text = "(" + skipsLeft + ")";
            }
        }

        private void nextQuestionButton_Click(object sender, EventArgs e)
        {
            if (xmlDoc.SelectSingleNode("StudyBuddy/AnswerInfo/Answer" + currentIndex).InnerText != answerTextBox.Text)
            {
                currentQuestionTimes++;
                if (currentQuestionTimes < 1)
                    wrongAnswers++;

                if (quizHasHints() && Properties.Settings.Default.enableHintsCheckBox)
                {
                    if (currentQuestionTimes >= Properties.Settings.Default.hintTries)
                    {
                        hintLabel.Visible = true;
                        hintLabel.Text = "Hint: " + xmlDoc.SelectSingleNode("StudyBuddy/HintInfo/Hint" + currentIndex).InnerText;
                    }
                }
            }
            else
            {
                rightAnswers++;
                if (quizHasHints() && Properties.Settings.Default.enableHintsCheckBox)
                    currentQuestionTimes = 0;
                nextQuestion();
            }
        }

        private void nextQuestion()
        {
            if (totalQuestions > currentIndex)
            {
                currentIndex++;
                currentQuestionLabel.Text = "Question " + currentIndex;
                questionLabel.Text = xmlDoc.SelectSingleNode("StudyBuddy/QuestionInfo/Question" + currentIndex).InnerText; // Sets the question to the next question.
                answerTextBox.Text = "";
                centerQuestionLabel();
            }
            else
            {
                int percentScore = (rightAnswers / totalQuestions) * 100;
                string timeResults = null;

                // Set the format of the time results
                questionTimer.Stop();
                if (totalMinutes == 0 && totalSeconds > 0)
                    timeResults = " It took you " + totalSeconds + " seconds to complete this study quiz.";
                else if (totalMinutes > 0 && totalSeconds == 0)
                    timeResults = " It took you " + totalMinutes + " minutes to complete this study quiz.";
                else if (totalMinutes > 0 && totalSeconds > 0)
                    timeResults = " It took you " + totalMinutes + " minutes and " + totalSeconds + " seconds to complete this study quiz.";

                MessageBox.Show("Congratulations, you have finished this study session! You got " + rightAnswers + " correct, " + wrongAnswers + " wrong, and skipped " + totalSkips + ". Your final score is a " + percentScore + "%." + timeResults, "Study Quiz Finished");
                if (xmlDoc.SelectSingleNode("StudyBuddy/TopScoreInfo") != null)
                {
                    if (xmlDoc.SelectSingleNode("StudyBuddy/TopScoreInfo/BestUser").InnerText == "") // Checks if someone has played or not before.
                        writeBestUser(percentScore);
                    else
                    {
                        int currentBestScore = int.Parse(xmlDoc.SelectSingleNode("StudyBuddy/TopScoreInfo/BestScore").InnerText);
                        int currentBestTime = int.Parse(xmlDoc.SelectSingleNode("StudyBuddy/TopScoreInfo/BestTime").InnerText);
                        double totalSecondsTaken = (totalMinutes * 60) + totalSeconds;
                        if (currentBestScore < percentScore) // Checks if score is better than current best score
                            writeBestUser(percentScore);
                        else if (currentBestScore == percentScore && currentBestTime > totalSecondsTaken)
                            writeBestUser(percentScore);// Checks if score is the same, then compare time
                    }
                    xmlDoc.Save(currentQuizFile);
                }
                Dispose();
            }

            if (totalQuestions == 1)
                nextQuestionButton.Text = "Finish";
        }

        private void writeBestUser(int percentScore)
        {
            xmlDoc.SelectSingleNode("StudyBuddy/TopScoreInfo/BestUser").InnerText = Properties.Settings.Default.currentUser;
            xmlDoc.SelectSingleNode("StudyBuddy/TopScoreInfo/BestScore").InnerText = percentScore.ToString();
            xmlDoc.SelectSingleNode("StudyBuddy/TopScoreInfo/BestTime").InnerText = ((totalMinutes * 60) + totalSeconds).ToString();
            xmlDoc.Save(currentQuizFile);
        }

        private void centerQuestionLabel()
        {
            questionLabel.Left = (ClientSize.Width - questionLabel.Size.Width) / 2;
        }

        private void questionTimer_Tick(object sender, EventArgs e)
        {
            if (totalSeconds < 60)
                totalSeconds++;
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

        private void skipButton_Click(object sender, EventArgs e)
        {
            totalSkips++;
            if (skipsLeft > 0)
            {
                skipsLeft = skipsLeft - 1;
                skipsLeftLabel.Text = "(" + skipsLeft + ")";
                nextQuestion();
            }
            else
                MessageBox.Show("Sorry, you have no skips left to use.", "No Skips Left");
        }

        private void StudyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (totalQuestions > (rightAnswers + wrongAnswers + totalSkips) && confirmed == false)
            {
                questionTimer.Stop();
                e.Cancel = true;
                DialogResult dr = MessageBox.Show("Are you sure you want to exit the study session while you are still working?", "Exit Study Session", MessageBoxButtons.YesNo);

                if (dr == DialogResult.No)
                    questionTimer.Start();
                else if (dr == DialogResult.Yes)
                {
                    confirmed = true;
                    Dispose();
                }
                    
            }
        }
    }
}
