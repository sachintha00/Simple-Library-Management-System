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
using SMDMessageBox;
using SMDValidation;
using SMDDBManager;

namespace LibraryManagementSystem
{
    public partial class frmIssueBook : Form
    {

        string rDate, iDate;
        public frmIssueBook()
        {
            InitializeComponent();
        }

        public delegate void UpdateDelegate(Object sender, UpdateEvenetArgs args);
        public event UpdateDelegate UpdateEvenetHanler;

        public class UpdateEvenetArgs : EventArgs
        {
            public string Data { get; set; }
        }

        private void insert()
        {
            UpdateEvenetArgs args = new UpdateEvenetArgs();
            UpdateEvenetHanler.Invoke(this, args);
        }

        private void issue_Load(object sender, EventArgs e)
        {

        }

        private void gunaLabel8_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtStudentId.Text) && string.IsNullOrEmpty(txtBookId.Text))
            {
                Validation.texBoxValidate(false, txtStudentId, lblStId, "Cannot be blank");
                Validation.texBoxValidate(false, txtBookId, lblBookId, "Cannot be blank...");
            }
            else if (!txtStudentId.Text.Any(char.IsDigit))
                Validation.texBoxValidate(false, txtStudentId, lblStId, "Cannot be String...");
            else if (!txtBookId.Text.Any(char.IsDigit))
                Validation.texBoxValidate(false, txtBookId, lblBookId, "Cannot be String...");
            else if (dtpReturnDate.Value.Date < DateTime.Now.Date)
                Validation.DateTimeValidate(false, dtpReturnDate, lblreturnDate, "Worng Date...");
            else
            {
                iDate = DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day;
                int i = DBManager.insrtUpdteDelt("INSERT INTO `Issue_Book`(`bid`, `sid`, `Member_name`, `Book_Name`, `Issue_Date`, `Return_Date`) VALUES ('" + int.Parse(txtBookId.Text) + "','" + int.Parse(txtStudentId.Text) + "','" + txtStudentName.Text + "','" + txtBookName.Text + "','" + iDate + "','" + rDate + "')");
                if (i == 1)
                    SMDMessage.show("Successfull", "Data added successfully", SMDMessageBoxButtons.OK, SMDMessageBoxIcon.Information);
                else
                    SMDMessage.show("Error", "Data anot aded", SMDMessageBoxButtons.OK, SMDMessageBoxIcon.Error);
                insert();
            }
        }

        private void txtStudentId_TextChanged(object sender, EventArgs e)
        {
            if (!txtStudentId.Text.Any(char.IsDigit))
                Validation.texBoxValidate(false, txtStudentId, lblStId, "Cannot be String...");
            else if(txtStudentId.Text.Any(char.IsDigit) || !string.IsNullOrEmpty(txtStudentId.Text))
            {
                Validation.texBoxValidate(true, txtStudentId, lblStId);
                txtStudentName.Text = DBManager.getValue("SELECT * FROM `Student`", txtStudentId.Text,0,2);
            }
        }

        private void txtBookId_TextChanged(object sender, EventArgs e)
        {
            if (!txtBookId.Text.Any(char.IsDigit))
                Validation.texBoxValidate(false, txtBookId, lblBookId, "Cannot be String...");
            else if (txtBookId.Text.Any(char.IsDigit) || !string.IsNullOrEmpty(txtBookId.Text))
            {
                Validation.texBoxValidate(true, txtBookId, lblBookId);
                txtStudentName.Text = DBManager.getValue("SELECT * FROM `Book`", txtStudentId.Text, 0, 1);
            }
        }

        private void dtpReturnDate_ValueChanged(object sender, EventArgs e)
        {
            rDate = dtpReturnDate.Value.Year + "/" + dtpReturnDate.Value.Month + "/" + dtpReturnDate.Value.Day;
            if (dtpReturnDate.Value.Date < DateTime.Now.Date)
                Validation.DateTimeValidate(false, dtpReturnDate, lblreturnDate, "Worng Date...");
            else
                Validation.DateTimeValidate(false, dtpReturnDate, lblreturnDate);
        }
    }
}
