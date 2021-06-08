using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.Reports;
using SMDLogic;

namespace LibraryManagementSystem
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            frmDashboardcs frm = new frmDashboardcs();
            SMDChildFormOpen.Open(frm, pnlChild, Color.FromArgb(26, 28, 36));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            frmDashboardcs frm = new frmDashboardcs();
            SMDChildFormOpen.Open(frm,pnlChild,Color.FromArgb(26, 28, 36));
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            frmBook frm = new frmBook();
            SMDChildFormOpen.Open(frm, pnlChild, Color.FromArgb(26, 28, 36));
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            frmStudent frm = new frmStudent();
            SMDChildFormOpen.Open(frm, pnlChild, Color.FromArgb(26, 28, 36));
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin frm = new frmLogin();
            frm.Show();
        }

        private void pnlChild_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            frmIssue frm = new frmIssue();
            SMDChildFormOpen.Open(frm, pnlChild, Color.FromArgb(26, 28, 36));
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            frmReports frm = new frmReports();
            SMDChildFormOpen.Open(frm, pnlChild, Color.FromArgb(26, 28, 36));
        }
    }
}
