using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using SMDDBManager;
using SMDLogic;

namespace LibraryManagementSystem.Reports
{
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
        }

        private void frmRptBook_Load(object sender, EventArgs e)
        {
            SMDChildFormOpen.OpenWithActiveForm(new frmBookReport(), pnlReports, Color.White);
        }

        private void cmbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbSelect.SelectedIndex == 0)
            {
                SMDChildFormOpen.OpenWithActiveForm(new frmBookReport(), pnlReports, Color.White);
            }
            else if(cmbSelect.SelectedIndex == 1)
            {
                SMDChildFormOpen.OpenWithActiveForm(new frmIssueBookReport(), pnlReports, Color.White);
            }
            else if (cmbSelect.SelectedIndex == 2)
            {
                SMDChildFormOpen.OpenWithActiveForm(new frmStudentReport(), pnlReports, Color.White);
            }
        }
    }
}
