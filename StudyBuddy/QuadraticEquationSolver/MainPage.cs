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

            // Solve the first side of equation.
            double topSide = Math.Sqrt((Math.Pow(b, 2)) - (4 * a * c) / (2 * a));
            double bottomSide = (2 * a);
            double rightSide = (topSide) / (bottomSide);

            // Solve the second side of the equation.
            double leftSide = (-b / (2 * a));
            
            // Add and subtract both sides of the equation with eachother to get both solutions.
            solution1 = Math.Round((leftSide) - (rightSide), 3);
            solution2 = Math.Round((leftSide) + (rightSide), 3);

            // Print out the solutions to the TextBox.
            solutionOut.Text = solution1 + " and " + solution2;
        }
    }
}
