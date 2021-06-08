namespace LibraryManagementSystem
{
    partial class frmMain
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.btnLogOut = new Guna.UI.WinForms.GunaGradientButton();
            this.btnreport = new Guna.UI.WinForms.GunaGradientButton();
            this.btnStudent = new Guna.UI.WinForms.GunaGradientButton();
            this.btnReturnBook = new Guna.UI.WinForms.GunaGradientButton();
            this.btnBook = new Guna.UI.WinForms.GunaGradientButton();
            this.btnDashboard = new Guna.UI.WinForms.GunaGradientButton();
            this.pnlChild = new Guna.UI.WinForms.GunaPanel();
            this.drgFrmmain = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderColor = System.Drawing.Color.Transparent;
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(101)))), ((int)(((byte)(137)))));
            this.btnClose.HoverState.IconColor = System.Drawing.Color.White;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(101)))), ((int)(((byte)(137)))));
            this.btnClose.Location = new System.Drawing.Point(1387, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(98)))), ((int)(((byte)(134)))));
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(91, 43);
            this.btnClose.TabIndex = 2;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.gunaLabel6);
            this.gunaPanel1.Controls.Add(this.gunaPictureBox1);
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Controls.Add(this.gunaLabel3);
            this.gunaPanel1.Controls.Add(this.btnLogOut);
            this.gunaPanel1.Controls.Add(this.btnreport);
            this.gunaPanel1.Controls.Add(this.btnStudent);
            this.gunaPanel1.Controls.Add(this.btnReturnBook);
            this.gunaPanel1.Controls.Add(this.btnBook);
            this.gunaPanel1.Controls.Add(this.btnDashboard);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(313, 923);
            this.gunaPanel1.TabIndex = 3;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(101)))), ((int)(((byte)(137)))));
            this.gunaLabel6.Location = new System.Drawing.Point(3, 0);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(164, 23);
            this.gunaLabel6.TabIndex = 11;
            this.gunaLabel6.Text = "Dream Reader v1.0";
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::LibraryManagementSystem.Properties.Resources.logo_1;
            this.gunaPictureBox1.Location = new System.Drawing.Point(51, 45);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(208, 209);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 10;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.gunaLabel1.Location = new System.Drawing.Point(35, 257);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(245, 46);
            this.gunaLabel1.TabIndex = 9;
            this.gunaLabel1.Text = "Dream Reader";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.gunaLabel3.Location = new System.Drawing.Point(35, 249);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(245, 46);
            this.gunaLabel3.TabIndex = 9;
            this.gunaLabel3.Text = "Dream Reader";
            // 
            // btnLogOut
            // 
            this.btnLogOut.AnimationHoverSpeed = 0.07F;
            this.btnLogOut.AnimationSpeed = 0.03F;
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.BaseColor1 = System.Drawing.Color.Transparent;
            this.btnLogOut.BaseColor2 = System.Drawing.Color.Transparent;
            this.btnLogOut.BorderColor = System.Drawing.Color.Black;
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogOut.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Image = global::LibraryManagementSystem.Properties.Resources.logOut;
            this.btnLogOut.ImageOffsetX = 10;
            this.btnLogOut.ImageSize = new System.Drawing.Size(25, 25);
            this.btnLogOut.Location = new System.Drawing.Point(59, 814);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.OnHoverBaseColor1 = System.Drawing.Color.Transparent;
            this.btnLogOut.OnHoverBaseColor2 = System.Drawing.Color.Transparent;
            this.btnLogOut.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogOut.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLogOut.OnHoverImage = null;
            this.btnLogOut.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogOut.Radius = 20;
            this.btnLogOut.Size = new System.Drawing.Size(200, 52);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnreport
            // 
            this.btnreport.AnimationHoverSpeed = 0.07F;
            this.btnreport.AnimationSpeed = 0.03F;
            this.btnreport.BackColor = System.Drawing.Color.Transparent;
            this.btnreport.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(101)))), ((int)(((byte)(137)))));
            this.btnreport.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(152)))), ((int)(((byte)(176)))));
            this.btnreport.BorderColor = System.Drawing.Color.Black;
            this.btnreport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnreport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnreport.FocusedColor = System.Drawing.Color.Empty;
            this.btnreport.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnreport.ForeColor = System.Drawing.Color.White;
            this.btnreport.Image = global::LibraryManagementSystem.Properties.Resources.report1;
            this.btnreport.ImageOffsetX = 3;
            this.btnreport.ImageSize = new System.Drawing.Size(25, 25);
            this.btnreport.Location = new System.Drawing.Point(43, 641);
            this.btnreport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnreport.Name = "btnreport";
            this.btnreport.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnreport.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(152)))), ((int)(((byte)(176)))));
            this.btnreport.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnreport.OnHoverForeColor = System.Drawing.Color.White;
            this.btnreport.OnHoverImage = null;
            this.btnreport.OnPressedColor = System.Drawing.Color.Black;
            this.btnreport.Radius = 20;
            this.btnreport.Size = new System.Drawing.Size(219, 52);
            this.btnreport.TabIndex = 5;
            this.btnreport.Text = "Reports";
            this.btnreport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnreport.Click += new System.EventHandler(this.btnreport_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.AnimationHoverSpeed = 0.07F;
            this.btnStudent.AnimationSpeed = 0.03F;
            this.btnStudent.BackColor = System.Drawing.Color.Transparent;
            this.btnStudent.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(101)))), ((int)(((byte)(137)))));
            this.btnStudent.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(152)))), ((int)(((byte)(176)))));
            this.btnStudent.BorderColor = System.Drawing.Color.Black;
            this.btnStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudent.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnStudent.FocusedColor = System.Drawing.Color.Empty;
            this.btnStudent.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnStudent.ForeColor = System.Drawing.Color.White;
            this.btnStudent.Image = global::LibraryManagementSystem.Properties.Resources.student__2_;
            this.btnStudent.ImageOffsetX = 3;
            this.btnStudent.ImageSize = new System.Drawing.Size(25, 25);
            this.btnStudent.Location = new System.Drawing.Point(43, 576);
            this.btnStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnStudent.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(152)))), ((int)(((byte)(176)))));
            this.btnStudent.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnStudent.OnHoverForeColor = System.Drawing.Color.White;
            this.btnStudent.OnHoverImage = null;
            this.btnStudent.OnPressedColor = System.Drawing.Color.Black;
            this.btnStudent.Radius = 20;
            this.btnStudent.Size = new System.Drawing.Size(219, 52);
            this.btnStudent.TabIndex = 5;
            this.btnStudent.Text = "Student";
            this.btnStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.AnimationHoverSpeed = 0.07F;
            this.btnReturnBook.AnimationSpeed = 0.03F;
            this.btnReturnBook.BackColor = System.Drawing.Color.Transparent;
            this.btnReturnBook.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(101)))), ((int)(((byte)(137)))));
            this.btnReturnBook.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(152)))), ((int)(((byte)(176)))));
            this.btnReturnBook.BorderColor = System.Drawing.Color.Black;
            this.btnReturnBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturnBook.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReturnBook.FocusedColor = System.Drawing.Color.Empty;
            this.btnReturnBook.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnReturnBook.ForeColor = System.Drawing.Color.White;
            this.btnReturnBook.Image = global::LibraryManagementSystem.Properties.Resources.return_book;
            this.btnReturnBook.ImageOffsetX = 3;
            this.btnReturnBook.ImageSize = new System.Drawing.Size(25, 25);
            this.btnReturnBook.Location = new System.Drawing.Point(43, 509);
            this.btnReturnBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnReturnBook.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(152)))), ((int)(((byte)(176)))));
            this.btnReturnBook.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReturnBook.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReturnBook.OnHoverImage = null;
            this.btnReturnBook.OnPressedColor = System.Drawing.Color.Black;
            this.btnReturnBook.Radius = 20;
            this.btnReturnBook.Size = new System.Drawing.Size(219, 52);
            this.btnReturnBook.TabIndex = 5;
            this.btnReturnBook.Text = "Issue Book";
            this.btnReturnBook.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // btnBook
            // 
            this.btnBook.AnimationHoverSpeed = 0.07F;
            this.btnBook.AnimationSpeed = 0.03F;
            this.btnBook.BackColor = System.Drawing.Color.Transparent;
            this.btnBook.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(101)))), ((int)(((byte)(137)))));
            this.btnBook.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(152)))), ((int)(((byte)(176)))));
            this.btnBook.BorderColor = System.Drawing.Color.Black;
            this.btnBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBook.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBook.FocusedColor = System.Drawing.Color.Empty;
            this.btnBook.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBook.ForeColor = System.Drawing.Color.White;
            this.btnBook.Image = global::LibraryManagementSystem.Properties.Resources.book;
            this.btnBook.ImageOffsetX = 3;
            this.btnBook.ImageSize = new System.Drawing.Size(25, 25);
            this.btnBook.Location = new System.Drawing.Point(43, 442);
            this.btnBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBook.Name = "btnBook";
            this.btnBook.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnBook.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(152)))), ((int)(((byte)(176)))));
            this.btnBook.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBook.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBook.OnHoverImage = null;
            this.btnBook.OnPressedColor = System.Drawing.Color.Black;
            this.btnBook.Radius = 20;
            this.btnBook.Size = new System.Drawing.Size(219, 52);
            this.btnBook.TabIndex = 5;
            this.btnBook.Text = "Book";
            this.btnBook.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.AnimationHoverSpeed = 0.07F;
            this.btnDashboard.AnimationSpeed = 0.03F;
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(101)))), ((int)(((byte)(137)))));
            this.btnDashboard.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(152)))), ((int)(((byte)(176)))));
            this.btnDashboard.BorderColor = System.Drawing.Color.Black;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDashboard.FocusedColor = System.Drawing.Color.Empty;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::LibraryManagementSystem.Properties.Resources.dashboard;
            this.btnDashboard.ImageOffsetX = 3;
            this.btnDashboard.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDashboard.Location = new System.Drawing.Point(43, 375);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnDashboard.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(152)))), ((int)(((byte)(176)))));
            this.btnDashboard.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDashboard.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDashboard.OnHoverImage = null;
            this.btnDashboard.OnPressedColor = System.Drawing.Color.Black;
            this.btnDashboard.Radius = 20;
            this.btnDashboard.Size = new System.Drawing.Size(219, 52);
            this.btnDashboard.TabIndex = 5;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pnlChild
            // 
            this.pnlChild.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlChild.Location = new System.Drawing.Point(319, 47);
            this.pnlChild.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlChild.Name = "pnlChild";
            this.pnlChild.Size = new System.Drawing.Size(1148, 865);
            this.pnlChild.TabIndex = 4;
            this.pnlChild.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlChild_Paint);
            // 
            // drgFrmmain
            // 
            this.drgFrmmain.Fixed = true;
            this.drgFrmmain.Horizontal = true;
            this.drgFrmmain.TargetControl = this;
            this.drgFrmmain.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.gunaPanel1;
            this.bunifuDragControl2.Vertical = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1479, 923);
            this.Controls.Add(this.pnlChild);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPanel pnlChild;
        private Guna.UI.WinForms.GunaGradientButton btnStudent;
        private Guna.UI.WinForms.GunaGradientButton btnReturnBook;
        private Guna.UI.WinForms.GunaGradientButton btnBook;
        private Guna.UI.WinForms.GunaGradientButton btnDashboard;
        private Bunifu.Framework.UI.BunifuDragControl drgFrmmain;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Guna.UI.WinForms.GunaGradientButton btnLogOut;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaGradientButton btnreport;
    }
}