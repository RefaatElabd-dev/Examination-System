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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            SqlCommand sqlcommand1 = new SqlCommand("getId", sqlConnection1);
            sqlcommand1.CommandType = CommandType.StoredProcedure;
            sqlcommand1.Parameters.AddWithValue("@id", guna2TextBox1.Text);
            sqlcommand1.Parameters.AddWithValue("@password", guna2TextBox2.Text);
            try
            {
                SqlDataReader data = sqlcommand1.ExecuteReader();
                data.Read();
                StudentLoggedIn fm = new StudentLoggedIn();
                fm.Std_Id = int.Parse(data[0].ToString());
                fm.Std_Fname = data[1].ToString();
                fm.Std_Lname = data[2].ToString();
                fm.Std_Age = int.Parse(data[3].ToString());
                fm.Std_Dept_Name = data[4].ToString();
                fm.Std_Dept_Id = int.Parse(data[5].ToString());
                fm.password = data[6].ToString();
                Hide();
                fm.ShowDialog();
                Close();
            }
            catch
            {
                MessageBox.Show("ID or password are incorrect.");
            }
            sqlConnection1.Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            SqlCommand sqlcommand2 = new SqlCommand("getInstructorId", sqlConnection1);
            sqlcommand2.CommandType = CommandType.StoredProcedure;
            sqlcommand2.Parameters.AddWithValue("@id", guna2TextBox1.Text);
            sqlcommand2.Parameters.AddWithValue("@password", guna2TextBox2.Text);
            SqlDataReader Ins_data = sqlcommand2.ExecuteReader();
            Ins_data.Read();
            try
            {
                if (int.Parse(Ins_data[0].ToString()) == 1 && Ins_data[4].ToString() == "1234")
                {
                    Admin admin = new Admin();
                    admin.Ins_Id = int.Parse(Ins_data[0].ToString());
                    admin.fname = Ins_data[1].ToString();
                    admin.lname = Ins_data[2].ToString();
                    admin.Dept_Id = int.Parse(Ins_data[3].ToString());
                    admin.age = int.Parse(Ins_data[5].ToString());
                    admin.password = "";
                    Hide();
                    admin.ShowDialog();
                    Close();
                }
                else
                {
                    Instructor Ins_Form = new Instructor();
                    Ins_Form.Ins_Id = int.Parse(Ins_data[0].ToString());
                    Ins_Form.fname = Ins_data[1].ToString();
                    Ins_Form.lname = Ins_data[2].ToString();
                    Ins_Form.age = Ins_data[5].ToString();
                    Ins_Form.Dept_Id = int.Parse(Ins_data[3].ToString());
                    Hide();
                    Ins_Form.ShowDialog();
                    Close();
                }
            }
            catch
            {
                MessageBox.Show("not found");
            }

            sqlConnection1.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            CreateNewAccount registerform = new CreateNewAccount();
            registerform.ShowDialog();
            //this.Visible = false;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
