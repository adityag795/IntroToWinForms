using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace StudentData
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        string connectionString = "Data Source=(local);Initial Catalog=Student;User ID=sa;Password=myasp.net^";
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection();

        private void Submit_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);
            string gender = "";
            if (Male.Checked == true)
                gender = "M";
            else
                gender = "F";
            //string qry = "INSERT INTO StudentDetail  (Name='" + textBox1.Text + "',DOB='"+ dateTimePicker1.Value.ToShortDateString() + "',Email='"+ textBox2.Text + "',PhoneNo='"+ textBox3.Text + "',MobileNo='"+ textBox4.Text + "',TenthScore='"+ textBox5.Text+"',TwelthScore='"+ textBox6.Text+"',Qualification='"+ comboBox1.Text +"',Gender='"+gender+"')";
            string qry = "INSERT INTO StudentDetail VALUES ('" + textBox1.Text + "','" + dateTimePicker1.Value.ToShortDateString() + "','"
                + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','"
                + comboBox1.Text + "','" + gender + "')";
            cmd = new SqlCommand(qry, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void Find_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            {
                bool found = false;
                conn.Open();
                string query = "SELECT * FROM StudentDetail";
                SqlCommand cmd = new SqlCommand(query, conn);

                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    //DataTable table = new DataTable();
                    //table.Columns.Add("id");
                    //table.Columns.Add("name");
                    //table.Columns.Add("dob");
                    //table.Columns.Add("mail");
                    //table.Columns.Add("phone");
                    //table.Columns.Add("mobile");
                    //table.Columns.Add("tenth");
                    //table.Columns.Add("twelth");
                    //table.Columns.Add("qual");
                    //table.Columns.Add("gender");

                    while (rdr.Read())
                    {
                        if (StudentID.Text == rdr["ID"].ToString())
                        {
                            textBox1.Text = rdr["Name"].ToString();
                            dateTimePicker1.Value = Convert.ToDateTime(rdr["DOB"]);
                            textBox2.Text = rdr["Email"].ToString();
                            textBox3.Text = rdr["PhoneNo"].ToString();
                            textBox4.Text = rdr["MobileNo"].ToString();
                            textBox5.Text = rdr["TenthScore"].ToString();
                            textBox6.Text = rdr["TwelthScore"].ToString();
                            comboBox1.Text = rdr["Qualification"].ToString();

                            if (rdr["Gender"].ToString() == "M")
                            {
                                Male.Checked = true;
                                Female.Checked = false;
                            }
                            else
                            {
                                Male.Checked = false;
                                Female.Checked = true;
                            }

                            found = true;
                        }
                    }
                    if (found == false)
                    {
                        Notifier.Text = "Record Not Found.";
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";
                        Male.Checked = Female.Checked = false;
                    }
                    else
                        Notifier.Text = "";
                }
                /*
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string id = dt.Rows[i]["ID"].ToString();
                    MessageBox.Show(id);
                }
                 */
            }
        }

        private void Del_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            {
                string qry = "DELETE FROM StudentDetail WHERE ID=" + Convert.ToInt32(StudentID.Text);
                cmd = new SqlCommand(qry, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            {
                string gender = "";
                if (Male.Checked == true)
                    gender = "M";
                else
                    gender = "F";

                string qry = "UPDATE StudentDetail SET Name='" + textBox1.Text + "',DOB='" + dateTimePicker1.Value.ToShortDateString()
                + "',Email='" + textBox2.Text + "',PhoneNo='" + textBox3.Text + "',MobileNo='" + textBox4.Text + "',TenthScore='"
                + textBox5.Text + "',TwelthScore='" + textBox6.Text + "',Qualification='" + comboBox1.Text + "',Gender='" + gender
                + "' WHERE ID=" + Convert.ToInt32(StudentID.Text);

                cmd = new SqlCommand(qry, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}