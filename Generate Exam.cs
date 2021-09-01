using System;
using System.Collections;
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
    public partial class Generate_Exam : Form
    {
        public int std_Id = 0;
        public int number = 0;
        private int quick = 1800;
        public int Crs_Id;
        public string Crs_Name;
        int i = 0;
        int j = 0;
        string StudAnswer = "";
        int Current_QuestId;
        int Exam_id;
        List<string> questions = new List<string>();
        List<string> choose = new List<string>();
        List<string> chooseType = new List<string>();


        ArrayList newquest = new ArrayList();
        public Generate_Exam()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
        private void Generate_Exam_Load(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            SqlCommand sqlcommand1 = new SqlCommand("GenerateExam", sqlConnection1);
            sqlcommand1.CommandType = CommandType.StoredProcedure;
            sqlcommand1.Parameters.AddWithValue("@Crs_id", Crs_Id);
            sqlcommand1.Parameters.AddWithValue("@St_id", std_Id);
            sqlcommand1.Parameters.AddWithValue("@duration", 30);
            sqlcommand1.Parameters.AddWithValue("@desc", Crs_Name);
            SqlDataReader dreader;
            dreader = sqlcommand1.ExecuteReader();
            while (dreader.Read())
            {
                questions.Add(dreader[0].ToString());
                choose.Add(dreader[1].ToString());
                Exam_id = int.Parse(dreader[3].ToString());
                chooseType.Add(dreader[4].ToString());
            }
            dreader.Close();
            for (var q = 0; q < questions.Count - 1; q++)
            {
                if (questions[q] != questions[q + 1])
                {
                    newquest.Add(questions[q]);
                }
                else if (q == questions.Count - 2)
                {
                    newquest.Add(questions[q]);
                }
            }

            guna2HtmlLabel4.Text = newquest[i].ToString();
            showEx_choose();
            sqlConnection1.Close();
            if (i == 0)
            {
                guna2Button2.Enabled = false;
            }
            save();
            guna2HtmlLabel6.Text = (i + 1).ToString();
            guna2HtmlLabel5.Text = $" / {newquest.Count}";
        }
        public void save()
        {
            sqlConnection1.Open();
            string CurrentQuest = newquest[i].ToString();

            string GetQuestId = $"select Quest_Id " +
                                $"from Questions where Quest_Content = '{CurrentQuest}'";

            //sqlConnection1.Open();
            sqlCommand2.CommandText = GetQuestId;
            SqlDataReader dReader = sqlCommand2.ExecuteReader();
            dReader.Read();
            Current_QuestId = int.Parse(dReader[0].ToString());
            //MessageBox.Show(Current_QuestId.ToString());
            dReader.Close();
            //sqlConnection1.Close();

            string getAnswer = $"select Std_Ans from " +
                               $"Stud_Exam_Quest where Exam_Id = {Exam_id} " +
                               $"and Quest_Id = {Current_QuestId} and Std_Id = {std_Id}";

            sqlCommand2.CommandText = getAnswer;
            dReader = sqlCommand2.ExecuteReader();
            dReader.Read();
            string existingAns = dReader[0].ToString();

            if (existingAns == guna2HtmlLabel1.Text)
                guna2CustomRadioButton1.Checked = true;
            else if (existingAns == guna2HtmlLabel2.Text)
                guna2CustomRadioButton2.Checked = true;
            else if (existingAns == guna2HtmlLabel3.Text)
                guna2CustomRadioButton3.Checked = true;
            else if (existingAns == "no answer")
            {
                guna2CustomRadioButton1.Checked = false;
                guna2CustomRadioButton2.Checked = false;
                guna2CustomRadioButton3.Checked = false;
            }


            dReader.Close();

            sqlConnection1.Close();
        }

        public void showEx_choose()
        {
            if (chooseType[j] == "T/F")
            {
                guna2HtmlLabel3.Visible = false;
                guna2CustomRadioButton3.Visible = false;
            }
            else
            {
                guna2HtmlLabel3.Visible = true;
                guna2CustomRadioButton3.Visible = true;
            }
            guna2HtmlLabel1.Text = choose[j].ToString();
            guna2HtmlLabel2.Text = choose[j + 1].ToString();
            if (guna2HtmlLabel3.Visible == true) //salma
                guna2HtmlLabel3.Text = choose[j + 2].ToString();
        }
        void getQuestion()
        {
            string CurrentQuest = newquest[i].ToString();

            string GetQuestId = $"select Quest_Id " +
                                $"from Questions where Quest_Content = '{CurrentQuest}'";
            sqlConnection1.Open();
            sqlCommand2.CommandText = GetQuestId;
            SqlDataReader dReader = sqlCommand2.ExecuteReader();
            dReader.Read();
            Current_QuestId = int.Parse(dReader[0].ToString());
            //MessageBox.Show(Current_QuestId.ToString());
            dReader.Close();
            sqlConnection1.Close();
            if (guna2CustomRadioButton1.Checked)
                StudAnswer = guna2HtmlLabel1.Text;
            else if (guna2CustomRadioButton2.Checked)
                StudAnswer = guna2HtmlLabel2.Text;
            else if (guna2CustomRadioButton3.Checked)
                StudAnswer = guna2HtmlLabel3.Text;
            sqlConnection1.Open();
            SqlCommand sqlcommand1 = new SqlCommand("Student_answers", sqlConnection1);
            sqlcommand1.CommandType = CommandType.StoredProcedure;
            sqlcommand1.Parameters.AddWithValue("@ExamId", Exam_id);
            sqlcommand1.Parameters.AddWithValue("@Stu_Id", std_Id);
            sqlcommand1.Parameters.AddWithValue("@ques_Id", Current_QuestId);
            sqlcommand1.Parameters.AddWithValue("@answer", StudAnswer);
            sqlcommand1.ExecuteNonQuery();
            sqlConnection1.Close();
            guna2HtmlLabel5.Text = $" / {newquest.Count}";
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            getQuestion();
            StudAnswer = "";
            guna2Button2.Enabled = true;
            // guna2TextBox1.Text = i.ToString();
            if (i > newquest.Count - 2)
            {
                guna2Button1.Enabled = false;
            }
            else
            {
                if (chooseType[j] == "T/F")
                {
                    j += 2;
                }
                else
                {
                    j += 3;
                }
                i++;
                guna2HtmlLabel1.Text = guna2HtmlLabel2.Text = guna2HtmlLabel3.Text = guna2HtmlLabel4.Text = string.Empty;
                showEx_choose();
                guna2HtmlLabel4.Text = newquest[i].ToString();
                save();
            }
            guna2HtmlLabel6.Text = (i + 1).ToString();
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            getQuestion();
            StudAnswer = "";
            guna2Button1.Enabled = true;
            if (i == 0)
            {
                guna2Button2.Enabled = false;
            }
            else
            {
                if ((chooseType[j] == "T/F" && chooseType[j - 1] == "MCQ") || chooseType[j] == "MCQ")
                {
                    j -= 3;
                }
                else
                {
                    j -= 2;
                }
                i--;
                guna2HtmlLabel1.Text = guna2HtmlLabel2.Text = guna2HtmlLabel3.Text = guna2HtmlLabel4.Text = string.Empty;
                showEx_choose();
                guna2HtmlLabel4.Text = newquest[i].ToString();
                save();
            }
            guna2HtmlLabel6.Text = (i+1).ToString();

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to end the exam now?!", "End Exam", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                sqlConnection1.Open();
                SqlCommand correctioncommand = new SqlCommand("ExamCorrection", sqlConnection1);
                correctioncommand.CommandType = CommandType.StoredProcedure;
                correctioncommand.Parameters.AddWithValue("@Exam_Id", Exam_id);
                correctioncommand.Parameters.AddWithValue("@Std_Id", std_Id);
                correctioncommand.Parameters.AddWithValue("@Crs_Id", Crs_Id);
                correctioncommand.ExecuteNonQuery();
                sqlConnection1.Close();

                Student ins = new Student();
                ins.Exam_Id = Exam_id;
                ins.Std_Id = std_Id;
                ins.Crs_Id = Crs_Id;
                Hide();
                ins.ShowDialog();
                Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (guna2HtmlLabel7.Text == "0:00")
            {
                timer1.Stop();
                Student ins = new Student();
                Hide();
                ins.ShowDialog();
                Close();
            }
            else
            {
                quick--;
                guna2HtmlLabel7.Text = quick / 60 + ":" + ((quick % 60) >= 10 ? (quick % 60).ToString() : "0" + (quick % 60));
            }
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
