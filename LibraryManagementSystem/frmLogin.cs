using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMDMessageBox;
using SMDDBManager;
using SMDLogic;
using System.Threading;

namespace LibraryManagementSystem
{
    public partial class frmLogin : Form
    {
        string passingRollName;
        public frmLogin()
        {
            Thread t = new Thread(new ThreadStart(splashScreen));
            t.Start();
            Thread.Sleep(7000);
            InitializeComponent();
            t.Abort();

            if(Properties.Settings.Default.Username != string.Empty)
            {
                txtUsername.Text = Properties.Settings.Default.Username;
                txtPassword.Text = Properties.Settings.Default.Password;
                rememberMe.Checked = true;
            }
        }

        private void splashScreen()
        {
            Application.Run(new frmLoading());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login()
        {
            passingRollName = DBManager.ReadValue("SELECT * FROM Login WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text + "' ", 1);

            if(passingRollName == "Librarian")
            {
                if(rememberMe.Checked == true)
                {
                    Properties.Settings.Default.Username = txtUsername.Text;
                    Properties.Settings.Default.Password = txtPassword.Text;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.Username = "";
                    Properties.Settings.Default.Password = "";
                    Properties.Settings.Default.Save();
                }
                this.Hide();
                frmMain frm = new frmMain();
                frm.Show();
            }
            else
                SMDMessage.show("Login Error","Please check your password and username",SMDMessageBoxButtons.OK,SMDMessageBoxIcon.Error);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                txtPassword.Focus();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                login();
        }

        private void lblTermsAndCondition_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BackGround.transparent(new frmTermsAndCondition());
        }
    }
}
