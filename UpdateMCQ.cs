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
    public partial class UpdateMCQ : Form
    {
        public int Quest_Id;
        public int Crs_Id;
        public UpdateMCQ()
        {
            InitializeComponent();
        }



        private void UpdateMCQ_Load(object sender, EventArgs e)
        {



            sqlConnection1.Open();
            SqlCommand sqlcommand1 = new SqlCommand("selectQuest_Chooses", sqlConnection1);
            sqlcommand1.CommandType = CommandType.StoredProcedure;
            sqlcommand1.Parameters.AddWithValue("@Qid", Quest_Id);
            SqlDataReader dReadr = sqlcommand1.ExecuteReader();
            dReadr.Read();
            txtQ.Text = dReadr[1].ToString();
            txtCh1.Text = dReadr[4].ToString();
            txtCh2.Text = dReadr[5].ToString();
            txtCh3.Text = dReadr[6].ToString();
            txtCorrectAns.Text = dReadr[7].ToString();
            txtDegree.Text = dReadr[3].ToString();
            dReadr.Close();
            sqlConnection1.Close();
        }



        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (txtQ.Text == "" || txtCh1.Text == "" || txtCh2.Text == "" || txtCh3.Text == "" || txtCorrectAns.Text == "" || txtDegree.Text == "")
            {
                MessageBox.Show("Please Fill All Filds");
            }
            else if (txtCorrectAns.Text == txtCh1.Text || txtCorrectAns.Text == txtCh2.Text || txtCorrectAns.Text == txtCh3.Text)
            {
                try
                {
                    sqlConnection1.Open();
                    SqlCommand sqlcommand1 = new SqlCommand("updateQuestion", sqlConnection1);
                    sqlcommand1.CommandType = CommandType.StoredProcedure;
                    sqlcommand1.Parameters.AddWithValue("@Quest_Id", Quest_Id);
                    sqlcommand1.Parameters.AddWithValue("@Quest_Content", txtQ.Text);
                    sqlcommand1.Parameters.AddWithValue("@Ques_Type", "MCQ");
                    sqlcommand1.Parameters.AddWithValue("@correct_ans", txtCorrectAns.Text);
                    sqlcommand1.Parameters.AddWithValue("@Quest_Degree", txtDegree.Text);
                    sqlcommand1.Parameters.AddWithValue("@Crs_Id", Crs_Id);
                    sqlcommand1.Parameters.AddWithValue("@Choice_Value1", txtCh1.Text);
                    sqlcommand1.Parameters.AddWithValue("@Choice_Value2", txtCh2.Text);
                    sqlcommand1.Parameters.AddWithValue("@Choice_Value3", txtCh3.Text);
                    sqlcommand1.ExecuteNonQuery();
                    sqlConnection1.Close();
                    txtQ.Text = txtCorrectAns.Text = txtDegree.Text = txtCh1.Text = txtCh2.Text = txtCh3.Text = string.Empty;
                    MessageBox.Show("Question is updated");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Update not valid");
            }

            Close();
        }



        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            try
            {
                SqlCommand sqlcommand1 = new SqlCommand("DeleteQeustion", sqlConnection1);
                sqlcommand1.CommandType = CommandType.StoredProcedure;
                sqlcommand1.Parameters.AddWithValue("@Qid", Quest_Id);
                sqlcommand1.ExecuteNonQuery();
                MessageBox.Show("Question is Deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection1.Close();
                this.Close();
            }

            Close();

        }



        private void txtCorrectAns_TextChanged(object sender, EventArgs e)
        {



        }
    }
}

