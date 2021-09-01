
namespace Examination_System
{
    partial class UpdateMCQ
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateMCQ));
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDegree = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCorrectAns = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCh3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCh2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCh1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtQ = new Guna.UI2.WinForms.Guna2TextBox();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderRadius = 10;
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Location = new System.Drawing.Point(188, 427);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(180, 46);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label6.Location = new System.Drawing.Point(130, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 30);
            this.label6.TabIndex = 25;
            this.label6.Text = "Degree";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label5.Location = new System.Drawing.Point(130, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 30);
            this.label5.TabIndex = 24;
            this.label5.Text = "Correct Ans.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label4.Location = new System.Drawing.Point(129, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 30);
            this.label4.TabIndex = 23;
            this.label4.Text = "Choice 3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label3.Location = new System.Drawing.Point(130, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 30);
            this.label3.TabIndex = 22;
            this.label3.Text = "Choice 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label2.Location = new System.Drawing.Point(130, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 30);
            this.label2.TabIndex = 21;
            this.label2.Text = "Choice 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label1.Location = new System.Drawing.Point(130, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 30);
            this.label1.TabIndex = 20;
            this.label1.Text = "Question";
            // 
            // txtDegree
            // 
            this.txtDegree.BorderRadius = 10;
            this.txtDegree.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDegree.DefaultText = "";
            this.txtDegree.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDegree.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDegree.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDegree.DisabledState.Parent = this.txtDegree;
            this.txtDegree.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDegree.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDegree.FocusedState.Parent = this.txtDegree;
            this.txtDegree.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDegree.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDegree.HoverState.Parent = this.txtDegree;
            this.txtDegree.Location = new System.Drawing.Point(302, 337);
            this.txtDegree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDegree.Name = "txtDegree";
            this.txtDegree.PasswordChar = '\0';
            this.txtDegree.PlaceholderText = "";
            this.txtDegree.SelectedText = "";
            this.txtDegree.ShadowDecoration.Parent = this.txtDegree;
            this.txtDegree.Size = new System.Drawing.Size(387, 36);
            this.txtDegree.TabIndex = 19;
            // 
            // txtCorrectAns
            // 
            this.txtCorrectAns.BorderRadius = 10;
            this.txtCorrectAns.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCorrectAns.DefaultText = "";
            this.txtCorrectAns.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCorrectAns.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCorrectAns.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCorrectAns.DisabledState.Parent = this.txtCorrectAns;
            this.txtCorrectAns.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCorrectAns.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCorrectAns.FocusedState.Parent = this.txtCorrectAns;
            this.txtCorrectAns.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorrectAns.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCorrectAns.HoverState.Parent = this.txtCorrectAns;
            this.txtCorrectAns.Location = new System.Drawing.Point(302, 279);
            this.txtCorrectAns.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorrectAns.Name = "txtCorrectAns";
            this.txtCorrectAns.PasswordChar = '\0';
            this.txtCorrectAns.PlaceholderText = "";
            this.txtCorrectAns.SelectedText = "";
            this.txtCorrectAns.ShadowDecoration.Parent = this.txtCorrectAns;
            this.txtCorrectAns.Size = new System.Drawing.Size(387, 36);
            this.txtCorrectAns.TabIndex = 18;
            // 
            // txtCh3
            // 
            this.txtCh3.BorderRadius = 10;
            this.txtCh3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCh3.DefaultText = "";
            this.txtCh3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCh3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCh3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCh3.DisabledState.Parent = this.txtCh3;
            this.txtCh3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCh3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCh3.FocusedState.Parent = this.txtCh3;
            this.txtCh3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCh3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCh3.HoverState.Parent = this.txtCh3;
            this.txtCh3.Location = new System.Drawing.Point(302, 221);
            this.txtCh3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCh3.Name = "txtCh3";
            this.txtCh3.PasswordChar = '\0';
            this.txtCh3.PlaceholderText = "";
            this.txtCh3.SelectedText = "";
            this.txtCh3.ShadowDecoration.Parent = this.txtCh3;
            this.txtCh3.Size = new System.Drawing.Size(387, 36);
            this.txtCh3.TabIndex = 17;
            // 
            // txtCh2
            // 
            this.txtCh2.BorderRadius = 10;
            this.txtCh2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCh2.DefaultText = "";
            this.txtCh2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCh2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCh2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCh2.DisabledState.Parent = this.txtCh2;
            this.txtCh2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCh2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCh2.FocusedState.Parent = this.txtCh2;
            this.txtCh2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCh2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCh2.HoverState.Parent = this.txtCh2;
            this.txtCh2.Location = new System.Drawing.Point(302, 164);
            this.txtCh2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCh2.Name = "txtCh2";
            this.txtCh2.PasswordChar = '\0';
            this.txtCh2.PlaceholderText = "";
            this.txtCh2.SelectedText = "";
            this.txtCh2.ShadowDecoration.Parent = this.txtCh2;
            this.txtCh2.Size = new System.Drawing.Size(387, 36);
            this.txtCh2.TabIndex = 16;
            // 
            // txtCh1
            // 
            this.txtCh1.BorderRadius = 10;
            this.txtCh1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCh1.DefaultText = "";
            this.txtCh1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCh1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCh1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCh1.DisabledState.Parent = this.txtCh1;
            this.txtCh1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCh1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCh1.FocusedState.Parent = this.txtCh1;
            this.txtCh1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCh1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCh1.HoverState.Parent = this.txtCh1;
            this.txtCh1.Location = new System.Drawing.Point(302, 106);
            this.txtCh1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCh1.Name = "txtCh1";
            this.txtCh1.PasswordChar = '\0';
            this.txtCh1.PlaceholderText = "";
            this.txtCh1.SelectedText = "";
            this.txtCh1.ShadowDecoration.Parent = this.txtCh1;
            this.txtCh1.Size = new System.Drawing.Size(387, 36);
            this.txtCh1.TabIndex = 15;
            // 
            // txtQ
            // 
            this.txtQ.BorderRadius = 10;
            this.txtQ.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQ.DefaultText = "";
            this.txtQ.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQ.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQ.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQ.DisabledState.Parent = this.txtQ;
            this.txtQ.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQ.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQ.FocusedState.Parent = this.txtQ;
            this.txtQ.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQ.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQ.HoverState.Parent = this.txtQ;
            this.txtQ.Location = new System.Drawing.Point(302, 47);
            this.txtQ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQ.Name = "txtQ";
            this.txtQ.PasswordChar = '\0';
            this.txtQ.PlaceholderText = "";
            this.txtQ.SelectedText = "";
            this.txtQ.ShadowDecoration.Parent = this.txtQ;
            this.txtQ.Size = new System.Drawing.Size(387, 36);
            this.txtQ.TabIndex = 14;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=.;Initial Catalog=Exam;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.Connection = this.sqlConnection1;
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 10;
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.FillColor = System.Drawing.Color.Firebrick;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Location = new System.Drawing.Point(443, 427);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(180, 46);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // UpdateMCQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDegree);
            this.Controls.Add(this.txtCorrectAns);
            this.Controls.Add(this.txtCh3);
            this.Controls.Add(this.txtCh2);
            this.Controls.Add(this.txtCh1);
            this.Controls.Add(this.txtQ);
            this.Controls.Add(this.btnDelete);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UpdateMCQ";
            this.Text = "Update MCQ";
            this.Load += new System.EventHandler(this.UpdateMCQ_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtDegree;
        private Guna.UI2.WinForms.Guna2TextBox txtCorrectAns;
        private Guna.UI2.WinForms.Guna2TextBox txtCh3;
        private Guna.UI2.WinForms.Guna2TextBox txtCh2;
        private Guna.UI2.WinForms.Guna2TextBox txtCh1;
        private Guna.UI2.WinForms.Guna2TextBox txtQ;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
    }
}