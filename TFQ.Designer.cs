
namespace Examination_System
{
    partial class TFQ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TFQ));
            this.btnADD = new Guna.UI2.WinForms.Guna2Button();
            this.txtQust = new Guna.UI2.WinForms.Guna2TextBox();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtDegree = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tfCombox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnADD
            // 
            this.btnADD.BorderRadius = 10;
            this.btnADD.CheckedState.Parent = this.btnADD;
            this.btnADD.CustomImages.Parent = this.btnADD;
            this.btnADD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnADD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnADD.ForeColor = System.Drawing.Color.White;
            this.btnADD.HoverState.Parent = this.btnADD;
            this.btnADD.Location = new System.Drawing.Point(317, 357);
            this.btnADD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnADD.Name = "btnADD";
            this.btnADD.ShadowDecoration.Parent = this.btnADD;
            this.btnADD.Size = new System.Drawing.Size(202, 58);
            this.btnADD.TabIndex = 15;
            this.btnADD.Text = "ADD";
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click_1);
            // 
            // txtQust
            // 
            this.txtQust.BorderRadius = 10;
            this.txtQust.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQust.DefaultText = "";
            this.txtQust.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQust.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQust.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQust.DisabledState.Parent = this.txtQust;
            this.txtQust.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQust.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQust.FocusedState.Parent = this.txtQust;
            this.txtQust.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQust.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQust.HoverState.Parent = this.txtQust;
            this.txtQust.Location = new System.Drawing.Point(259, 124);
            this.txtQust.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQust.Name = "txtQust";
            this.txtQust.PasswordChar = '\0';
            this.txtQust.PlaceholderText = "Body of the question";
            this.txtQust.SelectedText = "";
            this.txtQust.ShadowDecoration.Parent = this.txtQust;
            this.txtQust.Size = new System.Drawing.Size(413, 35);
            this.txtQust.TabIndex = 14;
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
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(114, 124);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(121, 35);
            this.guna2HtmlLabel1.TabIndex = 18;
            this.guna2HtmlLabel1.Text = "Question";
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
            this.txtDegree.Location = new System.Drawing.Point(259, 215);
            this.txtDegree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDegree.Name = "txtDegree";
            this.txtDegree.PasswordChar = '\0';
            this.txtDegree.PlaceholderText = "e.g. 2";
            this.txtDegree.SelectedText = "";
            this.txtDegree.ShadowDecoration.Parent = this.txtDegree;
            this.txtDegree.Size = new System.Drawing.Size(413, 35);
            this.txtDegree.TabIndex = 17;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(114, 215);
            this.guna2HtmlLabel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(103, 35);
            this.guna2HtmlLabel5.TabIndex = 16;
            this.guna2HtmlLabel5.Text = "Degree";
            this.guna2HtmlLabel5.Click += new System.EventHandler(this.guna2HtmlLabel5_Click_1);
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
            this.tfCombox.Location = new System.Drawing.Point(332, 281);
            this.tfCombox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tfCombox.Name = "tfCombox";
            this.tfCombox.ShadowDecoration.Parent = this.tfCombox;
            this.tfCombox.Size = new System.Drawing.Size(140, 36);
            this.tfCombox.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label2.Location = new System.Drawing.Point(112, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 30);
            this.label2.TabIndex = 20;
            this.label2.Text = "correct Answer";
            // 
            // TFQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(795, 479);
            this.Controls.Add(this.tfCombox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.txtQust);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.txtDegree);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TFQ";
            this.Text = "TFQ";
            this.Load += new System.EventHandler(this.TFQ_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnADD;
        private Guna.UI2.WinForms.Guna2TextBox txtQust;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtDegree;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2ComboBox tfCombox;
        private System.Windows.Forms.Label label2;
    }
}