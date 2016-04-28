using System;
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

        private void backButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.backButtonPressed = true;
            Properties.Settings.Default.Save();
            Dispose();
            NewCardsForm ncf = new NewCardsForm();
            ncf.ShowDialog();
        }

        private void NewQuestionsForm_Load(object sender, EventArgs e)
        {
            xmlDoc.Load(Application.StartupPath + @"\saved cards\" + Properties.Settings.Default.currentSelectedQuiz + ".xml"); // Loads the XML
            Text = xmlDoc.SelectSingleNode(Properties.Settings.Default.currentSelectedQuiz + "/TestInfo/TestName").InnerText; // Sets page title to test title

            currentQuestionLabel.Text = "1/" + xmlDoc.SelectSingleNode(Properties.Settings.Default.currentSelectedQuiz + "/TestInfo/NumberOfTestQuestions").InnerText;

            updateCurrentQuestion();
        }

        private void nextQuestionButton_Click(object sender, EventArgs e)
        {
            if (currentIndex >= 1)
                previousQuestionButton.Visible = true;
            xmlDoc.Load(Application.StartupPath + @"\saved cards\" + Properties.Settings.Default.currentSelectedQuiz + ".xml"); // Loads the XML
            xmlDoc.SelectSingleNode(Properties.Settings.Default.currentSelectedQuiz + "/QuestionInfo/Question" + currentIndex).InnerText = questionTextBox.Text;
            xmlDoc.SelectSingleNode(Properties.Settings.Default.currentSelectedQuiz + "/AnswerInfo/Answer" + currentIndex).InnerText = answerTextBox.Text;
            xmlDoc.Save(Application.StartupPath + @"\saved cards\" + Properties.Settings.Default.currentSelectedQuiz + ".xml"); // Saves changes to the XML

            if (nextQuestionButton.Text == "Finish")
                Dispose();
            else
                currentIndex++;

            updateCurrentQuestion();
        }

        private void addQuestionInfoXml()
        {
            xmlDoc.Load(Application.StartupPath + @"\saved cards\" + Properties.Settings.Default.currentSelectedQuiz + ".xml"); // Loads the XML
            xmlDoc.SelectSingleNode(Properties.Settings.Default.currentSelectedQuiz + "/QuestionInfo/Question" + currentIndex).InnerText = questionTextBox.Text;
            xmlDoc.SelectSingleNode(Properties.Settings.Default.currentSelectedQuiz + "/AnswerInfo/Answer" + currentIndex).InnerText = answerTextBox.Text;
            xmlDoc.Save(Application.StartupPath + @"\saved cards\" + Properties.Settings.Default.currentSelectedQuiz + ".xml"); // Saves changes to the XML
            Dispose();
        }

        private void NewQuestionsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.currentSelectedQuiz = null;
            Properties.Settings.Default.Save();
        }

        private void previousQuestionButton_Click(object sender, EventArgs e)
        {
            currentIndex--;
            if (currentIndex== 1)
                previousQuestionButton.Visible = false;

            if (nextQuestionButton.Text == "Finish")
                nextQuestionButton.Text = "Next Question";
            updateCurrentQuestion();
        }

        private void updateCurrentQuestion()
        {
            xmlDoc.Load(Application.StartupPath + @"\saved cards\" + Properties.Settings.Default.currentSelectedQuiz + ".xml"); // Loads the XML
            string totalQuestions = xmlDoc.SelectSingleNode(Properties.Settings.Default.currentSelectedQuiz + "/TestInfo/NumberOfTestQuestions").InnerText;
            currentQuestionLabel.Text = "Current Question: " + currentIndex+ "/" + totalQuestions;
            questionHeaderLabel.Text = "Question #" + currentIndex;
            answerHeaderLabel.Text = "Answer #" + currentIndex;

            questionTextBox.Text = xmlDoc.SelectSingleNode(Properties.Settings.Default.currentSelectedQuiz + "/QuestionInfo/Question" + currentIndex).InnerText;
            answerTextBox.Text = xmlDoc.SelectSingleNode(Properties.Settings.Default.currentSelectedQuiz + "/AnswerInfo/Answer" + currentIndex).InnerText;


            int totalQuestionsInt = int.Parse(xmlDoc.SelectSingleNode(Properties.Settings.Default.currentSelectedQuiz + "/TestInfo/NumberOfTestQuestions").InnerText);
            if (currentIndex == totalQuestionsInt)
                nextQuestionButton.Text = "Finish";
        }
    }
}
