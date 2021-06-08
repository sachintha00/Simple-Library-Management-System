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
using SMDMessageBox;
using SMDValidation;

namespace LibraryManagementSystem
{
    public partial class frmAddBook : Form
    {

        string pubDate;
        public frmAddBook()
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

        private void frmDashboardcs_Load(object sender, EventArgs e)
        {

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
            if (string.IsNullOrEmpty(txtAutherName.Text) && string.IsNullOrEmpty(txtBookName.Text) && string.IsNullOrEmpty(txtbookPrice.Text) && string.IsNullOrEmpty(txtBookQuantity.Text) && string.IsNullOrEmpty(txtPublication.Text) && ((DateTime.Now.Day == dtpublicationdate.Value.Day) || (DateTime.Now.Year == dtpublicationdate.Value.Year)))
            {
                Validation.texBoxValidate(false, txtAutherName, lblAuthorName, "Cannot be empty...");
                Validation.texBoxValidate(false, txtBookName, lblBookName, "Cannot be empty...");
                Validation.texBoxValidate(false, txtbookPrice, lblBookPrice, "Cannot be empty...");
                Validation.texBoxValidate(false, txtBookQuantity, lblBookQuantity, "Cannot be empty...");
                Validation.texBoxValidate(false, txtPublication, lblPublication, "Cannot be empty...");
                Validation.DateTimeValidate(false, dtpublicationdate, lblPublicationDate, "this is not a valid date...");
            }
            else if (string.IsNullOrEmpty(txtAutherName.Text))
                Validation.texBoxValidate(false, txtAutherName, lblAuthorName, "Cannot be empty...");
            else if (string.IsNullOrEmpty(txtBookName.Text))
                Validation.texBoxValidate(false, txtBookName, lblBookName, "Cannot be empty...");
            else if (string.IsNullOrEmpty(txtbookPrice.Text))
                Validation.texBoxValidate(false, txtbookPrice, lblBookPrice, "Cannot be empty...");
            else if (string.IsNullOrEmpty(txtBookQuantity.Text))
                Validation.texBoxValidate(false, txtBookQuantity, lblBookQuantity, "Cannot be empty...");
            else if (string.IsNullOrEmpty(txtPublication.Text))
                Validation.texBoxValidate(false, txtPublication, lblPublication, "Cannot be empty...");
            else if (((DateTime.Now.Day == dtpublicationdate.Value.Day) || (DateTime.Now.Year == dtpublicationdate.Value.Year)))
                Validation.DateTimeValidate(false, dtpublicationdate, lblPublicationDate, "this is not a valid date...");
            else if (txtBookName.Text.Any(char.IsDigit))
                Validation.texBoxValidate(false, txtBookName, lblBookName, "Cannot be Number...");
            else if (txtAutherName.Text.Any(char.IsDigit))
                Validation.texBoxValidate(false, txtAutherName, lblAuthorName, "Cannot be Number...");
            else if (txtPublication.Text.Any(char.IsDigit))
                Validation.texBoxValidate(false, txtPublication, lblPublication, "Cannot be Number...");
            else if (dtpublicationdate.Value.Date > DateTime.Now.Date)
                Validation.DateTimeValidate(false, dtpublicationdate, lblPublicationDate, "Worng Date...");
            else if (!txtbookPrice.Text.Any(char.IsDigit))
                Validation.texBoxValidate(false, txtbookPrice, lblBookPrice, "Cannot be String...");
            else if (!txtBookQuantity.Text.Any(char.IsDigit))
                Validation.texBoxValidate(false, txtBookQuantity, lblBookQuantity, "Cannot be String...");
            else
            {
                int bookId = int.Parse(DBManager.lastRecord("INSERT INTO `Book`(`bName`, `bPubl`, `bpdate`, `bprice`, `bQuan`) VALUES ('" + txtBookName.Text + "','" + txtPublication.Text + "','" + pubDate + "','" + txtbookPrice.Text + "','" + txtBookQuantity.Text + "')"));
                int authorId = int.Parse(DBManager.lastRecord("INSERT INTO `Author`(`Author_Name`) VALUES ('" + txtAutherName.Text+"')"));
                int i = DBManager.insrtUpdteDelt("INSERT INTO `Book_Author`(`Book_ID`, `Author_Id`) VALUES ('"+ bookId + "','"+authorId+"')");
                if (i==1)
                    SMDMessage.show("Successfull","Data added successfully",SMDMessageBoxButtons.OK,SMDMessageBoxIcon.Information);
                else
                    SMDMessage.show("Error", "Data anot aded", SMDMessageBoxButtons.OK, SMDMessageBoxIcon.Error);
                insert();
            }
        }

        private void dtpublicationdate_ValueChanged(object sender, EventArgs e)
        {
            pubDate = dtpublicationdate.Value.Year + "/" + dtpublicationdate.Value.Month + "/" + dtpublicationdate.Value.Day;
            if(dtpublicationdate.Value.Date > DateTime.Now.Date)
                Validation.DateTimeValidate(false, dtpublicationdate, lblPublicationDate, "Worng Date...");
            else 
                Validation.DateTimeValidate(false, dtpublicationdate, lblPublicationDate);
        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {
            if (txtBookName.Text.Any(char.IsDigit))
                Validation.texBoxValidate(false, txtBookName, lblBookName, "Cannot be Number...");
            else if (!txtBookName.Text.Any(char.IsDigit) || !string.IsNullOrEmpty(txtBookName.Text))
                Validation.texBoxValidate(true, txtBookName, lblBookName);
        }

        private void txtAutherName_TextChanged(object sender, EventArgs e)
        {
            if (txtAutherName.Text.Any(char.IsDigit))
                Validation.texBoxValidate(false, txtAutherName, lblAuthorName, "Cannot be Number...");
            else if (!txtAutherName.Text.Any(char.IsDigit) || !string.IsNullOrEmpty(txtAutherName.Text))
                Validation.texBoxValidate(true, txtAutherName, lblAuthorName);
        }

        private void txtPublication_TextChanged(object sender, EventArgs e)
        {
            if (txtPublication.Text.Any(char.IsDigit))
                Validation.texBoxValidate(false, txtPublication, lblPublication, "Cannot be Number...");
            else if (!txtPublication.Text.Any(char.IsDigit) || !string.IsNullOrEmpty(txtPublication.Text))
                Validation.texBoxValidate(true, txtPublication, lblPublication);
        }

        private void txtbookPrice_TextChanged(object sender, EventArgs e)
        {
            if (!txtbookPrice.Text.Any(char.IsDigit))
                Validation.texBoxValidate(false, txtbookPrice, lblBookPrice, "Cannot be String...");
            else if (txtbookPrice.Text.Any(char.IsDigit) || !string.IsNullOrEmpty(txtbookPrice.Text))
                Validation.texBoxValidate(true, txtbookPrice, lblBookPrice);
        }

        private void txtBookQuantity_TextChanged(object sender, EventArgs e)
        {
            if (!txtBookQuantity.Text.Any(char.IsDigit))
                Validation.texBoxValidate(false, txtBookQuantity, lblBookQuantity, "Cannot be String...");
            else if (txtBookQuantity.Text.Any(char.IsDigit) || !string.IsNullOrEmpty(txtBookQuantity.Text))
                Validation.texBoxValidate(true, txtBookQuantity, lblBookQuantity);
        }
    }
}
