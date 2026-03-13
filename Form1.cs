using System;
using System.Windows.Forms;

namespace ProfessionalCalculator
{
    public partial class Form1 : Form
    {
        double num1 = 0;
        double num2 = 0;
        char operation;
        bool operationPressed = false;
        bool scientificMode = false;

        public Form1()
        {
            InitializeComponent();
        }

        // Number Buttons
        private void number_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (txtDisplay.Text == "0" || operationPressed)
                txtDisplay.Clear();

            operationPressed = false;
            txtDisplay.Text += btn.Text;
        }

        // Operators
        private void operator_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            num1 = Convert.ToDouble(txtDisplay.Text);
            operation = btn.Text[0];
            operationPressed = true;
        }

        // Equals
        private void btnEqual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(txtDisplay.Text);

            switch (operation)
            {
                case '+':
                    txtDisplay.Text = (num1 + num2).ToString();
                    break;

                case '-':
                    txtDisplay.Text = (num1 - num2).ToString();
                    break;

                case '*':
                    txtDisplay.Text = (num1 * num2).ToString();
                    break;

                case '/':
                    if (num2 != 0)
                        txtDisplay.Text = (num1 / num2).ToString();
                    else
                        MessageBox.Show("Cannot divide by zero");
                    break;
            }
        }

        // Clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            num1 = 0;
            num2 = 0;
        }

        // Scientific Mode Toggle
        private void btnScientific_Click(object sender, EventArgs e)
        {
            if (!scientificMode)
            {
                this.Width = 600;
                scientificMode = true;
            }
            else
            {
                this.Width = 420;
                scientificMode = false;
            }
        }

        // Scientific Functions

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = Math.Sqrt(value).ToString();
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = Math.Pow(value, 2).ToString();
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = Math.Sin(value).ToString();
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = Math.Cos(value).ToString();
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = Math.Tan(value).ToString();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = Math.Log10(value).ToString();
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = Math.PI.ToString();
        }
    }
}
