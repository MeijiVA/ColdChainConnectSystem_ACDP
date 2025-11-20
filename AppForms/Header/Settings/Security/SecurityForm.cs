using ColdChainConnectSystem_ACDP.ClassResources;
using System;
using System.Windows.Forms;

namespace ColdChainConnectSystem_ACDP.AppForms.Header.Settings.PersonalDetails
{
    public partial class SecurityForm : Form
    {
        public SecurityForm()
        {
            InitializeComponent();
        }

        private void SecurityForm_Load(object sender, EventArgs e)
        {
            string p = "";
            for (int i = 0; i < ConnectionClass.pass.Length; i++)
            {
                p = p + "*";
            }
            lblEmpID.Text = ConnectionClass.empid;
            sdUserControl.PasswordLength = p;
            sdUserControl.UsernameView = ConnectionClass.username;
        }
    }
}
