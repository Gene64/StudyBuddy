using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            xmlDoc.Load(Application.StartupPath + @"\saved cards\" + Properties.Settings.Default.currentSelectedQuiz + ".xml"); // Loads the XML
            xmlDoc.SelectSingleNode(Properties.Settings.Default.currentSelectedQuiz + "/QuestionInfo/Question1").InnerText = question1TextBox.Text;
            xmlDoc.SelectSingleNode(Properties.Settings.Default.currentSelectedQuiz + "/QuestionInfo/Answer1").InnerText = answer1TextBox.Text;
            xmlDoc.Save(Application.StartupPath + @"\saved cards\" + Properties.Settings.Default.currentSelectedQuiz + ".xml"); // Saves changes to the XML
            Dispose();
        }

        private void addQuestionInfoXml()
        {
            xmlDoc.Load(Application.StartupPath + @"\saved cards\" + Properties.Settings.Default.currentSelectedQuiz + ".xml"); // Loads the XML
            xmlDoc.SelectSingleNode(Properties.Settings.Default.currentSelectedQuiz + "/QuestionInfo/Question1").InnerText = question1TextBox.Text;
            xmlDoc.SelectSingleNode(Properties.Settings.Default.currentSelectedQuiz + "/QuestionInfo/Answer1").InnerText = answer1TextBox.Text;
            xmlDoc.Save(Application.StartupPath + @"\saved cards\" + Properties.Settings.Default.currentSelectedQuiz + ".xml"); // Saves changes to the XML
            Dispose();
        }

        private void NewQuestionsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.currentSelectedQuiz = "";
            Properties.Settings.Default.Save();
        }
    }
}
