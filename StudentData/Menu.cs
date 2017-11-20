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
    public partial class Menu : Form
    {
        SplashScreen s1 = new SplashScreen();
        public Menu()
        {
            InitializeComponent();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent f1 = new AddStudent();
            f1.ShowDialog();
        }

        private void operationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Operation op = new Operation();
            op.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            //SplashScreen s1 = new SplashScreen();
            s1.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void billToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bill b = new Bill();
            b.ShowDialog();
        }
    }
}
