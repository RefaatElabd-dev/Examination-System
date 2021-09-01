
namespace Examination_System
{
    partial class UpdateTF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateTF));
            this.tfCombox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Question = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.txtQ = new Guna.UI2.WinForms.Guna2TextBox();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDegree = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // tfCombox
            // 
            this.tfCombox.BackColor = System.Drawing.Color.Transparent;
            this.tfCombox.BorderRadius = 10;
            this.tfCombox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.tfCombox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tfCombox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tfCombox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tfCombox.FocusedState.Parent = this.tfCombox;
            this.tfCombox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tfCombox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.tfCombox.HoverState.Parent = this.tfCombox;
            this.tfCombox.ItemHeight = 30;
            this.tfCombox.Items.AddRange(new object[] {
            "True",
            "False"});
            this.tfCombox.ItemsAppearance.Parent = this.tfCombox;
            this.tfCombox.Location = new System.Drawing.Point(373, 206);
            this.tfCombox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tfCombox.Name = "tfCombox";
            this.tfCombox.ShadowDecoration.Parent = this.tfCombox;
            this.tfCombox.Size = new System.Drawing.Size(140, 36);
            this.tfCombox.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label2.Location = new System.Drawing.Point(153, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 30);
            this.label2.TabIndex = 18;
            this.label2.Text = "Correct Answer";
            // 
            // Question
            // 
            this.Question.AutoSize = true;
            this.Question.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.Question.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Question.Location = new System.Drawing.Point(153, 106);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(120, 30);
            this.Question.TabIndex = 17;
            this.Question.Text = "Question";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(225, 306);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(180, 46);
            this.guna2Button1.TabIndex = 16;
            this.guna2Button1.Text = "Update";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
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
            this.txtQ.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQ.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQ.HoverState.Parent = this.txtQ;
            this.txtQ.Location = new System.Drawing.Point(305, 100);
            this.txtQ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQ.Name = "txtQ";
            this.txtQ.PasswordChar = '\0';
            this.txtQ.PlaceholderText = "";
            this.txtQ.SelectedText = "";
            this.txtQ.ShadowDecoration.Parent = this.txtQ;
            this.txtQ.Size = new System.Drawing.Size(372, 36);
            this.txtQ.TabIndex = 15;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.Connection = this.sqlConnection1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=.;Initial Catalog=Exam;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 10;
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.FillColor = System.Drawing.Color.Firebrick;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Location = new System.Drawing.Point(456, 306);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(180, 46);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label1.Location = new System.Drawing.Point(153, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 30);
            this.label1.TabIndex = 21;
            this.label1.Text = "Degree";
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
            this.txtDegree.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDegree.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDegree.HoverState.Parent = this.txtDegree;
            this.txtDegree.Location = new System.Drawing.Point(305, 144);
            this.txtDegree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDegree.Name = "txtDegree";
            this.txtDegree.PasswordChar = '\0';
            this.txtDegree.PlaceholderText = "";
            this.txtDegree.SelectedText = "";
            this.txtDegree.ShadowDecoration.Parent = this.txtDegree;
            this.txtDegree.Size = new System.Drawing.Size(372, 36);
            this.txtDegree.TabIndex = 20;
            // 
            // UpdateTF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tfCombox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.txtQ);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDegree);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UpdateTF";
            this.Text = "Update T/F quest";
            this.Load += new System.EventHandler(this.UpdateTF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox tfCombox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Question;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox txtQ;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtDegree;
    }
}