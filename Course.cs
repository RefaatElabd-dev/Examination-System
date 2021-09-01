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
    public partial class Course : Form
    {
        public Course()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TopicLstBox.Items.Clear();
        }

        private void AddCrs_Click(object sender, EventArgs e)
        {
            if (guna2HtmlLabel1.Visible == true && IdBox.Visible == true)
            {
                guna2HtmlLabel1.Visible = false;
                IdBox.Visible = false;
            }
            else
            {
                if (NameTxt.Text == "")
                {
                    MessageBox.Show("Enter a Valid Name", "Name Errors", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else if (DurTxt.Text == "" && (DurTxt.Text).Trim().All(char.IsDigit))
                {
                    MessageBox.Show("Enter a Valid Duration", "Duration Errors", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else
                {
                    sqlConnection1.Open();
                    // get Department
                    SqlCommand InsertCmd = new SqlCommand("newCourse", sqlConnection1);
                    InsertCmd.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        InsertCmd.Parameters.AddWithValue("@name", NameTxt.Text);
                        InsertCmd.Parameters.AddWithValue("@duration", DurTxt.Text);
                        SqlDataReader data = InsertCmd.ExecuteReader();
                        data.Read();
                        int CrID = int.Parse(data[0].ToString());
                        NameTxt.Text = data[1].ToString();
                        DurTxt.Text = data[2].ToString();
                        data.Close();
                        SqlCommand InsertTopics = new SqlCommand("NewTopic", sqlConnection1);
                        InsertTopics.CommandType = CommandType.StoredProcedure;
                        int x = 0;
                        foreach (string s in TopicLstBox.Items)
                        {
                            InsertTopics.Parameters.AddWithValue("@name", s.ToString());
                            InsertTopics.Parameters.AddWithValue("@crs_id", CrID);
                            x += InsertTopics.ExecuteNonQuery();
                            InsertTopics.Parameters.Clear();
                        }
                        NameTxt.Text = DurTxt.Text = string.Empty;
                        TopicLstBox.Items.Clear();
                        MessageBox.Show("Course  is Added");
                    }
                    catch
                    {
                        MessageBox.Show("Course id Not Found");
                        Show();
                    }
                }
                IDs();
                sqlConnection1.Close();
            }

        }

        private void FndCrs_Click(object sender, EventArgs e)
        {
            if (guna2HtmlLabel4.Visible == false && IdBox.Visible == false)
            {
                guna2HtmlLabel4.Visible = true;
                IdBox.Visible = true;
                sqlConnection1.Open();
                IDs();
                sqlConnection1.Close();
            }
            else
            {
                if ((IdBox.SelectedItem.ToString() != "") && IdBox.SelectedItem.ToString().Trim().All(char.IsDigit))
                {
                    sqlConnection1.Open();
                    // get Department
                    SqlCommand FindCmd = new SqlCommand("getCourse", sqlConnection1);
                    FindCmd.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        FindCmd.Parameters.AddWithValue("@id", int.Parse(IdBox.SelectedItem.ToString().Trim()));
                        SqlDataReader data = FindCmd.ExecuteReader();
                        data.Read();
                        int id = int.Parse(data[0].ToString());
                        NameTxt.Text = data[1].ToString();
                        DurTxt.Text = data[2].ToString();
                        data.Close();
                        SqlCommand FindTopicCmd = new SqlCommand("getTopicOfCourse", sqlConnection1);
                        FindTopicCmd.CommandType = CommandType.StoredProcedure;
                        FindTopicCmd.Parameters.AddWithValue("@crs_id", id);
                        TopicLstBox.Items.Clear();
                        SqlDataReader topics = FindTopicCmd.ExecuteReader();
                        while (topics.Read())
                        {
                            TopicLstBox.Items.Add(topics[0].ToString());
                        }
                        topics.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Course  is Not Found");
                        Show();
                    }
                }
                else
                {
                    MessageBox.Show("Enter a Valid id", "Id Errors", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                sqlConnection1.Close();
            }

        }

        private void UpdateCrs_Click(object sender, EventArgs e)
        {

            if (guna2HtmlLabel1.Visible == false && IdBox.Visible == false)
            {
                NameTxt.Text = DurTxt.Text = string.Empty;
                guna2HtmlLabel1.Visible = true;
                IdBox.Visible = true;
                sqlConnection1.Open();
                IDs();
                sqlConnection1.Close();
            }
            else
            {
                if ((IdBox.SelectedItem.ToString() == "") || !IdBox.SelectedItem.ToString().Trim().All(char.IsDigit))
                {
                    MessageBox.Show("Enter a Valid Id", "Id Errors", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else if (NameTxt.Text == "")
                {
                    MessageBox.Show("Enter a Valid Name", "Name Errors", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else if (DurTxt.Text == "" && (DurTxt.Text).Trim().All(char.IsDigit))
                {
                    MessageBox.Show("Enter a Valid Duration", "Duration Errors", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else
                {
                    sqlConnection1.Open();
                    // get Department
                    SqlCommand updateCmd = new SqlCommand("EditCourse", sqlConnection1);
                    updateCmd.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        updateCmd.Parameters.AddWithValue("@id", IdBox.SelectedItem.ToString());
                        updateCmd.Parameters.AddWithValue("@name", NameTxt.Text);
                        updateCmd.Parameters.AddWithValue("@duration", DurTxt.Text);
                        int x = 0;
                        x = updateCmd.ExecuteNonQuery();

                        SqlCommand deleteTopics = new SqlCommand("deleteTopicOfCourse", sqlConnection1);
                        deleteTopics.CommandType = CommandType.StoredProcedure;
                        deleteTopics.Parameters.AddWithValue("@id", int.Parse(IdBox.SelectedItem.ToString().Trim()));
                        x += deleteTopics.ExecuteNonQuery();

                        SqlCommand InsertTopics = new SqlCommand("NewTopic", sqlConnection1);
                        InsertTopics.CommandType = CommandType.StoredProcedure;
                        foreach (string s in TopicLstBox.Items)
                        {
                            InsertTopics.Parameters.AddWithValue("@name", s.ToString());
                            InsertTopics.Parameters.AddWithValue("@crs_id", IdBox.SelectedItem.ToString());
                            x += InsertTopics.ExecuteNonQuery();
                            InsertTopics.Parameters.Clear();
                        }
                        IdBox.Text = NameTxt.Text = DurTxt.Text = string.Empty;
                        TopicLstBox.Items.Clear();
                        MessageBox.Show("Course  is Updated");
                    }
                    catch
                    {
                        MessageBox.Show("Course  is Not Found");
                        Show();
                    }
                }
                sqlConnection1.Close();
            }

        }

        private void DeleteCrs_Click(object sender, EventArgs e)
        {
            if (guna2HtmlLabel1.Visible == false && IdBox.Visible == false)
            {
                guna2HtmlLabel1.Visible = true;
                IdBox.Visible = true;
            }
            else
            {
                if (MessageBox.Show("Do you delete course", "Delete Course", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    if ((IdBox.SelectedItem.ToString() != "") && (IdBox.SelectedItem.ToString()).Trim().All(char.IsDigit))
                    {
                        sqlConnection1.Open();
                        // get Department
                        SqlCommand DelCmd = new SqlCommand("deleteCourse", sqlConnection1);
                        DelCmd.CommandType = CommandType.StoredProcedure;
                        int x = 0;
                        try
                        {
                            int id = int.Parse(IdBox.SelectedItem.ToString().Trim());
                            DelCmd.Parameters.AddWithValue("@id", id);
                            SqlCommand DelTopicCmd = new SqlCommand("deleteTopicOfCourse", sqlConnection1);
                            DelTopicCmd.CommandType = CommandType.StoredProcedure;
                            DelTopicCmd.Parameters.AddWithValue("@id", id);
                            x += DelTopicCmd.ExecuteNonQuery();
                            x += DelCmd.ExecuteNonQuery();
                            TopicLstBox.Items.Clear();
                            IdBox.Text = NameTxt.Text = DurTxt.Text = string.Empty;
                            MessageBox.Show("Course is Deleted");
                        }
                        catch
                        {
                            MessageBox.Show("Course  is Not Found");
                            Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter a Valid id", "Id Errors", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }
                    IDs();
                    sqlConnection1.Close();
                }
            }
        }

        private void ClrTxt_Click(object sender, EventArgs e)
        {
            IdBox.Text = NameTxt.Text = DurTxt.Text = topicTxt.Text = "";
            TopicLstBox.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (topicTxt.Text.Trim() != "")
                TopicLstBox.Items.Add(topicTxt.Text);
            topicTxt.Text = "";
        }

        private void Course_Load(object sender, EventArgs e)
        {
            guna2HtmlLabel4.Visible = false;
            IdBox.Visible = false;
            sqlConnection1.Open();
            IDs();
            sqlConnection1.Close();

        }
        private void IDs()
        {
            IdBox.Items.Clear();
            string strID = "select Crs_Id from Course";

            SqlCommand select = new SqlCommand(strID, sqlConnection1);
            SqlDataReader dr = select.ExecuteReader();
            while (dr.Read())
            {
                IdBox.Items.Add(dr[0].ToString());
            }
            dr.Close();

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void DurTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
