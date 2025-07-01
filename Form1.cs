using System;
using System.Windows.Forms;

namespace GuiCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxOperator.Items.AddRange(new string[] { "+", "-", "*", "/" });
            comboBoxOperator.SelectedIndex = 0;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox2.Text);
                string op = comboBoxOperator.SelectedItem.ToString();
                double result = 0;

                switch (op)
                {
                    case "+": result = num1 + num2; break;
                    case "-": result = num1 - num2; break;
                    case "*": result = num1 * num2; break;
                    case "/":
                        if (num2 == 0)
                        {
                            MessageBox.Show("Cannot divide by zero.");
                            return;
                        }
                        result = num1 / num2;
                        break;
                }

                labelResult.Text = $"Result: {result}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers.");
            }
        }
    }
}
