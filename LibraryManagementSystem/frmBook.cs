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
using LibraryManagementSystem.Reports;

namespace LibraryManagementSystem
{
    public partial class frmBook : Form
    {
        static int coun = 0;
        static int count = 0;
        public frmBook()
        {
            InitializeComponent();
            refresh.Start();
        }

        private void frm_UpdateEventHandler(object sender, frmAddBook.UpdateEvenetArgs args)
        {
            showData();
        }

        private void showData()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = DBManager.getdata("SELECT * FROM Book");
                dgvBook.AutoGenerateColumns = false;
                dgvBook.DataSource = dt;
            }
            catch (Exception) 
            { 
                //
            }
        }

        private void frmDashboardcs_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void btnAddBook_Click_1(object sender, EventArgs e)
        {
            frmAddBook frm = new frmAddBook();
            frm.UpdateEvenetHanler += frm_UpdateEventHandler;
            BackGround.transparent(frm);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = DBManager.getdata("SELECT * FROM Book WHERE bid LIKE '" + txtSearch.Text + "%' OR bName LIKE '" + txtSearch.Text + "%' OR bPubl LIKE '" + txtSearch.Text + "%' OR bpdate LIKE '" + txtSearch.Text + "%' OR bprice LIKE '" + txtSearch.Text + "%' OR bQuan LIKE '" + txtSearch.Text + "%'");
            dgvBook.AutoGenerateColumns = false;
            dgvBook.DataSource = dt;
        }

        private void refresh_Tick(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = DBManager.getdata("SELECT * FROM Book");
                count = dt.Rows.Count;
                if (count > coun)
                {
                    dgvBook.DataSource = dt;
                    coun = count;
                }
                if (count < coun) { refresh2.Start(); }
            }
            catch(Exception)
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
                dt = DBManager.getdata("SELECT * FROM Book");
                count = dt.Rows.Count;
                if (count < coun)
                {
                    dgvBook.DataSource = dt;
                    coun = count;
                }
            }
            catch (Exception)
            {
                //
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgr in dgvBook.Rows)
            {
                if (Convert.ToBoolean(dgr.Cells[0].Value) == true)
                {
                    string aId = DBManager.getValue("SELECT * FROM Book_Author", dgr.Cells[1].Value.ToString(), 0, 1);
                    DBManager.insrtUpdteDelt("DELETE FROM Book_Author WHERE Book_ID = '" + int.Parse(dgr.Cells[1].Value.ToString()) + "' ");
                    DBManager.insrtUpdteDelt("DELETE FROM Author WHERE Author_Id = '" + int.Parse(aId) + "'");
                    n = DBManager.insrtUpdteDelt("DELETE FROM Book WHERE bid = '" + int.Parse(dgr.Cells[1].Value.ToString()) + "'");
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
