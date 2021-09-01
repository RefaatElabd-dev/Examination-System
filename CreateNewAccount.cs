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
    public partial class CreateNewAccount : Form
    {
        public string position;
        public CreateNewAccount()
        {
            InitializeComponent();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CreateNewAccount_Load(object sender, EventArgs e)
        {
            guna2ComboBox1.Items.Add("Student");
            guna2ComboBox1.Items.Add("Instructor");

            String selectDeptName = "select Dept_Name from Department";
            sqlCommand1.CommandText = selectDeptName;
            SqlDataReader dReader;
            sqlConnection1.Open();
            dReader = sqlCommand1.ExecuteReader();


            while (dReader.Read())
            {
                guna2ComboBox2.Items.Add(dReader[0]);
            }
            dReader.Close();
            sqlConnection1.Close();
            guna2ComboBox1.Text = position;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            String selectDeptID = $"select Dept_Id from Department where Dept_Name = '{guna2ComboBox2.SelectedItem.ToString()}'";
            if (guna2ComboBox1.SelectedItem == "Student")
            {
                sqlConnection1.Open();
                sqlCommand1.CommandText = selectDeptID;
                SqlDataReader dReader = sqlCommand1.ExecuteReader();
                dReader.Read();
                SqlCommand sqlCommand2 = new SqlCommand("newstudent", sqlConnection1);
                sqlCommand2.CommandType = CommandType.StoredProcedure;
                sqlCommand2.Parameters.AddWithValue("@fname", guna2TextBox1.Text);
                sqlCommand2.Parameters.AddWithValue("@lname", guna2TextBox2.Text);
                sqlCommand2.Parameters.AddWithValue("@age", guna2TextBox3.Text);
                sqlCommand2.Parameters.AddWithValue("@password", guna2TextBox4.Text);
                sqlCommand2.Parameters.AddWithValue("@Dept_Id",int.Parse(dReader[0].ToString()));
                dReader.Close();
                sqlCommand2.ExecuteNonQuery();
                MessageBox.Show("Student Added.");
                sqlConnection1.Close();
                guna2TextBox1.Text = guna2TextBox2.Text = guna2TextBox3.Text = guna2TextBox4.Text = string.Empty;

            }
            else if(guna2ComboBox1.SelectedItem == "Instructor")
            {
                sqlConnection1.Open();
                sqlCommand1.CommandText = selectDeptID;
                SqlDataReader dReader = sqlCommand1.ExecuteReader();
                dReader.Read();
                SqlCommand sqlCommand3 = new SqlCommand("newinstructor", sqlConnection1);
                sqlCommand3.CommandType = CommandType.StoredProcedure;
                sqlCommand3.Parameters.AddWithValue("@fname", guna2TextBox1.Text);
                sqlCommand3.Parameters.AddWithValue("@lname", guna2TextBox2.Text);
                sqlCommand3.Parameters.AddWithValue("@age", guna2TextBox3.Text);
                sqlCommand3.Parameters.AddWithValue("@password", guna2TextBox4.Text);
                sqlCommand3.Parameters.AddWithValue("@Dept_Id", int.Parse(dReader[0].ToString()));
                dReader.Close();
                sqlCommand3.ExecuteNonQuery();
                MessageBox.Show("Instructor Added.");
                sqlConnection1.Close();
                guna2TextBox1.Text = guna2TextBox2.Text = guna2TextBox3.Text = guna2TextBox4.Text = string.Empty;
            }else
            {
                MessageBox.Show("Error Occured.");
            }
            Close();
        }
    }
}
