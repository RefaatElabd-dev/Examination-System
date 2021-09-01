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
    public partial class EditStudentinfo : Form
    {
        public int Std_Id;
        public string Std_Fname;
        public string Std_Lname;
        public int Std_Age;
        public int Std_Dept_Id;
        public string Std_Dept_Name;

        public EditStudentinfo()
        {
            InitializeComponent();
        }

        private void EditStudentinfo_Load(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            string GetDepartments = $"select Dept_Name from Department";
            //MessageBox.Show(studentCourses);
            sqlCommand2.CommandText = GetDepartments;
            SqlDataReader dReader = sqlCommand2.ExecuteReader();
            while (dReader.Read())
            {
                guna2ComboBox1.Items.Add(dReader[0]);
            }
            dReader.Close();

            sqlConnection1.Close();

            guna2TextBox2.Text = Std_Fname;
            guna2TextBox3.Text = Std_Lname;
            guna2TextBox4.Text = Std_Age.ToString();
            guna2ComboBox1.Text = Std_Dept_Name;
            //guna2TextBox5.Text = Std_Dept_Id.ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Save button
            sqlConnection1.Open();
            Std_Dept_Name = guna2ComboBox1.SelectedItem.ToString();
            string DeptId = $"select Dept_Id " +
                              $"from Department " +
                              $"where Dept_Name = '{Std_Dept_Name}'";
            //MessageBox.Show(studentCourses);
            sqlCommand2.CommandText = DeptId;
            SqlDataReader dReader = sqlCommand2.ExecuteReader();
            dReader.Read();
            Std_Dept_Id = int.Parse(dReader[0].ToString());
            dReader.Close();


            SqlCommand sqlcommand1 = new SqlCommand("EditStudent", sqlConnection1);
            sqlcommand1.CommandType = CommandType.StoredProcedure;
            sqlcommand1.Parameters.AddWithValue("@id", Std_Id);
            sqlcommand1.Parameters.AddWithValue("@fname", guna2TextBox2.Text);
            sqlcommand1.Parameters.AddWithValue("@lname", guna2TextBox3.Text);
            sqlcommand1.Parameters.AddWithValue("@age", int.Parse(guna2TextBox4.Text));
            sqlcommand1.Parameters.AddWithValue("@Dept_id", Std_Dept_Id);
            sqlcommand1.ExecuteNonQuery();

            sqlConnection1.Close();
            MessageBox.Show("Data updated.");
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
    }
}
