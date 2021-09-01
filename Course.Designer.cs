
namespace Examination_System
{
    partial class Course
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
            this.FndCrs = new Guna.UI2.WinForms.Guna2Button();
            this.UpdateCrs = new Guna.UI2.WinForms.Guna2Button();
            this.DeleteCrs = new Guna.UI2.WinForms.Guna2Button();
            this.AddCrs = new Guna.UI2.WinForms.Guna2Button();
            this.TopicLstBox = new System.Windows.Forms.ListBox();
            this.DurTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.NameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.IdBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.topicTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.button2 = new Guna.UI2.WinForms.Guna2Button();
            this.ClrTxt = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // FndCrs
            // 
            this.FndCrs.BorderRadius = 10;
            this.FndCrs.CheckedState.Parent = this.FndCrs;
            this.FndCrs.CustomImages.Parent = this.FndCrs;
            this.FndCrs.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FndCrs.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.FndCrs.ForeColor = System.Drawing.Color.White;
            this.FndCrs.HoverState.Parent = this.FndCrs;
            this.FndCrs.Location = new System.Drawing.Point(299, 560);
            this.FndCrs.Margin = new System.Windows.Forms.Padding(4);
            this.FndCrs.Name = "FndCrs";
            this.FndCrs.ShadowDecoration.Parent = this.FndCrs;
            this.FndCrs.Size = new System.Drawing.Size(130, 50);
            this.FndCrs.TabIndex = 67;
            this.FndCrs.Text = "Find Course";
            this.FndCrs.Click += new System.EventHandler(this.FndCrs_Click);
            // 
            // UpdateCrs
            // 
            this.UpdateCrs.BorderRadius = 10;
            this.UpdateCrs.CheckedState.Parent = this.UpdateCrs;
            this.UpdateCrs.CustomImages.Parent = this.UpdateCrs;
            this.UpdateCrs.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.UpdateCrs.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.UpdateCrs.ForeColor = System.Drawing.Color.White;
            this.UpdateCrs.HoverState.Parent = this.UpdateCrs;
            this.UpdateCrs.Location = new System.Drawing.Point(437, 560);
            this.UpdateCrs.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateCrs.Name = "UpdateCrs";
            this.UpdateCrs.ShadowDecoration.Parent = this.UpdateCrs;
            this.UpdateCrs.Size = new System.Drawing.Size(130, 50);
            this.UpdateCrs.TabIndex = 66;
            this.UpdateCrs.Text = "Update Course";
            this.UpdateCrs.Click += new System.EventHandler(this.UpdateCrs_Click);
            // 
            // DeleteCrs
            // 
            this.DeleteCrs.BorderRadius = 10;
            this.DeleteCrs.CheckedState.Parent = this.DeleteCrs;
            this.DeleteCrs.CustomImages.Parent = this.DeleteCrs;
            this.DeleteCrs.FillColor = System.Drawing.Color.Firebrick;
            this.DeleteCrs.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.DeleteCrs.ForeColor = System.Drawing.Color.White;
            this.DeleteCrs.HoverState.Parent = this.DeleteCrs;
            this.DeleteCrs.Location = new System.Drawing.Point(575, 560);
            this.DeleteCrs.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteCrs.Name = "DeleteCrs";
            this.DeleteCrs.ShadowDecoration.Parent = this.DeleteCrs;
            this.DeleteCrs.Size = new System.Drawing.Size(130, 50);
            this.DeleteCrs.TabIndex = 65;
            this.DeleteCrs.Text = "Delete Course";
            this.DeleteCrs.Click += new System.EventHandler(this.DeleteCrs_Click);
            // 
            // AddCrs
            // 
            this.AddCrs.BorderRadius = 10;
            this.AddCrs.CheckedState.Parent = this.AddCrs;
            this.AddCrs.CustomImages.Parent = this.AddCrs;
            this.AddCrs.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.AddCrs.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.AddCrs.ForeColor = System.Drawing.Color.White;
            this.AddCrs.HoverState.Parent = this.AddCrs;
            this.AddCrs.Location = new System.Drawing.Point(161, 560);
            this.AddCrs.Margin = new System.Windows.Forms.Padding(4);
            this.AddCrs.Name = "AddCrs";
            this.AddCrs.ShadowDecoration.Parent = this.AddCrs;
            this.AddCrs.Size = new System.Drawing.Size(130, 50);
            this.AddCrs.TabIndex = 64;
            this.AddCrs.Text = "Add Course";
            this.AddCrs.Click += new System.EventHandler(this.AddCrs_Click);
            // 
            // TopicLstBox
            // 
            this.TopicLstBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopicLstBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.TopicLstBox.FormattingEnabled = true;
            this.TopicLstBox.ItemHeight = 20;
            this.TopicLstBox.Location = new System.Drawing.Point(352, 373);
            this.TopicLstBox.Name = "TopicLstBox";
            this.TopicLstBox.Size = new System.Drawing.Size(200, 104);
            this.TopicLstBox.TabIndex = 63;
            // 
            // DurTxt
            // 
            this.DurTxt.BorderRadius = 10;
            this.DurTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DurTxt.DefaultText = "";
            this.DurTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DurTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DurTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DurTxt.DisabledState.Parent = this.DurTxt;
            this.DurTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DurTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DurTxt.FocusedState.Parent = this.DurTxt;
            this.DurTxt.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DurTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.DurTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DurTxt.HoverState.Parent = this.DurTxt;
            this.DurTxt.Location = new System.Drawing.Point(352, 261);
            this.DurTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DurTxt.Name = "DurTxt";
            this.DurTxt.PasswordChar = '\0';
            this.DurTxt.PlaceholderText = "";
            this.DurTxt.SelectedText = "";
            this.DurTxt.ShadowDecoration.Parent = this.DurTxt;
            this.DurTxt.Size = new System.Drawing.Size(200, 36);
            this.DurTxt.TabIndex = 57;
            this.DurTxt.TextChanged += new System.EventHandler(this.DurTxt_TextChanged);
            // 
            // NameTxt
            // 
            this.NameTxt.BorderRadius = 10;
            this.NameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameTxt.DefaultText = "";
            this.NameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameTxt.DisabledState.Parent = this.NameTxt;
            this.NameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameTxt.FocusedState.Parent = this.NameTxt;
            this.NameTxt.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.NameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameTxt.HoverState.Parent = this.NameTxt;
            this.NameTxt.Location = new System.Drawing.Point(352, 202);
            this.NameTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.PasswordChar = '\0';
            this.NameTxt.PlaceholderText = "";
            this.NameTxt.SelectedText = "";
            this.NameTxt.ShadowDecoration.Parent = this.NameTxt;
            this.NameTxt.Size = new System.Drawing.Size(200, 36);
            this.NameTxt.TabIndex = 56;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=.;Initial Catalog=Exam;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // IdBox
            // 
            this.IdBox.BackColor = System.Drawing.Color.Transparent;
            this.IdBox.BorderRadius = 10;
            this.IdBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.IdBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IdBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IdBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IdBox.FocusedState.Parent = this.IdBox;
            this.IdBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.IdBox.HoverState.Parent = this.IdBox;
            this.IdBox.ItemHeight = 30;
            this.IdBox.ItemsAppearance.Parent = this.IdBox;
            this.IdBox.Location = new System.Drawing.Point(352, 141);
            this.IdBox.Name = "IdBox";
            this.IdBox.ShadowDecoration.Parent = this.IdBox;
            this.IdBox.Size = new System.Drawing.Size(200, 36);
            this.IdBox.TabIndex = 72;
            // 
            // topicTxt
            // 
            this.topicTxt.BorderRadius = 10;
            this.topicTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.topicTxt.DefaultText = "";
            this.topicTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.topicTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.topicTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.topicTxt.DisabledState.Parent = this.topicTxt;
            this.topicTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.topicTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.topicTxt.FocusedState.Parent = this.topicTxt;
            this.topicTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.topicTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.topicTxt.HoverState.Parent = this.topicTxt;
            this.topicTxt.Location = new System.Drawing.Point(352, 322);
            this.topicTxt.Name = "topicTxt";
            this.topicTxt.PasswordChar = '\0';
            this.topicTxt.PlaceholderText = "";
            this.topicTxt.SelectedText = "";
            this.topicTxt.ShadowDecoration.Parent = this.topicTxt;
            this.topicTxt.Size = new System.Drawing.Size(200, 36);
            this.topicTxt.TabIndex = 73;
            // 
            // button2
            // 
            this.button2.CheckedState.Parent = this.button2;
            this.button2.CustomImages.Parent = this.button2;
            this.button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.HoverState.Parent = this.button2;
            this.button2.Location = new System.Drawing.Point(352, 474);
            this.button2.Name = "button2";
            this.button2.ShadowDecoration.Parent = this.button2;
            this.button2.Size = new System.Drawing.Size(200, 26);
            this.button2.TabIndex = 74;
            this.button2.Text = "C";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ClrTxt
            // 
            this.ClrTxt.BorderRadius = 10;
            this.ClrTxt.CheckedState.Parent = this.ClrTxt;
            this.ClrTxt.CustomImages.Parent = this.ClrTxt;
            this.ClrTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.ClrTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ClrTxt.ForeColor = System.Drawing.Color.White;
            this.ClrTxt.HoverState.Parent = this.ClrTxt;
            this.ClrTxt.Location = new System.Drawing.Point(160, 373);
            this.ClrTxt.Name = "ClrTxt";
            this.ClrTxt.ShadowDecoration.Parent = this.ClrTxt;
            this.ClrTxt.Size = new System.Drawing.Size(120, 35);
            this.ClrTxt.TabIndex = 75;
            this.ClrTxt.Text = "Clear";
            this.ClrTxt.Click += new System.EventHandler(this.ClrTxt_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(575, 322);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(120, 35);
            this.guna2Button1.TabIndex = 76;
            this.guna2Button1.Text = "Add";
            this.guna2Button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(163, 141);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(23, 25);
            this.guna2HtmlLabel4.TabIndex = 77;
            this.guna2HtmlLabel4.Text = "ID";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(161, 202);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(71, 25);
            this.guna2HtmlLabel5.TabIndex = 78;
            this.guna2HtmlLabel5.Text = "Course";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(161, 272);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(119, 25);
            this.guna2HtmlLabel6.TabIndex = 79;
            this.guna2HtmlLabel6.Text = "Credit hours";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(163, 322);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(54, 25);
            this.guna2HtmlLabel1.TabIndex = 80;
            this.guna2HtmlLabel1.Text = "Topic";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(136, 69);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(156, 51);
            this.guna2HtmlLabel2.TabIndex = 81;
            this.guna2HtmlLabel2.Text = "Courses";
            // 
            // Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(796, 616);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.ClrTxt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.topicTxt);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.FndCrs);
            this.Controls.Add(this.UpdateCrs);
            this.Controls.Add(this.DeleteCrs);
            this.Controls.Add(this.AddCrs);
            this.Controls.Add(this.TopicLstBox);
            this.Controls.Add(this.DurTxt);
            this.Controls.Add(this.NameTxt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Course";
            this.Text = "Course";
            this.Load += new System.EventHandler(this.Course_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button FndCrs;
        private Guna.UI2.WinForms.Guna2Button UpdateCrs;
        private Guna.UI2.WinForms.Guna2Button DeleteCrs;
        private Guna.UI2.WinForms.Guna2Button AddCrs;
        private System.Windows.Forms.ListBox TopicLstBox;
        private Guna.UI2.WinForms.Guna2TextBox DurTxt;
        private Guna.UI2.WinForms.Guna2TextBox NameTxt;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private Guna.UI2.WinForms.Guna2ComboBox IdBox;
        private Guna.UI2.WinForms.Guna2TextBox topicTxt;
        private Guna.UI2.WinForms.Guna2Button button2;
        private Guna.UI2.WinForms.Guna2Button ClrTxt;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
    }
}