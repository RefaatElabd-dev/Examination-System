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
    public partial class cntInstructor : Form
    {
        public cntInstructor()
        {
            InitializeComponent();
        }
        private void ReloadCombBox()
        {
            comboBox1.Items.Clear();
            try
            {
                SqlCommand instructors = new SqlCommand("select Ins_Id from Instructor", sqlConnection1);
                SqlDataReader insData = instructors.ExecuteReader();
                while (insData.Read())
                {
                    comboBox1.Items.Add(insData[0].ToString());
                }
                insData.Close();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        private void cntInstructor_Load(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            ReloadCombBox();
            sqlConnection1.Close();
        }
        //delete
        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnection1.Open();

            SqlCommand DelCmd = new SqlCommand("deleteInstructor", sqlConnection1);
            DelCmd.CommandType = CommandType.StoredProcedure;
            try
            {
                DelCmd.Parameters.AddWithValue("@id", int.Parse(comboBox1.SelectedItem.ToString()));
                int x = 0;
                x = DelCmd.ExecuteNonQuery();
                comboBox1.Text = "";
                MessageBox.Show(x + " Row Affected");
                FNameTxt.Text = LNameTxt.Text = DeptTxt.Text = AgeTxt.Text = string.Empty;
                ReloadCombBox();
            }
            catch
            {
                MessageBox.Show("Error");
            }
            
            sqlConnection1.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sqlConnection1.Open();

            SqlCommand getCmd = new SqlCommand("getInstructorById", sqlConnection1);
            getCmd.CommandType = CommandType.StoredProcedure;

            try
            {
                getCmd.Parameters.AddWithValue("@id", int.Parse(comboBox1.SelectedItem.ToString()));
                SqlDataReader data = getCmd.ExecuteReader();
                data.Read();
                FNameTxt.Text = data[1].ToString();
                LNameTxt.Text = data[2].ToString();
                AgeTxt.Text = data[5].ToString();
                DeptTxt.Text = data[3].ToString();
                data.Close();
            }
            catch
            {
                MessageBox.Show("Error");
            }
            sqlConnection1.Close();

        }
        //edit instructor
        private void button3_Click(object sender, EventArgs e)
        {
            sqlConnection1.Open();

            SqlCommand getCmd = new SqlCommand("EditInstructor", sqlConnection1);
            getCmd.CommandType = CommandType.StoredProcedure;
            // MessageBox.Show(comboBox1.SelectedItem.ToString());
            try
            {
                int id = int.Parse(comboBox1.SelectedItem.ToString());
                getCmd.Parameters.AddWithValue("@id", id);
                getCmd.Parameters.AddWithValue("@Fname", FNameTxt.Text);
                getCmd.Parameters.AddWithValue("@Lname", LNameTxt.Text);
                getCmd.Parameters.AddWithValue("@Dept_id", int.Parse(DeptTxt.Text));
                getCmd.Parameters.AddWithValue("@age", AgeTxt.Text);
                int x = getCmd.ExecuteNonQuery();
                MessageBox.Show(x + "Row Affected");
                FNameTxt.Text = LNameTxt.Text = DeptTxt.Text = AgeTxt.Text = string.Empty;
            }
            catch
            {
                MessageBox.Show("Not found");
            }
            sqlConnection1.Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            CreateNewAccount registerform = new CreateNewAccount();
            registerform.position = "Instructor";
            registerform.ShowDialog();
        }
        //new




    }
}
