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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

           
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            int i;

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 500;

            for (i = 0; i <= 500; i++)
            {
                progressBar1.Value = i;
            }

            if (progressBar1.Value == 500)
            {
               
                Menu m1 = new Menu();
                m1.ShowDialog();
            }
        }
    }
}
