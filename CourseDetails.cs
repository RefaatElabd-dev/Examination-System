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
    public partial class CourseDetails : Form
    {

        public CourseDetails()
        {
            InitializeComponent();
        }

        public string ins_crs;
        public int inscrs_id;

        private void CourseDetails_Load(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            string sqlstr = "select c.Crs_Duration, t.Topic_Name, c.Crs_Name from Course c, Topic t where  c.Crs_Id = t.Crs_Id and c.Crs_Name = '" + ins_crs + "'";
            try
            {
                SqlCommand sqlcommand1 = new SqlCommand(sqlstr, sqlConnection1);
                SqlDataReader data = sqlcommand1.ExecuteReader();


                while (data.Read())
                {
                    guna2HtmlLabel2.Text = data[2].ToString();
                    guna2HtmlLabel5.Text = data[0].ToString();
                    TopicsList.Items.Add(data[1].ToString());
                }
                data.Close();
            }
            catch
            {
                MessageBox.Show("error not found crs name");
            }
            sqlConnection1.Close();
        }

        private void TopicsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Questions form = new Questions();
            form.ShowDialog();
        }
    }
}
