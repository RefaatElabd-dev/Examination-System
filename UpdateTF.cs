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
    public partial class UpdateTF : Form
    {
        public int Quest_Id;
        public int Crs_Id;
        public UpdateTF()
        {
            InitializeComponent();
        }

        private void UpdateTF_Load(object sender, EventArgs e)
        {
            Questions QForm = new Questions();
            MessageBox.Show(Quest_Id.ToString());
            sqlConnection1.Open();
            SqlCommand sqlcommand1 = new SqlCommand("selectQuest_Chooses", sqlConnection1);
            sqlcommand1.CommandType = CommandType.StoredProcedure;
            sqlcommand1.Parameters.AddWithValue("@Qid", Quest_Id);
            SqlDataReader dReadr = sqlcommand1.ExecuteReader();
            dReadr.Read();
            txtQ.Text = dReadr[1].ToString();
            tfCombox.SelectedItem = dReadr[6].ToString();
            txtDegree.Text = dReadr[3].ToString();
            dReadr.Close();
            sqlConnection1.Close();
        }


        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
        if (txtQ.Text == "" || txtDegree.Text == "" || tfCombox.SelectedItem == null)
        {
            MessageBox.Show("Please fill All fields");
        }
        else
        {

            try
            {

                sqlConnection1.Open();
                SqlCommand sqlcommand1 = new SqlCommand("updateQuestion", sqlConnection1);
                sqlcommand1.CommandType = CommandType.StoredProcedure;
                sqlcommand1.Parameters.AddWithValue("@Quest_Id", Quest_Id);
                sqlcommand1.Parameters.AddWithValue("@Quest_Content", txtQ.Text);
                sqlcommand1.Parameters.AddWithValue("@Ques_Type", "T/F");
                sqlcommand1.Parameters.AddWithValue("@correct_ans", tfCombox.SelectedItem.ToString());
                sqlcommand1.Parameters.AddWithValue("@Quest_Degree", txtDegree.Text);
                sqlcommand1.Parameters.AddWithValue("@Crs_Id", Crs_Id);
                sqlcommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                MessageBox.Show("Question is updated");
                txtQ.Text = txtDegree.Text = string.Empty;
                tfCombox.SelectedItem = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                    this.Close();
            }
        }
    }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                sqlConnection1.Open();
                SqlCommand sqlcommand1 = new SqlCommand("DeleteQeustion", sqlConnection1);
                sqlcommand1.CommandType = CommandType.StoredProcedure;
                sqlcommand1.Parameters.AddWithValue("@Qid", Quest_Id);
                sqlcommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                this.Close();
                MessageBox.Show("Question is Deleted");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Close();
        }

    }
}
