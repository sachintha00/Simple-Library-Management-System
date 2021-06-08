using SMDDBManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class frmDashboardcs : Form
    {
        public frmDashboardcs()
        {
            InitializeComponent();
        }

        private void frmDashboardcs_Load(object sender, EventArgs e)
        {
            showData();
        }

        
        private void showData()
        {
            DataTable dt1 = new DataTable();
            dt1 = DBManager.getdata("SELECT * FROM Login");
            lblStaff.Text = dt1.Rows.Count.ToString();

            DataTable dt2 = new DataTable();
            dt2 = DBManager.getdata("SELECT * FROM Book");
            lblAllBook.Text = dt2.Rows.Count.ToString();

            DataTable dt3 = new DataTable();
            dt3 = DBManager.getdata("SELECT * FROM Student");
            lblAllStudent.Text = dt3.Rows.Count.ToString();

            DataTable dt4 = new DataTable();
            dt4 = DBManager.getdata("SELECT * FROM Issue_Book");
            lblReturnBook.Text = dt3.Rows.Count.ToString();
            dgvReturnBook.AutoGenerateColumns = false;
            dgvReturnBook.DataSource = dt4;
        }
    }
}
