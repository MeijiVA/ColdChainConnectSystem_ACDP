using ColdChainConnectSystem_ACDP.ClassResources;
using ColdChainConnectSystem_ACDP.Popup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ColdChainConnectSystem_ACDP.AppForms.Header.Settings.PersonalDetails
{
    public partial class SecurityDetails : UserControl
    {
        public SecurityDetails()
        {
            InitializeComponent();

        }
        public string PasswordLength 
        {
            get { return lblPassword.Text; }
            set { lblPassword.Text = value;} 
        }
        public string UsernameView
        {
            get { return lblUsername.Text; }
            set { lblUsername.Text = value; }
        }

        private void SecurityDetails_Load(object sender, EventArgs e)
        {
            pnlUsernameEdit.Hide();
            pnlPasswordEdit.Hide();
        }

        private void btnPassEdit_Click(object sender, EventArgs e)
        {
            pnlPassword.Hide(); 
            pnlPasswordEdit.Show();
        }

        private void btnUserEdit_Click(object sender, EventArgs e)
        {
            pnlUsername.Hide();
            pnlUsernameEdit.Show();
        }

        private void btnCancelUser_Click(object sender, EventArgs e)
        {
            pnlUsername.Show();
            pnlUsernameEdit.Hide();
        }

        private void btnCancelPass_Click(object sender, EventArgs e)
        {
            pnlPassword.Show();
            pnlPasswordEdit.Hide();
        }

        private void btnConfirmUser_Click(object sender, EventArgs e)
        {
            switch (new CustomMessageBox("Change Username", "Are you sure you want to change your Username?", MessageBoxButtons.OKCancel).ShowDialog()) 
            {
                case DialogResult.OK:
                    if (!tboxUsername.Text.Equals("") || !tboxPassUser.Text.Equals("") || !tboxRePassUser.Text.Equals(""))
                    {
                        if (ChangeCredentialsClass.SameUsernameWith(tboxUsername) != true)
                        {
                            if(ChangeCredentialsClass.ChangeUsername(tboxUsername, tboxPassUser, tboxRePassUser))
                            {
                                lblUsername.Text = ConnectionClass.username;
                                tboxUsername.Text = "";
                                tboxPassUser.Text = "";
                                tboxRePassUser.Text = "";
                                pnlUsername.Show();
                                pnlUsernameEdit.Hide();
                            }
                        }
                        else
                        {
                            new CustomMessageBox("Change Username", "Username is taken.").ShowDialog();
                        }
                    }
                    else
                    {
                        new CustomMessageBox("Change Username", "Please insert the required Values.").ShowDialog();
                    }
                        break;
                case DialogResult.Cancel:
                    break;
            }
        }

        private void btnConfirmPass_Click(object sender, EventArgs e)
        {
            
            switch (new CustomMessageBox("Change Password", "Are you sure you want to change your Password?", MessageBoxButtons.OKCancel).ShowDialog())
            {
                case DialogResult.OK:
                    if (!tboxCurrPass.Text.Equals("") || !tboxNewPassEdit.Text.Equals("") || !tboxRePassEdit.Text.Equals(""))
                    {
                        if (ChangeCredentialsClass.ChangePassword(tboxCurrPass, tboxNewPassEdit, tboxRePassEdit))
                        {
                            lblPassword.Text = ConnectionClass.pass;
                            tboxCurrPass.Text = "";
                            tboxNewPassEdit.Text = "";
                            tboxRePassEdit.Text = "";
                            pnlPassword.Show();
                            pnlPasswordEdit.Hide();
                        }
                    }
                    else
                    {
                        new CustomMessageBox("Change Password", "Please insert the required Values.").ShowDialog();
                    }
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }
    }
}
