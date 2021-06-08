namespace LibraryManagementSystem
{
    partial class frmStudentReport
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
            this.rptViewStudent = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // rptViewStudent
            // 
            this.rptViewStudent.ActiveViewIndex = -1;
            this.rptViewStudent.AutoScroll = true;
            this.rptViewStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptViewStudent.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptViewStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptViewStudent.Location = new System.Drawing.Point(0, 0);
            this.rptViewStudent.Name = "rptViewStudent";
            this.rptViewStudent.Size = new System.Drawing.Size(1167, 548);
            this.rptViewStudent.TabIndex = 0;
            this.rptViewStudent.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmStudentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 548);
            this.Controls.Add(this.rptViewStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStudentReport";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptViewStudent;
    }
}