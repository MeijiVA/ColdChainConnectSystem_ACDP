using ColdChainConnectSystem_ACDP.ClassResources;
using System;
using System.Windows.Forms;

namespace ColdChainConnectSystem_ACDP.AppForms.SidePanel
{
    public partial class UserAccountControl : UserControl
    {
        DisplayClass cc = new DisplayClass();
        public UserAccountControl()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            switch (ConnectionClass.sex)
            {
                case "Male":
                    pbxUser.Image = Properties.Resources.MaleIcon;
                    break;
                case "Female":
                    pbxUser.Image = Properties.Resources.FemaleIcon;
                    break;
                default:
                    break;

            }
        }
    }
}
