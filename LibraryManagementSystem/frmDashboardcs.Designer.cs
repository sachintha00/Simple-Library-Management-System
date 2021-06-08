namespace LibraryManagementSystem
{
    partial class frmDashboardcs
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.lblAllBook = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel5 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.lblAllStudent = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.lblReturnBook = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.dgvReturnBook = new Guna.UI.WinForms.GunaDataGridView();
            this.Member_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Issue_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Return_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaPanel6 = new Guna.UI.WinForms.GunaPanel();
            this.lblStaff = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.gunaPanel2.SuspendLayout();
            this.gunaPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnBook)).BeginInit();
            this.gunaPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(99)))), ((int)(((byte)(124)))));
            this.gunaPanel1.Controls.Add(this.lblAllBook);
            this.gunaPanel1.Controls.Add(this.gunaLabel5);
            this.gunaPanel1.Location = new System.Drawing.Point(33, 231);
            this.gunaPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(293, 158);
            this.gunaPanel1.TabIndex = 0;
            // 
            // lblAllBook
            // 
            this.lblAllBook.AutoSize = true;
            this.lblAllBook.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lblAllBook.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblAllBook.Location = new System.Drawing.Point(28, 89);
            this.lblAllBook.Name = "lblAllBook";
            this.lblAllBook.Size = new System.Drawing.Size(28, 35);
            this.lblAllBook.TabIndex = 0;
            this.lblAllBook.Text = "0";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.gunaLabel5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gunaLabel5.Location = new System.Drawing.Point(17, 33);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(145, 40);
            this.gunaLabel5.TabIndex = 0;
            this.gunaLabel5.Text = "All Books";
            // 
            // gunaPanel5
            // 
            this.gunaPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(101)))), ((int)(((byte)(137)))));
            this.gunaPanel5.Controls.Add(this.gunaLabel2);
            this.gunaPanel5.Controls.Add(this.gunaLabel1);
            this.gunaPanel5.Controls.Add(this.gunaPictureBox1);
            this.gunaPanel5.Location = new System.Drawing.Point(33, 33);
            this.gunaPanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaPanel5.Name = "gunaPanel5";
            this.gunaPanel5.Size = new System.Drawing.Size(731, 158);
            this.gunaPanel5.TabIndex = 0;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gunaLabel2.Location = new System.Drawing.Point(25, 63);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(461, 60);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. \r\nTenetur numquam recusa" +
    "ndae, iste pariatur porro vel corrupti fugiat \r\nillum officiis quae.";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gunaLabel1.Location = new System.Drawing.Point(21, 27);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(394, 30);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Welcome to Your Cean of Knowledge";
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaPictureBox1.Image = global::LibraryManagementSystem.Properties.Resources.dash;
            this.gunaPictureBox1.Location = new System.Drawing.Point(543, 0);
            this.gunaPictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(188, 158);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(121)))), ((int)(((byte)(102)))));
            this.gunaPanel2.Controls.Add(this.lblAllStudent);
            this.gunaPanel2.Controls.Add(this.gunaLabel7);
            this.gunaPanel2.Location = new System.Drawing.Point(363, 231);
            this.gunaPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(293, 158);
            this.gunaPanel2.TabIndex = 0;
            // 
            // lblAllStudent
            // 
            this.lblAllStudent.AutoSize = true;
            this.lblAllStudent.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lblAllStudent.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblAllStudent.Location = new System.Drawing.Point(27, 89);
            this.lblAllStudent.Name = "lblAllStudent";
            this.lblAllStudent.Size = new System.Drawing.Size(28, 35);
            this.lblAllStudent.TabIndex = 0;
            this.lblAllStudent.Text = "0";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.gunaLabel7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gunaLabel7.Location = new System.Drawing.Point(16, 33);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(181, 40);
            this.gunaLabel7.TabIndex = 0;
            this.gunaLabel7.Text = "All Students";
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(180)))), ((int)(((byte)(92)))));
            this.gunaPanel3.Controls.Add(this.lblReturnBook);
            this.gunaPanel3.Controls.Add(this.gunaLabel9);
            this.gunaPanel3.Location = new System.Drawing.Point(691, 231);
            this.gunaPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(293, 158);
            this.gunaPanel3.TabIndex = 0;
            // 
            // lblReturnBook
            // 
            this.lblReturnBook.AutoSize = true;
            this.lblReturnBook.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lblReturnBook.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblReturnBook.Location = new System.Drawing.Point(35, 89);
            this.lblReturnBook.Name = "lblReturnBook";
            this.lblReturnBook.Size = new System.Drawing.Size(28, 35);
            this.lblReturnBook.TabIndex = 0;
            this.lblReturnBook.Text = "0";
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.gunaLabel9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gunaLabel9.Location = new System.Drawing.Point(24, 33);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(202, 40);
            this.gunaLabel9.TabIndex = 0;
            this.gunaLabel9.Text = "Return Books";
            // 
            // dgvReturnBook
            // 
            this.dgvReturnBook.AllowUserToAddRows = false;
            this.dgvReturnBook.AllowUserToDeleteRows = false;
            this.dgvReturnBook.AllowUserToResizeColumns = false;
            this.dgvReturnBook.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.dgvReturnBook.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReturnBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvReturnBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReturnBook.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.dgvReturnBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReturnBook.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReturnBook.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(101)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(122)))), ((int)(((byte)(176)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReturnBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReturnBook.ColumnHeadersHeight = 52;
            this.dgvReturnBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Member_name,
            this.Book_Name,
            this.Issue_Date,
            this.Return_Date});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(150)))), ((int)(((byte)(174)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(181)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReturnBook.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReturnBook.EnableHeadersVisualStyles = false;
            this.dgvReturnBook.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(98)))), ((int)(((byte)(134)))));
            this.dgvReturnBook.Location = new System.Drawing.Point(33, 448);
            this.dgvReturnBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvReturnBook.Name = "dgvReturnBook";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReturnBook.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReturnBook.RowHeadersVisible = false;
            this.dgvReturnBook.RowHeadersWidth = 51;
            this.dgvReturnBook.RowTemplate.Height = 24;
            this.dgvReturnBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReturnBook.Size = new System.Drawing.Size(719, 343);
            this.dgvReturnBook.TabIndex = 4;
            this.dgvReturnBook.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Teal;
            this.dgvReturnBook.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.dgvReturnBook.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvReturnBook.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvReturnBook.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvReturnBook.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvReturnBook.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.dgvReturnBook.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(98)))), ((int)(((byte)(134)))));
            this.dgvReturnBook.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(101)))), ((int)(((byte)(137)))));
            this.dgvReturnBook.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvReturnBook.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvReturnBook.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvReturnBook.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvReturnBook.ThemeStyle.HeaderStyle.Height = 52;
            this.dgvReturnBook.ThemeStyle.ReadOnly = false;
            this.dgvReturnBook.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(150)))), ((int)(((byte)(174)))));
            this.dgvReturnBook.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReturnBook.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvReturnBook.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvReturnBook.ThemeStyle.RowsStyle.Height = 24;
            this.dgvReturnBook.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(181)))), ((int)(((byte)(189)))));
            this.dgvReturnBook.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // Member_name
            // 
            this.Member_name.DataPropertyName = "Member_name";
            this.Member_name.HeaderText = "Student Name";
            this.Member_name.MinimumWidth = 6;
            this.Member_name.Name = "Member_name";
            // 
            // Book_Name
            // 
            this.Book_Name.DataPropertyName = "Book_Name";
            this.Book_Name.HeaderText = "Book Name";
            this.Book_Name.MinimumWidth = 6;
            this.Book_Name.Name = "Book_Name";
            // 
            // Issue_Date
            // 
            this.Issue_Date.DataPropertyName = "Issue_Date";
            this.Issue_Date.HeaderText = "Issue Date";
            this.Issue_Date.MinimumWidth = 6;
            this.Issue_Date.Name = "Issue_Date";
            // 
            // Return_Date
            // 
            this.Return_Date.DataPropertyName = "Return_Date";
            this.Return_Date.HeaderText = "Return Date";
            this.Return_Date.MinimumWidth = 6;
            this.Return_Date.Name = "Return_Date";
            // 
            // gunaPanel6
            // 
            this.gunaPanel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(100)))), ((int)(((byte)(145)))));
            this.gunaPanel6.Controls.Add(this.lblStaff);
            this.gunaPanel6.Controls.Add(this.gunaLabel3);
            this.gunaPanel6.Location = new System.Drawing.Point(793, 33);
            this.gunaPanel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaPanel6.Name = "gunaPanel6";
            this.gunaPanel6.Size = new System.Drawing.Size(293, 158);
            this.gunaPanel6.TabIndex = 0;
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lblStaff.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblStaff.Location = new System.Drawing.Point(32, 82);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(28, 35);
            this.lblStaff.TabIndex = 0;
            this.lblStaff.Text = "0";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gunaLabel3.Location = new System.Drawing.Point(21, 27);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(125, 40);
            this.gunaLabel3.TabIndex = 0;
            this.gunaLabel3.Text = "All Staff";
            // 
            // frmDashboardcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 813);
            this.Controls.Add(this.dgvReturnBook);
            this.Controls.Add(this.gunaPanel5);
            this.Controls.Add(this.gunaPanel3);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaPanel6);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDashboardcs";
            this.Text = "frmDashboardcs";
            this.Load += new System.EventHandler(this.frmDashboardcs_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaPanel5.ResumeLayout(false);
            this.gunaPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel2.PerformLayout();
            this.gunaPanel3.ResumeLayout(false);
            this.gunaPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnBook)).EndInit();
            this.gunaPanel6.ResumeLayout(false);
            this.gunaPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel5;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaDataGridView dgvReturnBook;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaPanel gunaPanel6;
        private Guna.UI.WinForms.GunaLabel lblReturnBook;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaLabel lblAllStudent;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel lblStaff;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel lblAllBook;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Member_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Issue_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Return_Date;
    }
}