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
    public partial class NewCardsForm : Form
    {
        public NewCardsForm()
        {
            InitializeComponent();
        }

        private void NewCardsForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.backButtonPressed)
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(Application.StartupPath + @"\saved cards\" + Properties.Settings.Default.currentSelectedQuiz + ".xml"); // Loads the XML
                quizNameTextBox.Text = xmlDoc.SelectSingleNode(Properties.Settings.Default.currentSelectedQuiz + "/TestInfo/" + Properties.Settings.Default.currentSelectedQuiz).InnerText;
                questionNumbersComboBox.Text = xmlDoc.SelectSingleNode(Properties.Settings.Default.currentSelectedQuiz + "/TestInfo/NumberOfTestQuestions").InnerText;
            }
            else
            {
                questionNumbersComboBox.SelectedIndex = 0;
            }
        }

        private void cardGroupNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (quizNameTextBox.Text == "")
            {
                nextButton.Enabled = false;
            }
            else
            {
                nextButton.Enabled = true;
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.currentSelectedQuiz = quizNameTextBox.Text;
            Properties.Settings.Default.Save();

            if (!File.Exists(Application.StartupPath + @"\saved cards\" + quizNameTextBox.Text + ".xml"))
            {
                XmlTextWriter xWriter = new XmlTextWriter(Application.StartupPath + @"\saved cards\" + quizNameTextBox.Text + ".xml", Encoding.UTF8);
                xWriter.Formatting = Formatting.Indented;
                xWriter.WriteStartElement(quizNameTextBox.Text); // <quizNameTextBox.Test>
                xWriter.WriteStartElement("TestInfo"); // <TestInfo>
                xWriter.WriteStartElement("TestName"); // <TestName>
                xWriter.WriteString(quizNameTextBox.Text); // quizNameNameTextBox.Text
                xWriter.WriteEndElement(); // </TestName>
                xWriter.WriteStartElement("NumberOfTestQuestions"); // <NumberOfTestQuestions>
                xWriter.WriteString(questionNumbersComboBox.Text); // questionNumbersComboBox.Text
                xWriter.WriteEndElement(); // </NumberOfTestQuestions>
                xWriter.WriteEndElement(); // </TestInfo>
                xWriter.WriteStartElement("QuestionInfo"); // <QuestionInfo>
                xWriter.WriteStartElement("Question1"); // <Question1>
                xWriter.WriteEndElement(); // </QuestionInfo>
                xWriter.WriteStartElement("Answer1");
                xWriter.WriteEndElement(); // </Answer1>
                xWriter.WriteEndElement(); // </quizNameTextBox.Text>
                xWriter.Close();
            }

            Dispose();
            NewQuestionsForm nqf = new NewQuestionsForm();
            nqf.ShowDialog();
        }

        private void NewCardsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.backButtonPressed = false;
            Properties.Settings.Default.Save();
        }
    }
}
