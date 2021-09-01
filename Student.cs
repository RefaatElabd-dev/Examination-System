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
    public partial class Student : Form
    {
        public int Exam_Id;
        public int Std_Id;
        public int Crs_Id;

        public Student()
        {
            InitializeComponent();
        }

        private void Student_Load(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            SqlCommand Result = new SqlCommand("GetStudentAnswers", sqlConnection1);
            Result.CommandType = CommandType.StoredProcedure;
            Result.Parameters.AddWithValue("@Exam_id", Exam_Id);
            Result.Parameters.AddWithValue("@Stud_id", Std_Id);
            DataTable DT = new DataTable();
            DT.Load(Result.ExecuteReader());
            guna2DataGridView1.DataSource = DT;
            string GetGrade = $"select grade from Std_Course " +
                              $"where Std_Id = {Std_Id} and Crs_Id = {Crs_Id}";
            sqlCommand1.CommandText = GetGrade;
            SqlDataReader dReader = sqlCommand1.ExecuteReader();
            dReader.Read();
            guna2HtmlLabel4.Text = ((((int) dReader[0]) * 100 / 20 )).ToString() + "%";
            dReader.Close();
            sqlConnection1.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
