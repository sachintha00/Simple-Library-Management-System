namespace LibraryManagementSystem
{
    partial class frmIssueBookReport
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
            this.rptViewIssueBook = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // rptViewIssueBook
            // 
            this.rptViewIssueBook.ActiveViewIndex = -1;
            this.rptViewIssueBook.AutoScroll = true;
            this.rptViewIssueBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptViewIssueBook.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptViewIssueBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptViewIssueBook.Location = new System.Drawing.Point(0, 0);
            this.rptViewIssueBook.Name = "rptViewIssueBook";
            this.rptViewIssueBook.Size = new System.Drawing.Size(1167, 548);
            this.rptViewIssueBook.TabIndex = 0;
            this.rptViewIssueBook.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.rptViewIssueBook.Load += new System.EventHandler(this.rptViewBook_Load);
            // 
            // frmIssueBookReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 548);
            this.Controls.Add(this.rptViewIssueBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIssueBookReport";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptViewIssueBook;
    }
}