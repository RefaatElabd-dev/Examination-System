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
    public partial class AddMcqQ : Form
    {
        public int Crs_id;
        public AddMcqQ()
        {
            InitializeComponent();
        }
        private void AddMcqQ_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            if (txtQuestion.Text == "" || txtop1.Text == "" || txtOp2.Text == "" || txtOp3.Text == "" || txtDegree.Text == "")
            {
                MessageBox.Show("Please Fill All Fileds");
                return;
            }

            try
            {
                sqlConnection1.Open();
                SqlCommand sqlcommand1 = new SqlCommand("insertQuest", sqlConnection1);
                sqlcommand1.CommandType = CommandType.StoredProcedure;
                sqlcommand1.Parameters.AddWithValue("@Quest_Content", txtQuestion.Text);
                sqlcommand1.Parameters.AddWithValue("@Ques_Type", "MCQ");
                sqlcommand1.Parameters.AddWithValue("@Quest_Degree", txtDegree.Text);
                sqlcommand1.Parameters.AddWithValue("@Crs_Id", Crs_id);
                sqlcommand1.Parameters.AddWithValue("@Choice_Value1", txtop1.Text);
                sqlcommand1.Parameters.AddWithValue("@Choice_Value2", txtOp2.Text);
                sqlcommand1.Parameters.AddWithValue("@Choice_Value3", txtOp3.Text);
                sqlcommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                txtQuestion.Text = txtop1.Text = txtOp2.Text = txtOp3.Text = txtDegree.Text = string.Empty;
                MessageBox.Show("Question is added");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Close();
        }

        private void txtOp2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOp3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
