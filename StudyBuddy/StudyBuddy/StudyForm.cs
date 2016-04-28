using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        int currentIndex = 1;

        private void StudyForm_Load(object sender, EventArgs e)
        {
            xmlDoc.Load(Application.StartupPath + @"\saved cards\" + Properties.Settings.Default.currentSelectedQuiz + ".xml"); // Loads the XML
            int totalQuestions = int.Parse(xmlDoc.SelectSingleNode(Properties.Settings.Default.currentSelectedQuiz + "/TestInfo/NumberOfTestQuestions").InnerText); // Gets the number of questions.
            questionLabel.Text = xmlDoc.SelectSingleNode(Properties.Settings.Default.currentSelectedQuiz + "/QuestionInfo/Question1").InnerText; // Sets the question to the first question.
            MessageBox.Show(questionLabel.Text);
        }

        private void nextQuestionButton_Click(object sender, EventArgs e)
        {

        }
    }
}
