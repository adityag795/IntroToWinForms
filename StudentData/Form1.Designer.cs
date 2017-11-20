namespace StudentData
{
    partial class AddStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            this.Heading = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Update = new System.Windows.Forms.Button();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.Del = new System.Windows.Forms.Button();
            this.Find = new System.Windows.Forms.Button();
            this.ddlQualification = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Cancel = new System.Windows.Forms.Button();
            this.Submit = new System.Windows.Forms.Button();
            this.txtTwelth = new System.Windows.Forms.TextBox();
            this.txtTenth = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.Female = new System.Windows.Forms.RadioButton();
            this.Male = new System.Windows.Forms.RadioButton();
            this.Gender = new System.Windows.Forms.Label();
            this.Qualification = new System.Windows.Forms.Label();
            this.Twelth = new System.Windows.Forms.Label();
            this.Tenth = new System.Windows.Forms.Label();
            this.MobileNo = new System.Windows.Forms.Label();
            this.PhoneNo = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.Font = new System.Drawing.Font("Dubai Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heading.Location = new System.Drawing.Point(86, 3);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(286, 40);
            this.Heading.TabIndex = 0;
            this.Heading.Text = "Enter Student Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.Update);
            this.panel1.Controls.Add(this.txtStudentID);
            this.panel1.Controls.Add(this.ID);
            this.panel1.Controls.Add(this.Del);
            this.panel1.Controls.Add(this.Find);
            this.panel1.Controls.Add(this.ddlQualification);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.Cancel);
            this.panel1.Controls.Add(this.Submit);
            this.panel1.Controls.Add(this.txtTwelth);
            this.panel1.Controls.Add(this.txtTenth);
            this.panel1.Controls.Add(this.txtMobile);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.Female);
            this.panel1.Controls.Add(this.Male);
            this.panel1.Controls.Add(this.Gender);
            this.panel1.Controls.Add(this.Qualification);
            this.panel1.Controls.Add(this.Twelth);
            this.panel1.Controls.Add(this.Tenth);
            this.panel1.Controls.Add(this.MobileNo);
            this.panel1.Controls.Add(this.PhoneNo);
            this.panel1.Controls.Add(this.txtMail);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.Heading);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 616);
            this.panel1.TabIndex = 2;
            // 
            // Update
            // 
            this.Update.Font = new System.Drawing.Font("Dubai Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.Location = new System.Drawing.Point(270, 482);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(102, 33);
            this.Update.TabIndex = 28;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // txtStudentID
            // 
            this.txtStudentID.Font = new System.Drawing.Font("Dubai Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentID.Location = new System.Drawing.Point(122, 423);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(263, 30);
            this.txtStudentID.TabIndex = 27;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(11, 423);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(87, 27);
            this.ID.TabIndex = 26;
            this.ID.Text = "Student ID:";
            // 
            // Del
            // 
            this.Del.Font = new System.Drawing.Font("Dubai Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Del.Location = new System.Drawing.Point(30, 521);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(102, 29);
            this.Del.TabIndex = 25;
            this.Del.Text = "Delete";
            this.Del.UseVisualStyleBackColor = true;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // Find
            // 
            this.Find.Font = new System.Drawing.Font("Dubai Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Find.Location = new System.Drawing.Point(150, 482);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(102, 33);
            this.Find.TabIndex = 24;
            this.Find.Text = "Find";
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // ddlQualification
            // 
            this.ddlQualification.Font = new System.Drawing.Font("Dubai Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlQualification.FormattingEnabled = true;
            this.ddlQualification.Items.AddRange(new object[] {
            "10",
            "12",
            "Graduation",
            "Post Graduation",
            "PHD",
            "DIploma"});
            this.ddlQualification.Location = new System.Drawing.Point(127, 356);
            this.ddlQualification.Name = "ddlQualification";
            this.ddlQualification.Size = new System.Drawing.Size(258, 30);
            this.ddlQualification.TabIndex = 23;
            this.ddlQualification.Text = "-------select---------";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Dubai Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(127, 91);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(258, 30);
            this.dateTimePicker1.TabIndex = 22;
            this.dateTimePicker1.Value = new System.DateTime(2017, 10, 9, 8, 53, 56, 0);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Dubai Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.Location = new System.Drawing.Point(270, 521);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(102, 29);
            this.Cancel.TabIndex = 21;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Submit
            // 
            this.Submit.Font = new System.Drawing.Font("Dubai Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(30, 482);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(102, 33);
            this.Submit.TabIndex = 20;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // txtTwelth
            // 
            this.txtTwelth.Font = new System.Drawing.Font("Dubai Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTwelth.Location = new System.Drawing.Point(127, 313);
            this.txtTwelth.Name = "txtTwelth";
            this.txtTwelth.Size = new System.Drawing.Size(258, 30);
            this.txtTwelth.TabIndex = 18;
            // 
            // txtTenth
            // 
            this.txtTenth.Font = new System.Drawing.Font("Dubai Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenth.Location = new System.Drawing.Point(127, 265);
            this.txtTenth.Name = "txtTenth";
            this.txtTenth.Size = new System.Drawing.Size(258, 30);
            this.txtTenth.TabIndex = 17;
            // 
            // txtMobile
            // 
            this.txtMobile.Font = new System.Drawing.Font("Dubai Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobile.Location = new System.Drawing.Point(127, 222);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(258, 30);
            this.txtMobile.TabIndex = 16;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Dubai Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(127, 175);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(258, 30);
            this.txtPhone.TabIndex = 15;
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.Font = new System.Drawing.Font("Dubai Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Female.Location = new System.Drawing.Point(204, 395);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(70, 28);
            this.Female.TabIndex = 14;
            this.Female.TabStop = true;
            this.Female.Text = "Female";
            this.Female.UseVisualStyleBackColor = true;
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Font = new System.Drawing.Font("Dubai Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Male.Location = new System.Drawing.Point(128, 395);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(57, 28);
            this.Male.TabIndex = 13;
            this.Male.TabStop = true;
            this.Male.Text = "Male";
            this.Male.UseVisualStyleBackColor = true;
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.Location = new System.Drawing.Point(11, 390);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(63, 27);
            this.Gender.TabIndex = 12;
            this.Gender.Text = "Gender:";
            // 
            // Qualification
            // 
            this.Qualification.AutoSize = true;
            this.Qualification.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qualification.Location = new System.Drawing.Point(11, 356);
            this.Qualification.Name = "Qualification";
            this.Qualification.Size = new System.Drawing.Size(100, 27);
            this.Qualification.TabIndex = 11;
            this.Qualification.Text = "Qualification:";
            // 
            // Twelth
            // 
            this.Twelth.AutoSize = true;
            this.Twelth.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Twelth.Location = new System.Drawing.Point(11, 313);
            this.Twelth.Name = "Twelth";
            this.Twelth.Size = new System.Drawing.Size(103, 27);
            this.Twelth.TabIndex = 10;
            this.Twelth.Text = "Twelth Score:";
            // 
            // Tenth
            // 
            this.Tenth.AutoSize = true;
            this.Tenth.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tenth.Location = new System.Drawing.Point(11, 265);
            this.Tenth.Name = "Tenth";
            this.Tenth.Size = new System.Drawing.Size(96, 27);
            this.Tenth.TabIndex = 9;
            this.Tenth.Text = "Tenth Score:";
            // 
            // MobileNo
            // 
            this.MobileNo.AutoSize = true;
            this.MobileNo.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MobileNo.Location = new System.Drawing.Point(11, 222);
            this.MobileNo.Name = "MobileNo";
            this.MobileNo.Size = new System.Drawing.Size(83, 27);
            this.MobileNo.TabIndex = 8;
            this.MobileNo.Text = "Mobile No:";
            // 
            // PhoneNo
            // 
            this.PhoneNo.AutoSize = true;
            this.PhoneNo.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNo.Location = new System.Drawing.Point(11, 175);
            this.PhoneNo.Name = "PhoneNo";
            this.PhoneNo.Size = new System.Drawing.Size(86, 27);
            this.PhoneNo.TabIndex = 7;
            this.PhoneNo.Text = "Phone No. :";
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Dubai Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(127, 131);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(258, 30);
            this.txtMail.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date of Birth:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Dubai Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(127, 51);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(258, 30);
            this.txtName.TabIndex = 2;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 623);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Student Info";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label MobileNo;
        private System.Windows.Forms.Label PhoneNo;
        private System.Windows.Forms.Label Qualification;
        private System.Windows.Forms.Label Twelth;
        private System.Windows.Forms.Label Tenth;
        private System.Windows.Forms.TextBox txtTwelth;
        private System.Windows.Forms.TextBox txtTenth;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.ComboBox ddlQualification;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Button Update;
    }
}

