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

        // The description label turns invisible when the user isn't hovering over any of the buttons.
        private void createButton_MouseLeave(object sender, EventArgs e)
        {
            descriptionLabel.Visible = false;
        }

        private void loadButton_MouseLeave(object sender, EventArgs e)
        {
            descriptionLabel.Visible = false;
        }

        private void deleteButton_MouseLeave(object sender, EventArgs e)
        {
            descriptionLabel.Visible = false;
        }

        /*
        This gets the descriptionLabel width and subtracts it from the applications width, then divides by two.
        It sets the left side of the label to that amount, which will be equivalent to the right side.
        */
        private void centerDescriptionLabel()
        {
            descriptionLabel.Left = (ClientSize.Width - descriptionLabel.Size.Width) / 2;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            NewCardsForm ncf = new NewCardsForm();
            ncf.ShowDialog();
        }

        private void useButton_Click(object sender, EventArgs e)
        {

        }
    }
}
