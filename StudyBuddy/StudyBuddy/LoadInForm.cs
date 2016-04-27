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
    public partial class LoadInForm : Form
    {
        public LoadInForm()
        {
            InitializeComponent();
        }


        // Mouse hover effects (I used the MoveMouse event shandler instead of MouseHover because it responds quicker.)
        private void createButton_MouseMove(object sender, MouseEventArgs e)
        {
            descriptionLabel.Visible = true;
            descriptionLabel.Text = "Create study cards about a topic that you need to review.";
            centerDescriptionLabel();
        }

        private void loadButton_MouseMove(object sender, MouseEventArgs e)
        {
            descriptionLabel.Visible = true;
            descriptionLabel.Text = "Load previously saved study cards to continue studying.";
            centerDescriptionLabel();
        }

        private void deleteButton_MouseMove(object sender, MouseEventArgs e)
        {
            descriptionLabel.Visible = true;
            descriptionLabel.Text = "Delete saved study cards that you have already mastered.";
            centerDescriptionLabel();
        }

        /*
        This gets the descriptionLabel width and subtracts it from the applications width, then divides by two.
        It sets the left side of the label to that amount, which will be equivalent to the right side.
        */
        private void centerDescriptionLabel()
        {
            descriptionLabel.Left = (ClientSize.Width - descriptionLabel.Size.Width) / 2;
        }

    }
}
