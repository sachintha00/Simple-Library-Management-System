namespace LibraryManagementSystem
{
    partial class frmAddStudent
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
            this.txtStudentName = new Guna.UI.WinForms.GunaTextBox();
            this.txtEnrollmentNo = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtDepartment = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txtStudentContact = new Guna.UI.WinForms.GunaTextBox();
            this.txtStudentEmail = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.btnAdd = new Guna.UI.WinForms.GunaGradientButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.lblStname = new Guna.UI.WinForms.GunaLabel();
            this.lblEnrollNo = new Guna.UI.WinForms.GunaLabel();
            this.lblDepartment = new Guna.UI.WinForms.GunaLabel();
            this.lblStSemester = new Guna.UI.WinForms.GunaLabel();
            this.lblStcontact = new Guna.UI.WinForms.GunaLabel();
            this.lblStEmail = new Guna.UI.WinForms.GunaLabel();
            this.txtStudentSemester = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
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
            this.btnClose.Location = new System.Drawing.Point(602, 1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(98)))), ((int)(((byte)(134)))));
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(91, 43);
            this.btnClose.TabIndex = 3;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtStudentName
            // 
            this.txtStudentName.BackColor = System.Drawing.Color.Transparent;
            this.txtStudentName.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(101)))), ((int)(((byte)(137)))));
            this.txtStudentName.BorderColor = System.Drawing.Color.Transparent;
            this.txtStudentName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStudentName.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(101)))), ((int)(((byte)(137)))));
            this.txtStudentName.FocusedBorderColor = System.Drawing.Color.Transparent;
            this.txtStudentName.FocusedForeColor = System.Drawing.Color.White;
            this.txtStudentName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtStudentName.ForeColor = System.Drawing.Color.White;
            this.txtStudentName.Location = new System.Drawing.Point(29, 344);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.PasswordChar = '\0';
            this.txtStudentName.Radius = 17;
            this.txtStudentName.SelectedText = "";
            this.txtStudentName.Size = new System.Drawing.Size(301, 47);
            this.txtStudentName.TabIndex = 6;
            this.txtStudentName.TextOffsetX = 20;
            this.txtStudentName.TextChanged += new System.EventHandler(this.txtStudentName_TextChanged);
            // 
            // txtEnrollmentNo
            // 
            this.txtEnrollmentNo.BackColor = System.Drawing.Color.Transparent;
            this.txtEnrollmentNo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(101)))), ((int)(((byte)(137)))));
            this.txtEnrollmentNo.BorderColor = System.Drawing.Color.Transparent;
            this.txtEnrollmentNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEnrollmentNo.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(101)))), ((int)(((byte)(137)))));
            this.txtEnrollmentNo.FocusedBorderColor = System.Drawing.Color.Transparent;
            this.txtEnrollmentNo.FocusedForeColor = System.Drawing.Color.White;
            this.txtEnrollmentNo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtEnrollmentNo.ForeColor = System.Drawing.Color.White;
            this.txtEnrollmentNo.Location = new System.Drawing.Point(360, 344);
            this.txtEnrollmentNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEnrollmentNo.Name = "txtEnrollmentNo";
            this.txtEnrollmentNo.PasswordChar = '\0';
            this.txtEnrollmentNo.Radius = 17;
            this.txtEnrollmentNo.SelectedText = "";
            this.txtEnrollmentNo.Size = new System.Drawing.Size(301, 47);
            this.txtEnrollmentNo.TabIndex = 6;
            this.txtEnrollmentNo.TextOffsetX = 20;
            this.txtEnrollmentNo.TextChanged += new System.EventHandler(this.txtEnrollmentNo_TextChanged);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel1.Location = new System.Drawing.Point(33, 311);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(148, 28);
            this.gunaLabel1.TabIndex = 7;
            this.gunaLabel1.Text = "Student Name";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel2.Location = new System.Drawing.Point(368, 311);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(150, 28);
            this.gunaLabel2.TabIndex = 7;
            this.gunaLabel2.Text = "Enrollment No";
            // 
            // txtDepartment
            // 
            this.txtDepartment.BackColor = System.Drawing.Color.Transparent;
            this.txtDepartment.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(101)))), ((int)(((byte)(137)))));
            this.txtDepartment.BorderColor = System.Drawing.Color.Transparent;
            this.txtDepartment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDepartment.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(101)))), ((int)(((byte)(137)))));
            this.txtDepartment.FocusedBorderColor = System.Drawing.Color.Transparent;
            this.txtDepartment.FocusedForeColor = System.Drawing.Color.White;
            this.txtDepartment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtDepartment.ForeColor = System.Drawing.Color.White;
            this.txtDepartment.Location = new System.Drawing.Point(29, 477);
            this.txtDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.PasswordChar = '\0';
            this.txtDepartment.Radius = 17;
            this.txtDepartment.SelectedText = "";
            this.txtDepartment.Size = new System.Drawing.Size(301, 47);
            this.txtDepartment.TabIndex = 6;
            this.txtDepartment.TextOffsetX = 20;
            this.txtDepartment.TextChanged += new System.EventHandler(this.txtDepartment_TextChanged);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel3.Location = new System.Drawing.Point(33, 443);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(127, 28);
            this.gunaLabel3.TabIndex = 7;
            this.gunaLabel3.Text = "Department";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel4.Location = new System.Drawing.Point(368, 443);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(179, 28);
            this.gunaLabel4.TabIndex = 7;
            this.gunaLabel4.Text = "Student Semester";
            // 
            // txtStudentContact
            // 
            this.txtStudentContact.BackColor = System.Drawing.Color.Transparent;
            this.txtStudentContact.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(101)))), ((int)(((byte)(137)))));
            this.txtStudentContact.BorderColor = System.Drawing.Color.Transparent;
            this.txtStudentContact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStudentContact.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(101)))), ((int)(((byte)(137)))));
            this.txtStudentContact.FocusedBorderColor = System.Drawing.Color.Transparent;
            this.txtStudentContact.FocusedForeColor = System.Drawing.Color.White;
            this.txtStudentContact.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtStudentContact.ForeColor = System.Drawing.Color.White;
            this.txtStudentContact.Location = new System.Drawing.Point(29, 605);
            this.txtStudentContact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStudentContact.Name = "txtStudentContact";
            this.txtStudentContact.PasswordChar = '\0';
            this.txtStudentContact.Radius = 17;
            this.txtStudentContact.SelectedText = "";
            this.txtStudentContact.Size = new System.Drawing.Size(301, 47);
            this.txtStudentContact.TabIndex = 6;
            this.txtStudentContact.TextOffsetX = 20;
            this.txtStudentContact.TextChanged += new System.EventHandler(this.txtStudentContact_TextChanged);
            // 
            // txtStudentEmail
            // 
            this.txtStudentEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtStudentEmail.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(101)))), ((int)(((byte)(137)))));
            this.txtStudentEmail.BorderColor = System.Drawing.Color.Transparent;
            this.txtStudentEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStudentEmail.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(101)))), ((int)(((byte)(137)))));
            this.txtStudentEmail.FocusedBorderColor = System.Drawing.Color.Transparent;
            this.txtStudentEmail.FocusedForeColor = System.Drawing.Color.White;
            this.txtStudentEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtStudentEmail.ForeColor = System.Drawing.Color.White;
            this.txtStudentEmail.Location = new System.Drawing.Point(360, 605);
            this.txtStudentEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStudentEmail.Name = "txtStudentEmail";
            this.txtStudentEmail.PasswordChar = '\0';
            this.txtStudentEmail.Radius = 17;
            this.txtStudentEmail.SelectedText = "";
            this.txtStudentEmail.Size = new System.Drawing.Size(301, 47);
            this.txtStudentEmail.TabIndex = 6;
            this.txtStudentEmail.TextOffsetX = 20;
            this.txtStudentEmail.TextChanged += new System.EventHandler(this.txtStudentEmail_TextChanged);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel5.Location = new System.Drawing.Point(33, 571);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(165, 28);
            this.gunaLabel5.TabIndex = 7;
            this.gunaLabel5.Text = "Student Contact";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel6.Location = new System.Drawing.Point(368, 571);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(144, 28);
            this.gunaLabel6.TabIndex = 7;
            this.gunaLabel6.Text = "Student Email";
            // 
            // btnAdd
            // 
            this.btnAdd.AnimationHoverSpeed = 0.07F;
            this.btnAdd.AnimationSpeed = 0.03F;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(101)))), ((int)(((byte)(137)))));
            this.btnAdd.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(152)))), ((int)(((byte)(176)))));
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = null;
            this.btnAdd.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAdd.Location = new System.Drawing.Point(213, 698);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnAdd.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(152)))), ((int)(((byte)(176)))));
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Radius = 25;
            this.btnAdd.Size = new System.Drawing.Size(253, 66);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "ADD STUDENT";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // lblStname
            // 
            this.lblStname.AutoSize = true;
            this.lblStname.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblStname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.lblStname.Location = new System.Drawing.Point(33, 394);
            this.lblStname.Name = "lblStname";
            this.lblStname.Size = new System.Drawing.Size(0, 28);
            this.lblStname.TabIndex = 7;
            // 
            // lblEnrollNo
            // 
            this.lblEnrollNo.AutoSize = true;
            this.lblEnrollNo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblEnrollNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.lblEnrollNo.Location = new System.Drawing.Point(368, 394);
            this.lblEnrollNo.Name = "lblEnrollNo";
            this.lblEnrollNo.Size = new System.Drawing.Size(0, 28);
            this.lblEnrollNo.TabIndex = 7;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDepartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.lblDepartment.Location = new System.Drawing.Point(33, 527);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(0, 28);
            this.lblDepartment.TabIndex = 7;
            // 
            // lblStSemester
            // 
            this.lblStSemester.AutoSize = true;
            this.lblStSemester.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblStSemester.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.lblStSemester.Location = new System.Drawing.Point(368, 527);
            this.lblStSemester.Name = "lblStSemester";
            this.lblStSemester.Size = new System.Drawing.Size(0, 28);
            this.lblStSemester.TabIndex = 7;
            // 
            // lblStcontact
            // 
            this.lblStcontact.AutoSize = true;
            this.lblStcontact.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblStcontact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.lblStcontact.Location = new System.Drawing.Point(33, 655);
            this.lblStcontact.Name = "lblStcontact";
            this.lblStcontact.Size = new System.Drawing.Size(0, 28);
            this.lblStcontact.TabIndex = 7;
            // 
            // lblStEmail
            // 
            this.lblStEmail.AutoSize = true;
            this.lblStEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblStEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.lblStEmail.Location = new System.Drawing.Point(368, 655);
            this.lblStEmail.Name = "lblStEmail";
            this.lblStEmail.Size = new System.Drawing.Size(0, 28);
            this.lblStEmail.TabIndex = 7;
            // 
            // txtStudentSemester
            // 
            this.txtStudentSemester.BackColor = System.Drawing.Color.Transparent;
            this.txtStudentSemester.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(101)))), ((int)(((byte)(137)))));
            this.txtStudentSemester.BorderColor = System.Drawing.Color.Transparent;
            this.txtStudentSemester.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStudentSemester.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(101)))), ((int)(((byte)(137)))));
            this.txtStudentSemester.FocusedBorderColor = System.Drawing.Color.Transparent;
            this.txtStudentSemester.FocusedForeColor = System.Drawing.Color.White;
            this.txtStudentSemester.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtStudentSemester.ForeColor = System.Drawing.Color.White;
            this.txtStudentSemester.Location = new System.Drawing.Point(360, 477);
            this.txtStudentSemester.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStudentSemester.Name = "txtStudentSemester";
            this.txtStudentSemester.PasswordChar = '\0';
            this.txtStudentSemester.Radius = 17;
            this.txtStudentSemester.SelectedText = "";
            this.txtStudentSemester.Size = new System.Drawing.Size(301, 47);
            this.txtStudentSemester.TabIndex = 6;
            this.txtStudentSemester.TextOffsetX = 20;
            this.txtStudentSemester.TextChanged += new System.EventHandler(this.txtStudentSemester_TextChanged);
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.gunaLabel7.Location = new System.Drawing.Point(198, 199);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(268, 46);
            this.gunaLabel7.TabIndex = 10;
            this.gunaLabel7.Text = "ADD STUDENT";
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::LibraryManagementSystem.Properties.Resources.fill_form_theme2;
            this.gunaPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(617, 317);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 75;
            this.gunaPictureBox1.TabStop = false;
            // 
            // frmAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(692, 788);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.lblStEmail);
            this.Controls.Add(this.lblStcontact);
            this.Controls.Add(this.lblStSemester);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblEnrollNo);
            this.Controls.Add(this.lblStname);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.txtStudentEmail);
            this.Controls.Add(this.txtEnrollmentNo);
            this.Controls.Add(this.txtStudentContact);
            this.Controls.Add(this.txtStudentSemester);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gunaPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDashboardcs";
            this.Load += new System.EventHandler(this.frmDashboardcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI.WinForms.GunaTextBox txtEnrollmentNo;
        private Guna.UI.WinForms.GunaTextBox txtStudentName;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txtStudentEmail;
        private Guna.UI.WinForms.GunaTextBox txtStudentContact;
        private Guna.UI.WinForms.GunaTextBox txtDepartment;
        private Guna.UI.WinForms.GunaGradientButton btnAdd;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Guna.UI.WinForms.GunaLabel lblStEmail;
        private Guna.UI.WinForms.GunaLabel lblStcontact;
        private Guna.UI.WinForms.GunaLabel lblStSemester;
        private Guna.UI.WinForms.GunaLabel lblDepartment;
        private Guna.UI.WinForms.GunaLabel lblEnrollNo;
        private Guna.UI.WinForms.GunaLabel lblStname;
        private Guna.UI.WinForms.GunaTextBox txtStudentSemester;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
    }
}