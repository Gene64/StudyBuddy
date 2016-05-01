using System;
using System.Windows.Forms;

namespace QuadraticEquationSolver
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        double a;
        double b;
        double c;

        double solution1;
        double solution2;

        private void solveButton_Click(object sender, EventArgs e)
        {
            // Get variable's values from user.
            a = double.Parse(aValueTextBox.Text);
            b = double.Parse(BValueTextBox.Text);
            c = double.Parse(CValueTextBox.Text);

            double topSide = Math.Sqrt((Math.Pow(b, 2)) - (4 * a * c));
            double bottomSide = (2 * a);

            double leftSide = (-b / (2 * a));
            double rightSide = (topSide) / (bottomSide);

            solution1 = (leftSide) + (rightSide);
            solution2 = (leftSide) - (rightSide);

            solutionOut.Text = solution1 + " and " + solution2;
        }
    }
}
