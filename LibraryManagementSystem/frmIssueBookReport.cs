using LibraryManagementSystem.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMDDBManager;

namespace LibraryManagementSystem
{
    public partial class frmIssueBookReport : Form
    {
        public frmIssueBookReport()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = DBManager.getdata("SELECT * FROM `Issue_Book`");

            rptIssueBook rpt = new rptIssueBook();
            rpt.SetDataSource(dt);
            rptViewIssueBook.ReportSource = rpt;
        }

        private void rptViewBook_Load(object sender, EventArgs e)
        {

        }
    }
}
