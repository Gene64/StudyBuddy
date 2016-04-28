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
    public partial class CardSelectionForm : Form
    {
        public CardSelectionForm()
        {
            InitializeComponent();
        }

        private void CardSelectionForm_Load(object sender, EventArgs e)
        {
            string[] availableQuizDir = Directory.GetFiles(Application.StartupPath + @"\saved cards");
            
            foreach (string availableQuizes in availableQuizDir)
                quizSelectionComboBox.Items.Add(Path.GetFileNameWithoutExtension(availableQuizes));
        }

        private void topic1Button_Click(object sender, EventArgs e)
        {
            if (quizSelectionComboBox.Text != "")
            {
                Properties.Settings.Default.currentSelectedQuiz = quizSelectionComboBox.Text;
                Properties.Settings.Default.Save();
                Dispose();
                StudyForm sf = new StudyForm();
                sf.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a quiz to study.");
            }
        }
    }
}
