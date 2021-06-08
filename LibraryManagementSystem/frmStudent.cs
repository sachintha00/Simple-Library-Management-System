using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMDLogic;
using SMDDBManager;
using rf = System.Timers;
using System.Timers;
using SMDMessageBox;

namespace LibraryManagementSystem
{
    public partial class frmStudent : Form
    {
        static int coun = 0;
        static int count = 0;
        public frmStudent()
        {
            InitializeComponent();
        }
        private void frm_UpdateEventHandler(object sender, frmAddStudent.UpdateEvenetArgs args)
        {
            showData();
        }

        private void showData()
        {
            DataTable dt = new DataTable();
            dt = DBManager.getdata("SELECT * FROM Student");
            dgvStudent.AutoGenerateColumns = false;
            dgvStudent.DataSource = dt;
        }
        private void frmDashboardcs_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void btnAddBook_Click_1(object sender, EventArgs e)
        {
            frmAddStudent frm = new frmAddStudent();
            frm.UpdateEvenetHanler += frm_UpdateEventHandler;
            BackGround.transparent(frm);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = DBManager.getdata("SELECT * FROM Student WHERE sid LIKE '" + txtSearch.Text + "%' OR eno LIKE '" + txtSearch.Text + "%' OR sname LIKE '" + txtSearch.Text + "%' OR department LIKE '" + txtSearch.Text + "%' OR semester LIKE '" + txtSearch.Text + "%' OR contact LIKE '" + txtSearch.Text + "%' OR email LIKE '" + txtSearch.Text + "%'");
            dgvStudent.AutoGenerateColumns = false;
            dgvStudent.DataSource = dt;
        }

        private void refresh_Tick(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = DBManager.getdata("SELECT * FROM Student");
                count = dt.Rows.Count;
                if (count > coun)
                {
                    dgvStudent.DataSource = dt;
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
                dt = DBManager.getdata("SELECT * FROM Student");
                count = dt.Rows.Count;
                if (count < coun)
                {
                    dgvStudent.DataSource = dt;
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
            foreach (DataGridViewRow dgr in dgvStudent.Rows)
            {
                if (Convert.ToBoolean(dgr.Cells[0].Value) == true)
                {
                    n = DBManager.insrtUpdteDelt("DELETE FROM Student WHERE sid = '" + int.Parse(dgr.Cells[1].Value.ToString()) + "'");
                    c += 1;
                }
            }
            showData();
            if (n == 1)
            {
                SMDMessage.show("DELETE DATA",c + " DATA DELETED SUCCESSFULLY ",SMDMessageBoxButtons.OK,SMDMessageBoxIcon.Information);
            }
        }
    }
}
