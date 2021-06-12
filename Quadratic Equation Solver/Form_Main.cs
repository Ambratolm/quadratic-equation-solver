using System;
using System.Windows.Forms;

namespace QuadraticEquationSolver
{
    public partial class Form_Main : Form
    {
        double a = 0, b = 0, c = 0, delta;

        public Form_Main()
        {
            InitializeComponent();
            numericUpDown_a.TextChanged += new EventHandler(numericUpDown_a_ValueChanged);
            numericUpDown_b.TextChanged += new EventHandler(numericUpDown_b_ValueChanged);
            numericUpDown_c.TextChanged += new EventHandler(numericUpDown_c_ValueChanged);
        }

        private void update_equation()
        {
            if (a == 0)
            {
                richTextBox_result.Text = "The coefficient « a » must be different from 0.";
            }
            else
            {
                delta = b * b - 4 * a * c;
                textbox_delta.Text = delta.ToString();
                textBox_mini_delta.Text = Math.Sqrt(Math.Abs(delta)).ToString();
                label_equation.Text = a + "x² + " + b + "x + " + c + " = 0";
                if (delta > 0)
                {
                    double x1, x2;
                    x1 = (-b - Math.Sqrt(delta)) / 2 * a;
                    x2 = (-b + Math.Sqrt(delta)) / 2 * a;
                    richTextBox_result.Text = "Positive discriminant (Δ>0).\nThe equation admits two real roots:\n"
                    + "x1 = (-b - √Δ) / 2a ≈ " + Math.Round(x1) + "\nx2 = (-b + √Δ) / 2a ≈ " + Math.Round(x2);
                    textBox_x1.Text = x1.ToString(); textBox_x2.Text = x2.ToString();
                }
                else if (delta == 0)
                {
                    double x0;
                    x0 = -b / (2 * a);
                    richTextBox_result.Text = "Null discriminant (Δ=0).\nThe equation admits only one double real root:\n"
                    + "xₒ = x1 = x2 = -b / 2a ≈ " + Math.Round(x0);
                    textBox_x1.Text = textBox_x2.Text = x0.ToString();
                }
                else if (delta < 0)
                {
                    double x, y;
                    x = -b / (2 * a); y = Math.Sqrt(-delta) / (2 * a);
                    richTextBox_result.Text = "Negative discriminant (Δ<0).\nThe equation admits two complex roots:\n"
                    + "x1 = (-b - iδ) / 2a ≈ " + Math.Round(x) + " + " + Math.Round(y) + "i"
                    + "\nx2 = (-b + iδ) / 2a ≈ " + Math.Round(x) + " - " + Math.Round(y) + "i";
                    textBox_x1.Text = x + " - " + y + "i"; textBox_x2.Text = x + " + " + y + "i";
                }
            }

        }

        private void numericUpDown_a_ValueChanged(object sender, EventArgs e)
        {
            a = (double)numericUpDown_a.Value;
            update_equation();
        }

        private void numericUpDown_b_ValueChanged(object sender, EventArgs e)
        {
            b = (double)numericUpDown_b.Value;
            update_equation();
        }

        private void numericUpDown_c_ValueChanged(object sender, EventArgs e)
        {
            c = (double)numericUpDown_c.Value;
            update_equation();
        }

        private void button_initialize_Click(object sender, EventArgs e)
        {
            numericUpDown_a.Value = numericUpDown_b.Value = numericUpDown_c.Value = 0;
            textbox_delta.Text = textBox_mini_delta.Text = richTextBox_result.Text = textBox_x1.Text = textBox_x2.Text = null;
            label_equation.Text = "ax² + bx + c = 0";

        }
    }
}