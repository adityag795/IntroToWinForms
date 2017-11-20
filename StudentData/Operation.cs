using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudentData
{
    public partial class Operation : Form
    {
        double num1, num2,res;
        public Operation()
        {
            InitializeComponent();
        }

        bool ValidateInput()
        {
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please enter both the operands.");
                return false;
            }
            return true;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                num1 = Convert.ToDouble(textBox1.Text);
                num2 = Convert.ToDouble(textBox2.Text);
                res = num1 + num2;
                Output.Text = Convert.ToString(res);
            }
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                num1 = Convert.ToDouble(textBox1.Text);
                num2 = Convert.ToDouble(textBox2.Text);
                res = num1 - num2;
                Output.Text = Convert.ToString(res);
            }
        }

        private void Mul_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                num1 = Convert.ToDouble(textBox1.Text);
                num2 = Convert.ToDouble(textBox2.Text);
                res = num1 * num2;
                Output.Text = Convert.ToString(res);
            }
        }

        private void Div_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                num1 = Convert.ToDouble(textBox1.Text);
                num2 = Convert.ToDouble(textBox2.Text);
                res = num1 / num2;
                Output.Text = Convert.ToString(res);
            }
        }
    }
}
