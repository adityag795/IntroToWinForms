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
        bool ValidateInput()
        {
            if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please enter Student's Name.");
                return false;
            }
            if (String.IsNullOrEmpty(txtMail.Text))
            {
                MessageBox.Show("Please enter Student's Email.");
                return false;
            }
            if (String.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Please enter Student's Phone No.");
                return false;
            }
            if (String.IsNullOrEmpty(txtMobile.Text))
            {
                MessageBox.Show("Please enter Student's Mobile No.");
                return false;
            }
            if (String.IsNullOrEmpty(txtTenth.Text))
            {
                MessageBox.Show("Please enter Student's Tenth Percentage.");
                return false;
            }
            if (String.IsNullOrEmpty(txtTwelth.Text))
            {
                MessageBox.Show("Please enter Student's Twelth Percentage.");
                return false;
            }
            if (String.IsNullOrEmpty(dateTimePicker1.Value.ToShortDateString()))
            {
                MessageBox.Show("Please enter Student's Date of birth.");
                return false;
            }
            if (ddlQualification.Text == "-------select---------")
            {
                MessageBox.Show("Please select Student's Qualification.");
                return false;
            }
            if (!(Male.Checked) && !(Female.Checked))
            {
                MessageBox.Show("Please select Student's Gender.");
                return false;
            }
            return true;
        }

        public AddStudent()
        {
            InitializeComponent();
        }

        string connectionString = "Data Source=(local);Initial Catalog=Student;User ID=sa;Password=myasp.net^";
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection();

        private void Submit_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                conn = new SqlConnection(connectionString);
                string gender = "";
                if (Male.Checked == true)
                    gender = "M";
                else
                    gender = "F";
                //string qry = "INSERT INTO StudentDetail  (Name='" + textBox1.Text + "',DOB='"+ dateTimePicker1.Value.ToShortDateString() + "',Email='"+ textBox2.Text + "',PhoneNo='"+ textBox3.Text + "',MobileNo='"+ textBox4.Text + "',TenthScore='"+ textBox5.Text+"',TwelthScore='"+ textBox6.Text+"',Qualification='"+ comboBox1.Text +"',Gender='"+gender+"')";
                string qry = "INSERT INTO StudentDetail VALUES ('" + txtName.Text + "','" + dateTimePicker1.Value.ToShortDateString() + "','"
                    + txtMail.Text + "','" + txtPhone.Text + "','" + txtMobile.Text + "','" + txtTenth.Text + "','" + txtTwelth.Text + "','"
                    + ddlQualification.Text + "','" + gender + "')";
                cmd = new SqlCommand(qry, conn);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show(rows + " record inserted.");
            }
        }

        private void Find_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(txtStudentID.Text)))
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
                            if (txtStudentID.Text == rdr["ID"].ToString())
                            {
                                txtName.Text = rdr["Name"].ToString();
                                dateTimePicker1.Value = Convert.ToDateTime(rdr["DOB"]);
                                txtMail.Text = rdr["Email"].ToString();
                                txtPhone.Text = rdr["PhoneNo"].ToString();
                                txtMobile.Text = rdr["MobileNo"].ToString();
                                txtTenth.Text = rdr["TenthScore"].ToString();
                                txtTwelth.Text = rdr["TwelthScore"].ToString();
                                ddlQualification.Text = rdr["Qualification"].ToString();

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
                            //Notifier.Text = "Record Not Found.";
                            txtName.Text = "";
                            txtMail.Text = "";
                            txtPhone.Text = "";
                            txtMobile.Text = "";
                            txtTenth.Text = "";
                            txtTwelth.Text = "";
                            Male.Checked = Female.Checked = false;
                            MessageBox.Show("Record Not Found.");
                        }
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
            else
            {
                MessageBox.Show("Please enter Student Id.");
            }
        }

        private void Del_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtStudentID.Text) == false)
            {
                using (conn = new SqlConnection(connectionString))
                {
                    string qry = "DELETE FROM StudentDetail WHERE ID=" + Convert.ToInt32(txtStudentID.Text);
                    cmd = new SqlCommand(qry, conn);
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    MessageBox.Show(rows + " record deleted.");
                }
            }
            else
            {
                MessageBox.Show("Please enter Student Id.");
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtStudentID.Text) == false)
            {
                using (conn = new SqlConnection(connectionString))
                {
                    string gender = "";
                    if (Male.Checked == true)
                        gender = "M";
                    else
                        gender = "F";

                    string qry = "UPDATE StudentDetail SET Name='" + txtName.Text + "',DOB='" + dateTimePicker1.Value.ToShortDateString()
                    + "',Email='" + txtMail.Text + "',PhoneNo='" + txtPhone.Text + "',MobileNo='" + txtMobile.Text + "',TenthScore='"
                    + txtTenth.Text + "',TwelthScore='" + txtTwelth.Text + "',Qualification='" + ddlQualification.Text + "',Gender='" + gender
                    + "' WHERE ID=" + Convert.ToInt32(txtStudentID.Text);

                    cmd = new SqlCommand(qry, conn);
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    MessageBox.Show(rows + " record updated.");
                }
            }
            else
            {
                MessageBox.Show("Please enter Student Id.");
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}