using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_System
{
    public partial class instructorCourse : Form
    {
        public instructorCourse()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            try
            {
                SqlCommand insertcmd = new SqlCommand("newIns_Course", sqlConnection1);
                insertcmd.CommandType = CommandType.StoredProcedure;

                SqlCommand crsidd = new SqlCommand("select Crs_Id from Course where Crs_Name ='" + CrsIdComboBox.SelectedItem.ToString() + "'", sqlConnection1);
                SqlDataReader crss = crsidd.ExecuteReader();
                crss.Read();

                insertcmd.Parameters.AddWithValue("@ins_id", int.Parse(insIdComboBox.SelectedItem.ToString()));
                insertcmd.Parameters.AddWithValue("@crs_id", int.Parse(crss[0].ToString()));
                crss.Close();
                int x = 0;
                x=insertcmd.ExecuteNonQuery();
                if (x == -1)
                    MessageBox.Show("No Row Affected");
                else
                    MessageBox.Show(x + " Row Affected");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnection1.Close();
        }

        private void instructorCourse_Load(object sender, EventArgs e)
        {
            sqlConnection1.Open();

            SqlCommand instructors = new SqlCommand("select Ins_Id from Instructor", sqlConnection1);
            SqlDataReader insData = instructors.ExecuteReader();
            while (insData.Read())
            {
                insIdComboBox.Items.Add(insData[0].ToString());
            }
            insData.Close();

            SqlCommand Courses = new SqlCommand("select Crs_Name from Course", sqlConnection1);
            SqlDataReader CrsData = Courses.ExecuteReader();
            while (CrsData.Read())
            {
                CrsIdComboBox.Items.Add(CrsData[0].ToString());
            }
            CrsData.Close();

            sqlConnection1.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sqlConnection1.Open();

            SqlCommand DelCmd = new SqlCommand("deletebuINscourse", sqlConnection1);
            DelCmd.CommandType = CommandType.StoredProcedure;
            try
            {
                DelCmd.Parameters.AddWithValue("@ins_id", int.Parse(insIdComboBox.SelectedItem.ToString()));

                SqlCommand Del = new SqlCommand("select Crs_Id from Course where Crs_Name ='" + CrsIdComboBox.SelectedItem.ToString() + "'", sqlConnection1);
                SqlDataReader crss = Del.ExecuteReader();
                crss.Read();
                DelCmd.Parameters.AddWithValue("@crs_id", int.Parse(crss[0].ToString()));
                crss.Close();

                int x = 0;
                x = DelCmd.ExecuteNonQuery();

                if (x == -1)
                    MessageBox.Show("No Row Affected");
                else
                    MessageBox.Show(x + " Row Affected");
            }
            catch
            {
                MessageBox.Show("error here");
            }
            sqlConnection1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            try
            {
                SqlCommand updateCmd = new SqlCommand("updateinsid", sqlConnection1);
                updateCmd.CommandType = CommandType.StoredProcedure;
                updateCmd.Parameters.AddWithValue("@ins_id ", int.Parse(insIdComboBox.SelectedItem.ToString()));

                SqlCommand UP = new SqlCommand("select Crs_Id from Course where Crs_Name ='" + CrsIdComboBox.SelectedItem.ToString() + "'", sqlConnection1);
                SqlDataReader crss2 = UP.ExecuteReader();
                crss2.Read();
                updateCmd.Parameters.AddWithValue("@Crs_id ", int.Parse(crss2[0].ToString()));
                crss2.Close();
                updateCmd.Parameters.AddWithValue("@Newins_id ", int.Parse(textBox2.Text));

                SqlCommand udp = new SqlCommand("select Crs_Id from Course where Crs_Name ='" + textBox1.Text.ToString() + "'", sqlConnection1);
                SqlDataReader crss1 = udp.ExecuteReader();
                crss1.Read();
                updateCmd.Parameters.AddWithValue("@Newcrs_id ", int.Parse(crss1[0].ToString()));
                crss1.Close();
                int y = 0;
                y = updateCmd.ExecuteNonQuery();
                if (y == -1)
                    MessageBox.Show("No Row Affected");
                else
                    MessageBox.Show(y + " Row Affected");
            }
            catch
            {
                MessageBox.Show("error here");
            }
            sqlConnection1.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
