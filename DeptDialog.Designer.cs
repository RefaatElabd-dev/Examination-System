
namespace Examination_System
{
    partial class DeptDialog
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
            this.FndDept = new Guna.UI2.WinForms.Guna2Button();
            this.UpdateDept = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MangTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.LocTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.NameTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.IdTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.DeleteDept = new Guna.UI2.WinForms.Guna2Button();
            this.AddDept = new Guna.UI2.WinForms.Guna2Button();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // FndDept
            // 
            this.FndDept.BorderRadius = 10;
            this.FndDept.CheckedState.Parent = this.FndDept;
            this.FndDept.CustomImages.Parent = this.FndDept;
            this.FndDept.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FndDept.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FndDept.ForeColor = System.Drawing.Color.White;
            this.FndDept.HoverState.Parent = this.FndDept;
            this.FndDept.Location = new System.Drawing.Point(372, 386);
            this.FndDept.Margin = new System.Windows.Forms.Padding(4);
            this.FndDept.Name = "FndDept";
            this.FndDept.ShadowDecoration.Parent = this.FndDept;
            this.FndDept.Size = new System.Drawing.Size(231, 45);
            this.FndDept.TabIndex = 60;
            this.FndDept.Text = "Find Department";
            this.FndDept.Click += new System.EventHandler(this.FndDept_Click);
            // 
            // UpdateDept
            // 
            this.UpdateDept.BorderRadius = 10;
            this.UpdateDept.CheckedState.Parent = this.UpdateDept;
            this.UpdateDept.CustomImages.Parent = this.UpdateDept;
            this.UpdateDept.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.UpdateDept.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UpdateDept.ForeColor = System.Drawing.Color.White;
            this.UpdateDept.HoverState.Parent = this.UpdateDept;
            this.UpdateDept.Location = new System.Drawing.Point(118, 458);
            this.UpdateDept.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateDept.Name = "UpdateDept";
            this.UpdateDept.ShadowDecoration.Parent = this.UpdateDept;
            this.UpdateDept.Size = new System.Drawing.Size(231, 45);
            this.UpdateDept.TabIndex = 59;
            this.UpdateDept.Text = "Update Department";
            this.UpdateDept.Click += new System.EventHandler(this.UpdateDept_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(177, 285);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 23);
            this.label6.TabIndex = 58;
            this.label6.Text = "Manger_ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(177, 232);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 23);
            this.label3.TabIndex = 57;
            this.label3.Text = "Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(177, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 56;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(177, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 55;
            this.label1.Text = "Dept_Id";
            // 
            // MangTxtBox
            // 
            this.MangTxtBox.BorderRadius = 10;
            this.MangTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MangTxtBox.DefaultText = "";
            this.MangTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MangTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MangTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MangTxtBox.DisabledState.Parent = this.MangTxtBox;
            this.MangTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MangTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MangTxtBox.FocusedState.Parent = this.MangTxtBox;
            this.MangTxtBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MangTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MangTxtBox.HoverState.Parent = this.MangTxtBox;
            this.MangTxtBox.Location = new System.Drawing.Point(336, 285);
            this.MangTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.MangTxtBox.Name = "MangTxtBox";
            this.MangTxtBox.PasswordChar = '\0';
            this.MangTxtBox.PlaceholderText = "";
            this.MangTxtBox.SelectedText = "";
            this.MangTxtBox.ShadowDecoration.Parent = this.MangTxtBox;
            this.MangTxtBox.Size = new System.Drawing.Size(200, 30);
            this.MangTxtBox.TabIndex = 54;
            // 
            // LocTxtBox
            // 
            this.LocTxtBox.BorderRadius = 10;
            this.LocTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LocTxtBox.DefaultText = "";
            this.LocTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LocTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LocTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LocTxtBox.DisabledState.Parent = this.LocTxtBox;
            this.LocTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LocTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LocTxtBox.FocusedState.Parent = this.LocTxtBox;
            this.LocTxtBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LocTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LocTxtBox.HoverState.Parent = this.LocTxtBox;
            this.LocTxtBox.Location = new System.Drawing.Point(336, 232);
            this.LocTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.LocTxtBox.Name = "LocTxtBox";
            this.LocTxtBox.PasswordChar = '\0';
            this.LocTxtBox.PlaceholderText = "";
            this.LocTxtBox.SelectedText = "";
            this.LocTxtBox.ShadowDecoration.Parent = this.LocTxtBox;
            this.LocTxtBox.Size = new System.Drawing.Size(200, 30);
            this.LocTxtBox.TabIndex = 53;
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.BorderRadius = 10;
            this.NameTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameTxtBox.DefaultText = "";
            this.NameTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NameTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NameTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameTxtBox.DisabledState.Parent = this.NameTxtBox;
            this.NameTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameTxtBox.FocusedState.Parent = this.NameTxtBox;
            this.NameTxtBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NameTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameTxtBox.HoverState.Parent = this.NameTxtBox;
            this.NameTxtBox.Location = new System.Drawing.Point(336, 180);
            this.NameTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.PasswordChar = '\0';
            this.NameTxtBox.PlaceholderText = "";
            this.NameTxtBox.SelectedText = "";
            this.NameTxtBox.ShadowDecoration.Parent = this.NameTxtBox;
            this.NameTxtBox.Size = new System.Drawing.Size(200, 30);
            this.NameTxtBox.TabIndex = 52;
            // 
            // IdTxtBox
            // 
            this.IdTxtBox.BorderRadius = 10;
            this.IdTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IdTxtBox.DefaultText = "";
            this.IdTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.IdTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.IdTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IdTxtBox.DisabledState.Parent = this.IdTxtBox;
            this.IdTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IdTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IdTxtBox.FocusedState.Parent = this.IdTxtBox;
            this.IdTxtBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IdTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IdTxtBox.HoverState.Parent = this.IdTxtBox;
            this.IdTxtBox.Location = new System.Drawing.Point(336, 132);
            this.IdTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.IdTxtBox.Name = "IdTxtBox";
            this.IdTxtBox.PasswordChar = '\0';
            this.IdTxtBox.PlaceholderText = "";
            this.IdTxtBox.SelectedText = "";
            this.IdTxtBox.ShadowDecoration.Parent = this.IdTxtBox;
            this.IdTxtBox.Size = new System.Drawing.Size(200, 30);
            this.IdTxtBox.TabIndex = 51;
            // 
            // DeleteDept
            // 
            this.DeleteDept.BorderRadius = 10;
            this.DeleteDept.CheckedState.Parent = this.DeleteDept;
            this.DeleteDept.CustomImages.Parent = this.DeleteDept;
            this.DeleteDept.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DeleteDept.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DeleteDept.ForeColor = System.Drawing.Color.White;
            this.DeleteDept.HoverState.Parent = this.DeleteDept;
            this.DeleteDept.Location = new System.Drawing.Point(372, 458);
            this.DeleteDept.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteDept.Name = "DeleteDept";
            this.DeleteDept.ShadowDecoration.Parent = this.DeleteDept;
            this.DeleteDept.Size = new System.Drawing.Size(231, 45);
            this.DeleteDept.TabIndex = 50;
            this.DeleteDept.Text = "Delete Department";
            this.DeleteDept.Click += new System.EventHandler(this.DeleteDept_Click);
            // 
            // AddDept
            // 
            this.AddDept.BorderRadius = 10;
            this.AddDept.CheckedState.Parent = this.AddDept;
            this.AddDept.CustomImages.Parent = this.AddDept;
            this.AddDept.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.AddDept.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddDept.ForeColor = System.Drawing.Color.White;
            this.AddDept.HoverState.Parent = this.AddDept;
            this.AddDept.Location = new System.Drawing.Point(118, 386);
            this.AddDept.Margin = new System.Windows.Forms.Padding(4);
            this.AddDept.Name = "AddDept";
            this.AddDept.ShadowDecoration.Parent = this.AddDept;
            this.AddDept.Size = new System.Drawing.Size(231, 45);
            this.AddDept.TabIndex = 49;
            this.AddDept.Text = "Add Department";
            this.AddDept.Click += new System.EventHandler(this.AddDept_Click_1);
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=.;Initial Catalog=Exam;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(73, 56);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(258, 51);
            this.guna2HtmlLabel1.TabIndex = 61;
            this.guna2HtmlLabel1.Text = "Departments";
            // 
            // DeptDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(640, 616);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.FndDept);
            this.Controls.Add(this.UpdateDept);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MangTxtBox);
            this.Controls.Add(this.LocTxtBox);
            this.Controls.Add(this.NameTxtBox);
            this.Controls.Add(this.IdTxtBox);
            this.Controls.Add(this.DeleteDept);
            this.Controls.Add(this.AddDept);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DeptDialog";
            this.Text = "DeptDialog";
            this.Load += new System.EventHandler(this.DeptDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button FndDept;
        private Guna.UI2.WinForms.Guna2Button UpdateDept;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox MangTxtBox;
        private Guna.UI2.WinForms.Guna2TextBox LocTxtBox;
        private Guna.UI2.WinForms.Guna2TextBox NameTxtBox;
        private Guna.UI2.WinForms.Guna2TextBox IdTxtBox;
        private Guna.UI2.WinForms.Guna2Button DeleteDept;
        private Guna.UI2.WinForms.Guna2Button AddDept;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}