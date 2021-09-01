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
    public partial class StudentLoggedIn : Form
    {
        public int Std_Id;
        public string Std_Fname;
        public string Std_Lname;
        public int Std_Age;
        public int Std_Dept_Id;
        public string Std_Dept_Name;
        public string password;
        string Crs_name = null;
        int Crs_Id;

        public StudentLoggedIn()
        {
            InitializeComponent();
        }
        private void StudentLoggedIn_Load(object sender, EventArgs e)
        {
            guna2ComboBox1.Items.Clear();
            label7.Text = Std_Id.ToString();
            label8.Text = $"{Std_Fname} {Std_Lname}, {Std_Age}";
            label10.Text = Std_Dept_Name;
            guna2ComboBox1.Items.Add("All");

            string studentCourses = $"select c.Crs_Name " +
                                    $"from course c inner join Std_course sc " +
                                    $"on c.Crs_Id = sc.Crs_Id and sc.Std_Id = {Std_Id}";

            string StudentGrades = @"select c.Crs_Name as ""Course Name"", ISNULL(convert(varchar(20), sc.Grade), 'No grade') as ""Grade"" " +
                                    $"from Student s inner " +
                                    $"join Std_Course sc " +
                                    $"on s.Std_Id = sc.Std_Id and s.Std_Id = {Std_Id} " +
                                    $"inner join Course c " +
                                    $"on sc.Crs_Id = c.Crs_Id";
            sqlConnection1.Open();
            sqlCommand1.CommandText = studentCourses;
            SqlDataReader dReader = sqlCommand1.ExecuteReader();
            while (dReader.Read())
            {
                guna2ComboBox1.Items.Add(dReader[0]);
            }
            dReader.Close();
            sqlCommand1.CommandText = StudentGrades;
            DataTable DT = new DataTable();
            DT.Load(sqlCommand1.ExecuteReader());
            guna2DataGridView1.DataSource = DT;
            //DataRow newRow = DT.NewRow();
            //newRow[0] = "Course Name";
            //newRow[1] = "Grade";
            //DT.Rows.InsertAt(newRow, 0);
            sqlConnection1.Close();
            guna2ComboBox1.Text = "All";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (Crs_name == null || Crs_Id == 0)
            {
                MessageBox.Show("Please pick a course.");
                return;
            }
            Generate_Exam ExamForm = new Generate_Exam();
            ExamForm.std_Id = Std_Id;
            ExamForm.Crs_Id = Crs_Id;
            ExamForm.Crs_Name = Crs_name;
            
            ExamForm.ShowDialog();
            
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(guna2ComboBox1.SelectedItem == "All")
            {
                return;
            }
            Crs_name = guna2ComboBox1.SelectedItem.ToString();
            string CourseId = $"select Crs_Id " +
                              $"from course " +
                              $"where Crs_Name = '{Crs_name}'";
            //MessageBox.Show(studentCourses);
            sqlConnection1.Open();
            sqlCommand1.CommandText = CourseId;
            SqlDataReader dReader = sqlCommand1.ExecuteReader();
            dReader.Read();
            Crs_Id = int.Parse(dReader[0].ToString());
            dReader.Close();
            sqlConnection1.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            EditStudentinfo EditForm = new EditStudentinfo();

            EditForm.Std_Id = Std_Id;
            EditForm.Std_Fname = Std_Fname;
            EditForm.Std_Lname = Std_Lname;
            EditForm.Std_Age = Std_Age;
            EditForm.Std_Dept_Id = Std_Dept_Id;
            EditForm.Std_Dept_Name = Std_Dept_Name;

            EditForm.ShowDialog();
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            SqlCommand sqlcommand1 = new SqlCommand("deleteStudent", sqlConnection1);
            sqlcommand1.CommandType = CommandType.StoredProcedure;
            sqlcommand1.Parameters.AddWithValue("@id", Std_Id);
            sqlcommand1.ExecuteNonQuery();

            sqlConnection1.Close();
            MessageBox.Show("Data Deleted.");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            StudentLoggedIn_Load(null, EventArgs.Empty);
        }
    }
}
