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
            XmlDocument xmlDoc = new XmlDocument();

            DirectoryInfo savedQuizesDir = new DirectoryInfo(Application.StartupPath + @"\saved cards");
            FileInfo[] Files = savedQuizesDir.GetFiles("*.xml");
            string avaiableQuizes = "";

            foreach (FileInfo file in Files)
                avaiableQuizes = file.Name;


            xmlDoc.Load(Application.StartupPath + @"\saved cards\Test1.xml"); // Loads the XML
            string test1 = xmlDoc.SelectSingleNode("Test1/QuestionInfo/Question1").InnerText;
            quizSelectionComboBox.Items.Add(avaiableQuizes);
        }

        private void topic1Button_Click(object sender, EventArgs e)
        {
            Dispose();
            StudyForm sf = new StudyForm();
            sf.ShowDialog();
        }
    }
}
