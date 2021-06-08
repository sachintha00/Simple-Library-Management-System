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
using SMDLogic;
using rf = System.Timers;
using System.Timers;
using SMDMessageBox;

namespace LibraryManagementSystem
{
    public partial class frmIssue : Form
    {
        static int coun = 0;
        static int count = 0;
        public frmIssue()
        {
            InitializeComponent();
        }
        private void frm_UpdateEventHandler(object sender, frmIssueBook.UpdateEvenetArgs args)
        {
            showData();
        }

        private void showData()
        {
            DataTable dt1 = new DataTable();
            dt1 = DBManager.getdata("SELECT * FROM Issue_Book");
            dgvIssueBook.AutoGenerateColumns = false;
            dgvIssueBook.DataSource = dt1;
        }
        private void frmDashboardcs_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void btnAddBook_Click_1(object sender, EventArgs e)
        {
            frmIssueBook frm = new frmIssueBook();
            frm.UpdateEvenetHanler += frm_UpdateEventHandler;
            BackGround.transparent(frm);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = DBManager.getdata("SELECT * FROM Issue_Book WHERE bid LIKE '" + txtSearch.Text + "%' OR sid LIKE '" + txtSearch.Text + "%' OR Member_name LIKE '" + txtSearch.Text + "%' OR Issue_Date LIKE '" + txtSearch.Text + "%' OR Book_Name LIKE '" + txtSearch.Text + "%' OR Return_Date LIKE '" + txtSearch.Text + "%'");
            dgvIssueBook.AutoGenerateColumns = false;
            dgvIssueBook.DataSource = dt;
        }

        private void refresh_Tick(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = DBManager.getdata("SELECT * FROM Issue_Book");
                count = dt.Rows.Count;
                if (count > coun)
                {
                    dgvIssueBook.DataSource = dt;
                    coun = count;
                }
                if (count < coun) { refresh2.Start(); }
            }
            catch (Exception)
            {
                //
            }
        }

        int n, c;

        private void refresh2_Tick(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = DBManager.getdata("SELECT * FROM Issue_Book");
                count = dt.Rows.Count;
                if (count < coun)
                {
                    dgvIssueBook.DataSource = dt;
                    coun = count;
                }
                if (count < coun) { refresh2.Start(); }
            }
            catch (Exception)
            {
                //
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgr in dgvIssueBook.Rows)
            {
                if (Convert.ToBoolean(dgr.Cells[0].Value) == true)
                {
                    n = DBManager.insrtUpdteDelt("DELETE FROM Issue_Book WHERE bid = '" + int.Parse(dgr.Cells[1].Value.ToString()) + "' AND sid = '" + int.Parse(dgr.Cells[2].Value.ToString()) + "'");
                    c += 1;
                }
            }
            showData();
            if (n == 1)
            {
                SMDMessage.show("DELETE DATA", c + " DATA DELETED SUCCESSFULLY ", SMDMessageBoxButtons.OK, SMDMessageBoxIcon.Information);
            }
        }
    }
}
