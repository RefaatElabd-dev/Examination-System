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
    public partial class TFQ : Form
    {
        public int Crs_id;
        public TFQ()
        {
            InitializeComponent();
        }

        private void TFQ_Load(object sender, EventArgs e)
        {

        }


        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void btnADD_Click_1(object sender, EventArgs e)
        {
            if (txtQust.Text == "" || txtDegree.Text == "")
            {
                MessageBox.Show("Please Fill All Fileds");
            }
            try
            {
                sqlConnection1.Open();
                SqlCommand sqlcommand1 = new SqlCommand("insertQuest", sqlConnection1);
                sqlcommand1.CommandType = CommandType.StoredProcedure;
                sqlcommand1.Parameters.AddWithValue("@Quest_Content", txtQust.Text);
                sqlcommand1.Parameters.AddWithValue("@Ques_Type", "T/F");
                sqlcommand1.Parameters.AddWithValue("@Quest_Degree", txtDegree.Text);
                sqlcommand1.Parameters.AddWithValue("@Crs_Id", Crs_id);
                if(tfCombox.SelectedItem.ToString() == "True")
                    sqlcommand1.Parameters.AddWithValue("@Choice_Value1", "False");
                else
                    sqlcommand1.Parameters.AddWithValue("@Choice_Value1", "True");
                sqlcommand1.Parameters.AddWithValue("@Choice_Value2",tfCombox.SelectedItem.ToString());
                sqlcommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                txtQust.Text = txtDegree.Text = string.Empty;
                MessageBox.Show("Question is added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Close();
        }

        private void guna2HtmlLabel5_Click_1(object sender, EventArgs e)
        {

        }
    }
}
