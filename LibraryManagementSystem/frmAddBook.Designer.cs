namespace LibraryManagementSystem
{
    partial class frmAddBook
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
            this.txtBookName = new Guna.UI.WinForms.GunaTextBox();
            this.txtAutherName = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtPublication = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txtbookPrice = new Guna.UI.WinForms.GunaTextBox();
            this.txtBookQuantity = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.dtpublicationdate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.btnAdd = new Guna.UI.WinForms.GunaGradientButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.lblBookName = new Guna.UI.WinForms.GunaLabel();
            this.lblAuthorName = new Guna.UI.WinForms.GunaLabel();
            this.lblPublication = new Guna.UI.WinForms.GunaLabel();
            this.lblPublicationDate = new Guna.UI.WinForms.GunaLabel();
            this.lblBookPrice = new Guna.UI.WinForms.GunaLabel();
            this.lblBookQuantity = new Guna.UI.WinForms.GunaLabel();
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
            this.btnClose.Location = new System.Drawing.Point(621, 1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(98)))), ((int)(((byte)(134)))));
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(91, 43);
            this.btnClose.TabIndex = 3;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtBookName
            // 
            this.txtBookName.BackColor = System.Drawing.Color.Transparent;
            this.txtBookName.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(101)))), ((int)(((byte)(137)))));
            this.txtBookName.BorderColor = System.Drawing.Color.Transparent;
            this.txtBookName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookName.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(101)))), ((int)(((byte)(137)))));
            this.txtBookName.FocusedBorderColor = System.Drawing.Color.Transparent;
            this.txtBookName.FocusedForeColor = System.Drawing.Color.White;
            this.txtBookName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtBookName.ForeColor = System.Drawing.Color.White;
            this.txtBookName.Location = new System.Drawing.Point(34, 331);
            this.txtBookName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.PasswordChar = '\0';
            this.txtBookName.Radius = 17;
            this.txtBookName.SelectedText = "";
            this.txtBookName.Size = new System.Drawing.Size(301, 47);
            this.txtBookName.TabIndex = 6;
            this.txtBookName.TextOffsetX = 20;
            this.txtBookName.TextChanged += new System.EventHandler(this.txtBookName_TextChanged);
            // 
            // txtAutherName
            // 
            this.txtAutherName.BackColor = System.Drawing.Color.Transparent;
            this.txtAutherName.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(101)))), ((int)(((byte)(137)))));
            this.txtAutherName.BorderColor = System.Drawing.Color.Transparent;
            this.txtAutherName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAutherName.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(101)))), ((int)(((byte)(137)))));
            this.txtAutherName.FocusedBorderColor = System.Drawing.Color.Transparent;
            this.txtAutherName.FocusedForeColor = System.Drawing.Color.White;
            this.txtAutherName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtAutherName.ForeColor = System.Drawing.Color.White;
            this.txtAutherName.Location = new System.Drawing.Point(365, 331);
            this.txtAutherName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAutherName.Name = "txtAutherName";
            this.txtAutherName.PasswordChar = '\0';
            this.txtAutherName.Radius = 17;
            this.txtAutherName.SelectedText = "";
            this.txtAutherName.Size = new System.Drawing.Size(301, 47);
            this.txtAutherName.TabIndex = 6;
            this.txtAutherName.TextOffsetX = 20;
            this.txtAutherName.TextChanged += new System.EventHandler(this.txtAutherName_TextChanged);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel1.Location = new System.Drawing.Point(38, 298);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(122, 28);
            this.gunaLabel1.TabIndex = 7;
            this.gunaLabel1.Text = "Book Name";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel2.Location = new System.Drawing.Point(373, 298);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(139, 28);
            this.gunaLabel2.TabIndex = 7;
            this.gunaLabel2.Text = "Auther Name";
            // 
            // txtPublication
            // 
            this.txtPublication.BackColor = System.Drawing.Color.Transparent;
            this.txtPublication.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(101)))), ((int)(((byte)(137)))));
            this.txtPublication.BorderColor = System.Drawing.Color.Transparent;
            this.txtPublication.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPublication.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(101)))), ((int)(((byte)(137)))));
            this.txtPublication.FocusedBorderColor = System.Drawing.Color.Transparent;
            this.txtPublication.FocusedForeColor = System.Drawing.Color.White;
            this.txtPublication.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtPublication.ForeColor = System.Drawing.Color.White;
            this.txtPublication.Location = new System.Drawing.Point(34, 464);
            this.txtPublication.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPublication.Name = "txtPublication";
            this.txtPublication.PasswordChar = '\0';
            this.txtPublication.Radius = 17;
            this.txtPublication.SelectedText = "";
            this.txtPublication.Size = new System.Drawing.Size(301, 47);
            this.txtPublication.TabIndex = 6;
            this.txtPublication.TextOffsetX = 20;
            this.txtPublication.TextChanged += new System.EventHandler(this.txtPublication_TextChanged);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel3.Location = new System.Drawing.Point(38, 430);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(119, 28);
            this.gunaLabel3.TabIndex = 7;
            this.gunaLabel3.Text = "Publication";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel4.Location = new System.Drawing.Point(373, 430);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(170, 28);
            this.gunaLabel4.TabIndex = 7;
            this.gunaLabel4.Text = "Publication Date";
            // 
            // txtbookPrice
            // 
            this.txtbookPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtbookPrice.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(101)))), ((int)(((byte)(137)))));
            this.txtbookPrice.BorderColor = System.Drawing.Color.Transparent;
            this.txtbookPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbookPrice.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(101)))), ((int)(((byte)(137)))));
            this.txtbookPrice.FocusedBorderColor = System.Drawing.Color.Transparent;
            this.txtbookPrice.FocusedForeColor = System.Drawing.Color.White;
            this.txtbookPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtbookPrice.ForeColor = System.Drawing.Color.White;
            this.txtbookPrice.Location = new System.Drawing.Point(34, 592);
            this.txtbookPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbookPrice.Name = "txtbookPrice";
            this.txtbookPrice.PasswordChar = '\0';
            this.txtbookPrice.Radius = 17;
            this.txtbookPrice.SelectedText = "";
            this.txtbookPrice.Size = new System.Drawing.Size(301, 47);
            this.txtbookPrice.TabIndex = 6;
            this.txtbookPrice.TextOffsetX = 20;
            this.txtbookPrice.TextChanged += new System.EventHandler(this.txtbookPrice_TextChanged);
            // 
            // txtBookQuantity
            // 
            this.txtBookQuantity.BackColor = System.Drawing.Color.Transparent;
            this.txtBookQuantity.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(101)))), ((int)(((byte)(137)))));
            this.txtBookQuantity.BorderColor = System.Drawing.Color.Transparent;
            this.txtBookQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookQuantity.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(101)))), ((int)(((byte)(137)))));
            this.txtBookQuantity.FocusedBorderColor = System.Drawing.Color.Transparent;
            this.txtBookQuantity.FocusedForeColor = System.Drawing.Color.White;
            this.txtBookQuantity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtBookQuantity.ForeColor = System.Drawing.Color.White;
            this.txtBookQuantity.Location = new System.Drawing.Point(365, 592);
            this.txtBookQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBookQuantity.Name = "txtBookQuantity";
            this.txtBookQuantity.PasswordChar = '\0';
            this.txtBookQuantity.Radius = 17;
            this.txtBookQuantity.SelectedText = "";
            this.txtBookQuantity.Size = new System.Drawing.Size(301, 47);
            this.txtBookQuantity.TabIndex = 6;
            this.txtBookQuantity.TextOffsetX = 20;
            this.txtBookQuantity.TextChanged += new System.EventHandler(this.txtBookQuantity_TextChanged);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel5.Location = new System.Drawing.Point(38, 558);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(113, 28);
            this.gunaLabel5.TabIndex = 7;
            this.gunaLabel5.Text = "Book Price";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel6.Location = new System.Drawing.Point(373, 558);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(149, 28);
            this.gunaLabel6.TabIndex = 7;
            this.gunaLabel6.Text = "Book Quantity";
            // 
            // dtpublicationdate
            // 
            this.dtpublicationdate.BackColor = System.Drawing.Color.Transparent;
            this.dtpublicationdate.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(101)))), ((int)(((byte)(137)))));
            this.dtpublicationdate.BorderColor = System.Drawing.Color.Transparent;
            this.dtpublicationdate.BorderSize = 0;
            this.dtpublicationdate.CustomFormat = null;
            this.dtpublicationdate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpublicationdate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpublicationdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpublicationdate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dtpublicationdate.Location = new System.Drawing.Point(365, 464);
            this.dtpublicationdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpublicationdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpublicationdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpublicationdate.Name = "dtpublicationdate";
            this.dtpublicationdate.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(150)))), ((int)(((byte)(174)))));
            this.dtpublicationdate.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.dtpublicationdate.OnHoverForeColor = System.Drawing.Color.White;
            this.dtpublicationdate.OnPressedColor = System.Drawing.Color.Black;
            this.dtpublicationdate.Radius = 17;
            this.dtpublicationdate.Size = new System.Drawing.Size(301, 47);
            this.dtpublicationdate.TabIndex = 8;
            this.dtpublicationdate.Text = "Sunday, May 9, 2021";
            this.dtpublicationdate.Value = new System.DateTime(2021, 5, 9, 15, 39, 12, 836);
            this.dtpublicationdate.ValueChanged += new System.EventHandler(this.dtpublicationdate_ValueChanged);
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
            this.btnAdd.Location = new System.Drawing.Point(203, 724);
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
            this.btnAdd.Text = "ADD BOOK";
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
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblBookName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.lblBookName.Location = new System.Drawing.Point(38, 381);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(0, 28);
            this.lblBookName.TabIndex = 7;
            // 
            // lblAuthorName
            // 
            this.lblAuthorName.AutoSize = true;
            this.lblAuthorName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblAuthorName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.lblAuthorName.Location = new System.Drawing.Point(373, 381);
            this.lblAuthorName.Name = "lblAuthorName";
            this.lblAuthorName.Size = new System.Drawing.Size(0, 28);
            this.lblAuthorName.TabIndex = 7;
            // 
            // lblPublication
            // 
            this.lblPublication.AutoSize = true;
            this.lblPublication.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPublication.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.lblPublication.Location = new System.Drawing.Point(38, 514);
            this.lblPublication.Name = "lblPublication";
            this.lblPublication.Size = new System.Drawing.Size(0, 28);
            this.lblPublication.TabIndex = 7;
            // 
            // lblPublicationDate
            // 
            this.lblPublicationDate.AutoSize = true;
            this.lblPublicationDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPublicationDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.lblPublicationDate.Location = new System.Drawing.Point(373, 514);
            this.lblPublicationDate.Name = "lblPublicationDate";
            this.lblPublicationDate.Size = new System.Drawing.Size(0, 28);
            this.lblPublicationDate.TabIndex = 7;
            // 
            // lblBookPrice
            // 
            this.lblBookPrice.AutoSize = true;
            this.lblBookPrice.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblBookPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.lblBookPrice.Location = new System.Drawing.Point(38, 642);
            this.lblBookPrice.Name = "lblBookPrice";
            this.lblBookPrice.Size = new System.Drawing.Size(0, 28);
            this.lblBookPrice.TabIndex = 7;
            // 
            // lblBookQuantity
            // 
            this.lblBookQuantity.AutoSize = true;
            this.lblBookQuantity.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblBookQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.lblBookQuantity.Location = new System.Drawing.Point(373, 642);
            this.lblBookQuantity.Name = "lblBookQuantity";
            this.lblBookQuantity.Size = new System.Drawing.Size(0, 28);
            this.lblBookQuantity.TabIndex = 7;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.gunaLabel7.Location = new System.Drawing.Point(207, 219);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(205, 46);
            this.gunaLabel7.TabIndex = 10;
            this.gunaLabel7.Text = "ADD BOOK";
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::LibraryManagementSystem.Properties.Resources.fill_form_theme2;
            this.gunaPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(617, 317);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 76;
            this.gunaPictureBox1.TabStop = false;
            // 
            // frmAddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(711, 834);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpublicationdate);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.lblBookQuantity);
            this.Controls.Add(this.lblBookPrice);
            this.Controls.Add(this.lblPublicationDate);
            this.Controls.Add(this.lblPublication);
            this.Controls.Add(this.lblAuthorName);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.txtBookQuantity);
            this.Controls.Add(this.txtAutherName);
            this.Controls.Add(this.txtbookPrice);
            this.Controls.Add(this.txtPublication);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gunaPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAddBook";
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
        private Guna.UI.WinForms.GunaTextBox txtAutherName;
        private Guna.UI.WinForms.GunaTextBox txtBookName;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txtBookQuantity;
        private Guna.UI.WinForms.GunaTextBox txtbookPrice;
        private Guna.UI.WinForms.GunaTextBox txtPublication;
        private Guna.UI.WinForms.GunaDateTimePicker dtpublicationdate;
        private Guna.UI.WinForms.GunaGradientButton btnAdd;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Guna.UI.WinForms.GunaLabel lblBookQuantity;
        private Guna.UI.WinForms.GunaLabel lblBookPrice;
        private Guna.UI.WinForms.GunaLabel lblPublicationDate;
        private Guna.UI.WinForms.GunaLabel lblPublication;
        private Guna.UI.WinForms.GunaLabel lblAuthorName;
        private Guna.UI.WinForms.GunaLabel lblBookName;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
    }
}