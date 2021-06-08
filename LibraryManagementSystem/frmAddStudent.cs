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
using SMDMessageBox;
using SMDValidation;
using SMDDBManager;
using System.Text.RegularExpressions;

namespace LibraryManagementSystem
{
    public partial class frmAddStudent : Form
    {
        public frmAddStudent()
        {
            InitializeComponent();
        }

        private void frmDashboardcs_Load(object sender, EventArgs e)
        {

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

        private void btnAddBook_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEnrollmentNo.Text) && string.IsNullOrEmpty(txtStudentName.Text) && string.IsNullOrEmpty(txtStudentContact.Text) && string.IsNullOrEmpty(txtStudentEmail.Text) && string.IsNullOrEmpty(txtDepartment.Text) && string.IsNullOrEmpty(txtStudentSemester.Text))
            {
                Validation.texBoxValidate(false, txtEnrollmentNo, lblEnrollNo, "Cannot be empty...");
                Validation.texBoxValidate(false, txtStudentName, lblStname, "Cannot be empty...");
                Validation.texBoxValidate(false, txtStudentContact, lblStcontact, "Cannot be empty...");
                Validation.texBoxValidate(false, txtStudentEmail, lblStEmail, "Cannot be empty...");
                Validation.texBoxValidate(false, txtDepartment, lblDepartment, "Cannot be empty...");
                Validation.texBoxValidate(false, txtStudentSemester, lblStSemester, "Cannot be empty...");
            }
            else if (string.IsNullOrEmpty(txtEnrollmentNo.Text))
                Validation.texBoxValidate(false, txtEnrollmentNo, lblEnrollNo, "Cannot be empty...");
            else if (string.IsNullOrEmpty(txtStudentName.Text))
                Validation.texBoxValidate(false, txtStudentName, lblStname, "Cannot be empty...");
            else if (string.IsNullOrEmpty(txtStudentContact.Text))
                Validation.texBoxValidate(false, txtStudentContact, lblStcontact, "Cannot be empty...");
            else if (string.IsNullOrEmpty(txtStudentEmail.Text))
                Validation.texBoxValidate(false, txtStudentEmail, lblStEmail, "Cannot be empty...");
            else if (string.IsNullOrEmpty(txtDepartment.Text))
                Validation.texBoxValidate(false, txtDepartment, lblDepartment, "Cannot be empty...");
            else if (string.IsNullOrEmpty(txtStudentSemester.Text))
                Validation.texBoxValidate(false, txtStudentSemester, lblStSemester, "Cannot be empty...");
            else if (txtStudentName.Text.Any(char.IsDigit))
                Validation.texBoxValidate(false, txtStudentName, lblStname, "Cannot be Number...");
            else if (txtDepartment.Text.Any(char.IsDigit))
                Validation.texBoxValidate(false, txtDepartment, lblDepartment, "Cannot be Number...");
            else if (!txtEnrollmentNo.Text.Any(char.IsDigit))
                Validation.texBoxValidate(false, txtEnrollmentNo, lblEnrollNo, "Cannot be String...");
            else if (!txtStudentSemester.Text.Any(char.IsDigit))
                Validation.texBoxValidate(false, txtStudentSemester, lblStSemester, "Cannot be String...");
            else if (!Regex.IsMatch(txtStudentContact.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
                Validation.texBoxValidate(false, txtStudentContact, lblStcontact, "TP must have 10 numbers");
            else if (!Regex.IsMatch(txtStudentEmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                Validation.texBoxValidate(false, txtStudentEmail, lblStEmail, "Enter a valid email. Ex:name@gmail.com");
            else
            {
                int i = DBManager.insrtUpdteDelt("INSERT INTO `Student`( `eno`, `sname`, `department`, `semester`, `contact`, `email`) VALUES ('"+txtEnrollmentNo.Text+"','"+txtStudentName.Text+"','"+txtDepartment.Text+"','"+txtStudentSemester.Text+"','"+txtStudentContact.Text+"','"+txtStudentEmail.Text+"')");
                if (i == 1)
                    SMDMessage.show("Successfull", "Data added successfully", SMDMessageBoxButtons.OK, SMDMessageBoxIcon.Information);
                else
                    SMDMessage.show("Error", "Data anot aded", SMDMessageBoxButtons.OK, SMDMessageBoxIcon.Error);
                insert();
            }
        }

        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {
            if (txtStudentName.Text.Any(char.IsDigit))
                Validation.texBoxValidate(false, txtStudentName, lblStname, "Cannot be Number...");
            else if (!txtStudentName.Text.Any(char.IsDigit) || !string.IsNullOrEmpty(txtStudentName.Text))
                Validation.texBoxValidate(true, txtStudentName, lblStname);
        }

        private void txtDepartment_TextChanged(object sender, EventArgs e)
        {
            if (txtDepartment.Text.Any(char.IsDigit))
                Validation.texBoxValidate(false, txtDepartment, lblDepartment, "Cannot be Number...");
            else if (!txtDepartment.Text.Any(char.IsDigit) || !string.IsNullOrEmpty(txtDepartment.Text))
                Validation.texBoxValidate(true, txtDepartment, lblDepartment);
        }

        private void txtEnrollmentNo_TextChanged(object sender, EventArgs e)
        {
            if (!txtEnrollmentNo.Text.Any(char.IsDigit))
                Validation.texBoxValidate(false, txtEnrollmentNo, lblEnrollNo, "Cannot be String...");
            else if (txtEnrollmentNo.Text.Any(char.IsDigit) || !string.IsNullOrEmpty(txtEnrollmentNo.Text))
                Validation.texBoxValidate(true, txtEnrollmentNo, lblEnrollNo);
        }

        private void txtStudentSemester_TextChanged(object sender, EventArgs e)
        {
            if (!txtStudentSemester.Text.Any(char.IsDigit))
                Validation.texBoxValidate(false, txtStudentSemester, lblStSemester, "Cannot be String...");
            else if (txtStudentSemester.Text.Any(char.IsDigit) || !string.IsNullOrEmpty(txtStudentSemester.Text))
                Validation.texBoxValidate(true, txtStudentSemester, lblStSemester);
        }

        private void txtStudentContact_TextChanged(object sender, EventArgs e)
        {
            if(!Regex.IsMatch(txtStudentContact.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
                Validation.texBoxValidate(false, txtStudentContact, lblStcontact, "TP must have 10 numbers");
            else if (txtStudentContact.Text.Any(char.IsDigit) || Regex.IsMatch(txtStudentContact.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
                Validation.texBoxValidate(true, txtStudentContact, lblStcontact);
        }

        private void txtStudentEmail_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtStudentEmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                Validation.texBoxValidate(false, txtStudentEmail, lblStEmail, "Enter a valid email. Ex:name@gmail.com");
            else if (txtStudentEmail.Text.Any(char.IsDigit) || Regex.IsMatch(txtStudentEmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                Validation.texBoxValidate(true, txtStudentEmail, lblStEmail);

        }
    }
}
