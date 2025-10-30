using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            switch (MessageBox.Show("Are you sure you want to change your password?")) 
            {
                case DialogResult.Yes:
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }

        private void btnConfirmPass_Click(object sender, EventArgs e)
        {

        }
    }
}
