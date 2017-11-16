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
    public partial class Bill : Form
    {
        double rate,qty,total,dis,final;

        public Bill()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            if (textBox4.Text == "")
            {
                textBox4.Text =" 0.00";
            }
            if (textBox3.Text == "")
            {
                textBox3.Text = " 0.00";
            }
            rate =Convert.ToDouble( textBox3.Text);
            qty = Convert.ToDouble(textBox4.Text);
            total = rate * qty;
            Amt.Text = Convert.ToString(total);
            if (textBox3.Text == "" || textBox4.Text == "")
            {
                Amt.Text = "";
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text != "")
                dis = Convert.ToDouble(textBox6.Text);
            final = total - ((dis / 100) * total);
            Net.Text = Convert.ToString(final);
        }

        private void Amt_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = " 0.00";
            }
            if (textBox4.Text == "")
            {
                textBox4.Text = " 0.00";
            }
            rate = Convert.ToDouble(textBox3.Text);
            qty = Convert.ToDouble(textBox4.Text);
            total = rate * qty;
            Amt.Text = Convert.ToString(total);
            if (textBox3.Text == "" || textBox4.Text == "")
            {
                Amt.Text = "";
            }
        }
    }
}
