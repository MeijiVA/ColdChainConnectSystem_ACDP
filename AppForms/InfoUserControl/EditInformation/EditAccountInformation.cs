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
    public partial class EditAccountInformation : UserControl
    {
        public EditAccountInformation()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // Apply to the form

        }
        public string PositionInfoLabel
        {
            get { return lblPos.Text; }
            set { lblPos.Text = value; }
        }
        public string PositionInfo
        {
            get { return cbxPosition.Texts; }
            set { cbxPosition.Texts = value; }
        }
        public string ContactInfo
        {
            get { return txtContact.Texts; }
            set { txtContact.Texts = value; }
        }

        public string StatusInfo
        {
            get { return lblStatus.Text; }
            set { lblStatus.Text = value; }
        }

        public string EmailInfo
        {
            get { return txtEmail.Texts; }
            set { txtEmail.Texts = value; }
        }

        public string UsernameInfo
        {
            get { return txtUsername.Texts; }
            set { txtUsername.Texts = value; }
        }

        public string PasswordInfo
        {
            get { return txtPassword.Texts; }
            set { txtPassword.Texts = value; }
        }


        private void tscStatus_CheckChanged(object sender, EventArgs e)
        {
            if (tscStatus.Checked)
            {
                StatusInfo = "Active";
                tscStatus.ToggleBarText = "Active";
                tscStatus.ToggleCircleColor = Color.Green;
            }
            else
            {
                StatusInfo = "Inactive";
                tscStatus.ToggleBarText = "Inactive";
                tscStatus.ToggleCircleColor = Color.Red;
            }
        }

        private void tscStatus_Load(object sender, EventArgs e)
        {

        }

        private void EditAccountInformation_Load(object sender, EventArgs e)
        {
            lblPos.Hide();
            cbxPosition.Hide();
        }
    }
}
