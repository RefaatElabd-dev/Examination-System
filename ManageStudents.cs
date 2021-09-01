using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_System
{
    public partial class ManageStudents : Form
    {
        int Student_Id;
        public ManageStudents()
        {
            InitializeComponent();
        }

        private void ManageStudents_Load(object sender, EventArgs e)
        {
            string GetStudents = @"select s.Std_Id as ""ID"", s.Std_Fname as ""Firstname"", s.Std_Lname as ""Lastname"", s.Std_Age as ""Age"", d.Dept_Name as ""Department"" " +
                                 @"from Student s inner join Department d " +
                                 @"on s.Dept_Id = d.Dept_Id";

            sqlCommand1.CommandText = GetStudents;
            sqlConnection1.Open();
            DataTable DT = new DataTable();
            DT.Load(sqlCommand1.ExecuteReader());
            guna2DataGridView1.DataSource = DT;
            sqlConnection1.Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            CreateNewAccount registerform = new CreateNewAccount();
            registerform.position = "Student";
            registerform.ShowDialog();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Student_Id = Convert.ToInt32(guna2DataGridView1.SelectedRows[0].Cells[0].Value);
            EditStudentinfo Form = new EditStudentinfo();
            Form.Std_Id = Student_Id;
            Form.Std_Fname = guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Form.Std_Lname = guna2DataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Form.Std_Age = Convert.ToInt32(guna2DataGridView1.SelectedRows[0].Cells[3].Value);
            Form.Std_Dept_Name = guna2DataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            Form.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ManageStudents_Load(null, EventArgs.Empty);
        }
    }
}
