using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_System
{
    public partial class Instructor : Form
    {
        public int Ins_Id;
        public string fname;
        public string lname;
        public string age;
        public int Dept_Id;
        string department;
        public string password;
       
        public Instructor()
        {
            InitializeComponent();
        }

        private void Instructor_Load(object sender, EventArgs e)
        {
            string Ins_Courses = $"select Crs_Name from Ins_course i,Course c where i.Crs_Id = c.Crs_Id and Ins_Id= {Ins_Id}";
            string Ins_Dept = $"select Dept_Name from Department where Dept_Id = {Dept_Id}";
            sqlCommand1.CommandText = Ins_Courses;
            sqlConnection1.Open();
            SqlDataReader dReadr = sqlCommand1.ExecuteReader();
            while (dReadr.Read())
            {
                guna2ComboBox1.Items.Add(dReadr[0]);
            }
            dReadr.Close();
            sqlCommand1.CommandText = Ins_Dept;
            dReadr = sqlCommand1.ExecuteReader();
            dReadr.Read();
            department = dReadr[0].ToString();
            dReadr.Close();
            sqlConnection1.Close();
            label2.Text = Ins_Id.ToString();
            label3.Text = fname.ToString() + " " + lname.ToString() + $", {age}";
            label5.Text = department;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Course newCourseForm = new Course();
            newCourseForm.Show();
            //this.Visible = false;
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CourseDetails crs_det = new CourseDetails();
            crs_det.ins_crs = guna2ComboBox1.SelectedItem.ToString();
            crs_det.inscrs_id = Ins_Id;
            OpenChildForm(crs_det);
            //Hide();
            //crs_det.ShowDialog();
            //Close();
        }

        private Form ActiveForm = null;
        private void OpenChildForm(Form ChildForm)
        {
            if (ActiveForm != null)
                ActiveForm.Close();
            ActiveForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel2.Controls.Add(ChildForm);
            panel2.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }
    }
}
