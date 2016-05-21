using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace StudyBuddy
{
    public partial class NewQuestionsForm : Form
    {
        public NewQuestionsForm()
        {
            InitializeComponent();
        }

        XmlDocument xmlDoc = new XmlDocument();
        int currentIndex = 1;
        string currentMode;
        string currentQuizFile = Properties.Settings.Default.QuizDirectory + @"\" + Properties.Settings.Default.currentSelectedQuiz + ".xml";

        private void backButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.backButtonPressed = true;
            Properties.Settings.Default.Save();
            Dispose();
            NewCardsForm ncf = new NewCardsForm();
            ncf.ShowDialog();
        }

        private void checkBackground()
        {
            if (Properties.Settings.Default.nightMode)
            {
                BackColor = Color.Black;
                newQuestionsDescriptionLabel.BackColor = Color.Black;
                newQuestionsDescriptionLabel.ForeColor = Color.White;
                currentQuestionLabel.BackColor = Color.Black;
                currentQuestionLabel.ForeColor = Color.White;
                questionHeaderLabel.BackColor = Color.Black;
                questionHeaderLabel.ForeColor = Color.White;
                answerHeaderLabel.BackColor = Color.Black;
                answerHeaderLabel.ForeColor = Color.White;
                hintHeaderLabel.BackColor = Color.Black;
                hintHeaderLabel.ForeColor = Color.White;
                questionTextBox.BackColor = Color.Black;
                questionTextBox.ForeColor = Color.White;
                answerTextBox.BackColor = Color.Black;
                answerTextBox.ForeColor = Color.White;
                hintTextBox.BackColor = Color.Black;
                hintTextBox.ForeColor = Color.White;
            }
            else
            {
                BackColor = Color.White;
                newQuestionsDescriptionLabel.BackColor = Color.White;
                newQuestionsDescriptionLabel.ForeColor = Color.Black;
                currentQuestionLabel.BackColor = Color.White;
                currentQuestionLabel.ForeColor = Color.Black;
                questionHeaderLabel.BackColor = Color.White;
                questionHeaderLabel.ForeColor = Color.Black;
                answerHeaderLabel.BackColor = Color.White;
                answerHeaderLabel.ForeColor = Color.Black;
                hintHeaderLabel.BackColor = Color.White;
                hintHeaderLabel.ForeColor = Color.Black;
                questionTextBox.BackColor = Color.White;
                questionTextBox.ForeColor = Color.Black;
                answerTextBox.BackColor = Color.White;
                answerTextBox.ForeColor = Color.Black;
                hintTextBox.BackColor = Color.White;
                hintTextBox.ForeColor = Color.Black;
            }
        }

        private void NewQuestionsForm_Load(object sender, EventArgs e)
        {
            checkBackground();
            xmlDoc.Load(currentQuizFile); // Loads the XML
            if (Properties.Settings.Default.editMode)
                currentMode = "Editing ";
            else
                currentMode = "Creating ";
            Text = currentMode + xmlDoc.SelectSingleNode("StudyBuddy/TestInfo/TestName").InnerText; // Sets page title to test title

            currentQuestionLabel.Text = "1/" + xmlDoc.SelectSingleNode("StudyBuddy/TestInfo/NumberOfTestQuestions").InnerText;

            updateCurrentQuestion();
        }

        private void nextQuestionButton_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
                previousQuestionButton.Visible = true;
            xmlDoc.Load(currentQuizFile); // Loads the XML
            if (quizHasHints())
                xmlDoc.SelectSingleNode("StudyBuddy/HintInfo/Hint" + currentIndex).InnerText = hintTextBox.Text;
            xmlDoc.SelectSingleNode("StudyBuddy/QuestionInfo/Question" + currentIndex).InnerText = questionTextBox.Text;
            xmlDoc.SelectSingleNode("StudyBuddy/AnswerInfo/Answer" + currentIndex).InnerText = answerTextBox.Text;
            xmlDoc.Save(currentQuizFile); // Saves changes to the XML

            if (nextQuestionButton.Text == "Finish")
                Dispose();
            else
                currentIndex++;

            updateCurrentQuestion();
        }

        private void addQuestionInfoXml()
        {
            xmlDoc.Load(currentQuizFile); // Loads the XML
            xmlDoc.SelectSingleNode("StudyBuddy/QuestionInfo/Question" + currentIndex).InnerText = questionTextBox.Text;
            xmlDoc.SelectSingleNode("StudyBuddy/AnswerInfo/Answer" + currentIndex).InnerText = answerTextBox.Text;
            xmlDoc.Save(currentQuizFile); // Saves changes to the XML
            Dispose();
        }

        private void NewQuestionsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.currentSelectedQuiz = null;
            Properties.Settings.Default.Save();
        }

        private void previousQuestionButton_Click(object sender, EventArgs e)
        {
            int currentMaxQuestions = int.Parse(xmlDoc.SelectSingleNode("StudyBuddy/TestInfo/NumberOfTestQuestions").InnerText);
            if (currentIndex == currentMaxQuestions)
            {
                // TODO: Fix this so it saves. (For some reason it stoppped working when I implemented the hint option.
                xmlDoc.Load(currentQuizFile); // Loads the XML
                if (quizHasHints())
                    xmlDoc.SelectSingleNode("StudyBuddy/HintInfo/Hint" + currentIndex).InnerText = hintTextBox.Text;
                xmlDoc.SelectSingleNode("StudyBuddy/QuestionInfo/Question" + currentIndex).InnerText = questionTextBox.Text;
                xmlDoc.SelectSingleNode("StudyBuddy/AnswerInfo/Answer" + currentIndex).InnerText = answerTextBox.Text;
                xmlDoc.Save(currentQuizFile); // Saves changes to the XML
            }
            currentIndex--;
            if (currentIndex== 1)
                previousQuestionButton.Visible = false;

            if (nextQuestionButton.Text == "Finish")
                nextQuestionButton.Text = "Next Question";
            updateCurrentQuestion();
        }

        private void updateCurrentQuestion()
        {
            xmlDoc.Load(currentQuizFile); // Loads the XML
            string totalQuestions = xmlDoc.SelectSingleNode("StudyBuddy/TestInfo/NumberOfTestQuestions").InnerText;
            currentQuestionLabel.Text = "Current Question: " + currentIndex+ "/" + totalQuestions;
            questionHeaderLabel.Text = "Question #" + currentIndex;
            answerHeaderLabel.Text = "Answer #" + currentIndex;
            if (quizHasHints())
            {
                hintHeaderLabel.Text = "Hint #" + currentIndex;
                hintHeaderLabel.Visible = true;
                hintTextBox.Visible = true;
                hintTextBox.Text = xmlDoc.SelectSingleNode("StudyBuddy/HintInfo/Hint" + currentIndex).InnerText;
            }
            questionTextBox.Text = xmlDoc.SelectSingleNode("StudyBuddy/QuestionInfo/Question" + currentIndex).InnerText;
            answerTextBox.Text = xmlDoc.SelectSingleNode("StudyBuddy/AnswerInfo/Answer" + currentIndex).InnerText;


            int totalQuestionsInt = int.Parse(xmlDoc.SelectSingleNode("StudyBuddy/TestInfo/NumberOfTestQuestions").InnerText);
            if (currentIndex == totalQuestionsInt)
                nextQuestionButton.Text = "Finish";
        }

        private bool quizHasHints()
        {
            xmlDoc.Load(currentQuizFile); // Loads the XML
            if (xmlDoc.SelectSingleNode("StudyBuddy/HintInfo") == null)
                return false;
            return true;
        }
    }
}
