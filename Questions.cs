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
    public partial class Questions : Form
    {
        public Questions()
        {
            InitializeComponent();
        }



        AddMcqQ QF = new AddMcqQ();
        TFQ TF = new TFQ();
        int Crs_DataVeiw, QID;
        string crs = "";
        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            crs = guna2ComboBox1.SelectedItem.ToString();
            Rshow();
        }




        private void Addbtn_Click(object sender, EventArgs e)
        {
            string Ins_Courses = "select Crs_Name from Ins_course ";



            sqlCommand1.CommandText = Ins_Courses;
            sqlConnection1.Open();
            SqlDataReader dReadr = sqlCommand1.ExecuteReader();
            while (dReadr.Read())
            {
                guna2ComboBox1.Items.Add(dReadr[0]);



            }



            dReadr.Close();
            sqlConnection1.Close();





        }


        private void Questions_Load_1(object sender, EventArgs e)
        {
            QutionsGridView.ReadOnly = true;
            string Ins_Courses = "select Crs_Name from Course";
            sqlCommand1.CommandText = Ins_Courses;
            sqlConnection1.Open();
            SqlDataReader dReadr = sqlCommand1.ExecuteReader();
            while (dReadr.Read())
            {
                guna2ComboBox1.Items.Add(dReadr[0]);
            }



            dReadr.Close();
            sqlConnection1.Close();
        }



        private void QutionsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            QID = Convert.ToInt32(QutionsGridView.SelectedRows[0].Cells[0].Value);
            UpdateMCQ UpdateForm = new UpdateMCQ();
            UpdateTF UpTF = new UpdateTF();
            UpdateForm.Quest_Id = UpTF.Quest_Id = QID;
            UpdateForm.Crs_Id = UpTF.Crs_Id = Crs_DataVeiw;
            if (QutionsGridView.SelectedRows[0].Cells[2].Value.ToString() == "MCQ")
            {
                UpdateForm.ShowDialog();
            }
            else
            {
                UpTF.ShowDialog();
            }
            Rshow();
        }


        private void Rshow()
        {
            string Ins_Courses_id = "select Crs_Id from Course where Crs_Name='" + crs + "'";
            sqlCommand1.CommandText = Ins_Courses_id;
            sqlConnection1.Open();
            SqlDataReader dReadrId = sqlCommand1.ExecuteReader();
            dReadrId.Read();



            QF.Crs_id = TF.Crs_id = Crs_DataVeiw = int.Parse(dReadrId[0].ToString());
            dReadrId.Close();
            sqlConnection1.Close();
            DataTable dt = new DataTable();
            sqlConnection1.Open();
            try
            {
                SqlCommand sqlcommand1 = new SqlCommand("getAllQuest", sqlConnection1);
                sqlcommand1.CommandType = CommandType.StoredProcedure;
                sqlcommand1.Parameters.AddWithValue("@Cid", Crs_DataVeiw);
                SqlDataAdapter sdr = new SqlDataAdapter(sqlcommand1);



                sdr.Fill(dt);
                QutionsGridView.DataSource = dt;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            sqlConnection1.Close();
        }



        private void QuestComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (guna2ComboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please Select Course");
            }
            else
            {
                try
                {
                    if (QuestComboBox.SelectedItem.ToString() == "MCQ")
                    {
                        QF.ShowDialog();
                    }
                    else
                    {
                        TF.ShowDialog();
                    }
                    Rshow();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }




            }
        }



    }
}

