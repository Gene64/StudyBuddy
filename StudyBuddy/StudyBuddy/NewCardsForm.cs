using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            questionNumbersComboBox.SelectedIndex = 0;
        }
    }
}
