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
    public partial class frmBookReport : Form
    {
        public frmBookReport()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = DBManager.getdata("SELECT * FROM `Book`");

            rptBook rpt = new rptBook();
            rpt.SetDataSource(dt);
            rptViewBook.ReportSource = rpt;
        }

        private void rptViewBook_Load(object sender, EventArgs e)
        {

        }
    }
}
