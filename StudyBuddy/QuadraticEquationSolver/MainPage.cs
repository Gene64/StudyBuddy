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
            findRoots();
        }

        private void findRoots()
        {
            // Get variable's values from user.
            a = double.Parse(aValueTextBox.Text);
            b = double.Parse(BValueTextBox.Text);
            c = double.Parse(CValueTextBox.Text);

            // Solve the first side of equation.
            double firstSide = (-b / (2 * a));

            // Solve the second side of the equation.
            double secondSide = Math.Sqrt((Math.Pow(b, 2)) - (4 * a * c)) / (2 * a);

            // Add and subtract both sides of the equation with eachother to get both solutions.
            solution1 = Math.Round((firstSide) - (secondSide), 3);
            solution2 = Math.Round((firstSide) + (secondSide), 3);

            // Find out how many solutions there are and print it out to the label.
            if (solution1.ToString() == "NaN" && solution2.ToString() == "NaN")
                solutionsLabel.Text = "There are 0 solutions:";
            else if (solution1.ToString() == "NaN" || solution2.ToString() == "NaN")
                solutionsLabel.Text = "There is 1 solution:";
            else if (solution1.ToString() != "NaN" && solution1.ToString() != "NaN")
                solutionsLabel.Text = "There are 2 solutions:";

            // Print out the solutions to the TextBox.
            solutionOut.Text = solution1 + ", " + solution2;
        }
    }
}
