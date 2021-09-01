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
    public partial class Admin : Form
    {
        public int Ins_Id;
        public string fname;
        public string lname;
        public int age;
        public int Dept_Id;
        string department;
        public string password;
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            string Ins_Courses = "select Crs_Name from Ins_course i,Course c where i.Crs_Id = c.Crs_Id and Ins_Id=" + Ins_Id.ToString();
            string Ins_Dept = $"select Dept_Name from Department where Dept_Id = {Dept_Id}";

            sqlConnection1.Open();
            // get Admin Courses
            SqlCommand cmd = new SqlCommand(Ins_Courses, sqlConnection1);
            cmd.CommandType = CommandType.Text;
            SqlDataReader CoursesNames = cmd.ExecuteReader();
            while (CoursesNames.Read())
            {
                guna2ComboBox1.Items.Add(CoursesNames[0]);
            }
            CoursesNames.Close();
            cmd.CommandText = Ins_Dept;
            CoursesNames = cmd.ExecuteReader();
            CoursesNames.Read();
            department = CoursesNames[0].ToString();
            CoursesNames.Close();
            sqlConnection1.Close();

            guna2HtmlLabel1.Text = Ins_Id.ToString();
            label2.Text = fname + " " + lname;
            label5.Text = department;
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CourseDetails Crs_Det = new CourseDetails();
            Crs_Det.ShowDialog();
        }


        private void CtrlDept_Click_1(object sender, EventArgs e)
        {
            DeptDialog deptDialog = new DeptDialog();
            OpenChildForm(deptDialog);
            //deptDialog.ShowDialog();

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Course newCourseForm = new Course();
            OpenChildForm(newCourseForm);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            instructorCourse frm = new instructorCourse();
            OpenChildForm(frm);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            cntInstructor frm = new cntInstructor();
            OpenChildForm(frm);
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

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            ManageStudents frm = new ManageStudents();
            OpenChildForm(frm);
        }
    }
}
