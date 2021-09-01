using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Examination_System
{
    public partial class DeptDialog : Form
    {
        public DeptDialog()
        {
            InitializeComponent();
        }

        private void FndDept_Click(object sender, EventArgs e)
        {
            if ((IdTxtBox.Text != "") && (IdTxtBox.Text).Trim().All(char.IsDigit))
            {
                sqlConnection1.Open();
                // get Department
                SqlCommand FindCmd = new SqlCommand("getDept", sqlConnection1);
                FindCmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    FindCmd.Parameters.AddWithValue("@id", int.Parse(IdTxtBox.Text.Trim()));
                    SqlDataReader data = FindCmd.ExecuteReader();
                    data.Read();
                    IdTxtBox.Text = data[0].ToString();
                    NameTxtBox.Text = data[1].ToString();
                    LocTxtBox.Text = data[2].ToString();
                    MangTxtBox.Text = data[3].ToString();
                    data.Close();
                }
                catch
                {
                    MessageBox.Show("not found");
                    Show();
                }
            }
            else
            {
                MessageBox.Show("Enter a Valid id", "Id Errors", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            sqlConnection1.Close();
        }

        private void AddDept_Click_1(object sender, EventArgs e)
        {
            if (NameTxtBox.Text == "")
            {
                MessageBox.Show("Enter a Valid Name", "Name Errors", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else if (LocTxtBox.Text == "")
            {
                MessageBox.Show("Enter a Valid Location", "Location Errors", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else if (MangTxtBox.Text == "" || !(MangTxtBox.Text.Trim().All(char.IsDigit)))
            {
                MessageBox.Show("Enter a Valid Manager Id", "Reference Errors", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                sqlConnection1.Open();
                // get Department
                SqlCommand InsertCmd = new SqlCommand("newdept", sqlConnection1);
                InsertCmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    InsertCmd.Parameters.AddWithValue("@name", NameTxtBox.Text);
                    InsertCmd.Parameters.AddWithValue("@location", LocTxtBox.Text);
                    InsertCmd.Parameters.AddWithValue("@manager", int.Parse(MangTxtBox.Text.Trim()));
                    SqlDataReader data = InsertCmd.ExecuteReader();
                    data.Read();
                    IdTxtBox.Text = data[0].ToString();
                    NameTxtBox.Text = data[1].ToString();
                    LocTxtBox.Text = data[2].ToString();
                    MangTxtBox.Text = data[3].ToString();
                    data.Close();
                }
                catch
                {
                    MessageBox.Show("not found");
                    Show();
                }
            }
            sqlConnection1.Close();
        }

        private void UpdateDept_Click(object sender, EventArgs e)
        {
            if (IdTxtBox.Text == "" || !(IdTxtBox.Text.Trim().All(char.IsDigit)))
            {
                MessageBox.Show("Enter a Id", "ID Errors", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (NameTxtBox.Text == "")
            {
                MessageBox.Show("Enter a Valid Name", "Name Errors", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else if (LocTxtBox.Text == "")
            {
                MessageBox.Show("Enter a Valid Location", "Location Errors", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else if (MangTxtBox.Text == "" || !(MangTxtBox.Text.Trim().All(char.IsDigit)))
            {
                MessageBox.Show("Enter a Valid Manager Id", "Reference Errors", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                sqlConnection1.Open();
                // get Department
                SqlCommand UpdateCmd = new SqlCommand("EditDepartment", sqlConnection1);
                UpdateCmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    UpdateCmd.Parameters.AddWithValue("@id", int.Parse(IdTxtBox.Text.Trim()));
                    UpdateCmd.Parameters.AddWithValue("@name", NameTxtBox.Text);
                    UpdateCmd.Parameters.AddWithValue("@location", LocTxtBox.Text);
                    UpdateCmd.Parameters.AddWithValue("@manager", int.Parse(MangTxtBox.Text.Trim()));
                    SqlDataReader data = UpdateCmd.ExecuteReader();
                    data.Read();
                    IdTxtBox.Text = data[0].ToString();
                    NameTxtBox.Text = data[1].ToString();
                    LocTxtBox.Text = data[2].ToString();
                    MangTxtBox.Text = data[3].ToString();
                    data.Close();
                    MessageBox.Show("Updated", "News", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch
                {
                    MessageBox.Show("not found");
                    Show();
                }
            }
            sqlConnection1.Close();
        }

        private void DeleteDept_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure you want to Delete that Department\nNote:All it's Student And Instructor Department Field Will be Null", "Risk", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                if ((IdTxtBox.Text != "") && (IdTxtBox.Text).Trim().All(char.IsDigit))
                {
                    sqlConnection1.Open();
                    // get Department
                    SqlCommand DeleteCmd = new SqlCommand("deleteDept", sqlConnection1);
                    DeleteCmd.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        DeleteCmd.Parameters.AddWithValue("@id", int.Parse(IdTxtBox.Text.Trim()));
                        SqlDataReader data = DeleteCmd.ExecuteReader();
                        data.Read();
                        data.Close();
                        IdTxtBox.Text = "";
                        NameTxtBox.Text = "";
                        LocTxtBox.Text = "";
                        MangTxtBox.Text = "";
                    }
                    catch
                    {
                        MessageBox.Show("not found");
                        Show();
                    }
                }
                else
                {
                    MessageBox.Show("Enter a Valid id", "Id Errors", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                sqlConnection1.Close();
            }
        }

        private void DeptDialog_Load(object sender, EventArgs e)
        {

        }

        
    }
}
