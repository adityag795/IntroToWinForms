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

            if (String.IsNullOrEmpty(txtQty.Text))
            {
                txtQty.Text ="0";
            }
            if (String.IsNullOrEmpty(txtPrice.Text))
            {
                txtPrice.Text = "0.00";
            }
            rate =Convert.ToDouble(txtPrice.Text);
            qty = Convert.ToDouble(txtQty.Text);
            total = rate * qty;
            Amt.Text = Convert.ToString(total);
            if (String.IsNullOrEmpty(txtPrice.Text) || String.IsNullOrEmpty(txtQty.Text))
            {
                Amt.Text = "";
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDiscount.Text) == false)
                dis = Convert.ToDouble(txtDiscount.Text);
            final = total - ((dis / 100) * total);
            Net.Text = Convert.ToString(final);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPrice.Text))
            {
                txtPrice.Text = "0.00";
            }
            if (String.IsNullOrEmpty(txtQty.Text))
            {
                txtQty.Text = "0";
            }
            rate = Convert.ToDouble(txtPrice.Text);
            qty = Convert.ToDouble(txtQty.Text);
            total = rate * qty;
            Amt.Text = Convert.ToString(total);
            if (String.IsNullOrEmpty(txtPrice.Text) || String.IsNullOrEmpty(txtQty.Text))
            {
                Amt.Text = "";
            }
        }
    }
}
