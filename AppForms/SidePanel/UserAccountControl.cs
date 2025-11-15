using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ColdChainConnectSystem_ACDP.ClassResources;

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
            cc.SetDisplayCircle(UserpBox);
            switch(ConnectionClass.sex)
            {
                case "Male":
                    UserpBox.BackgroundImage = Properties.Resources.ACDPLogo;
                    break;
                case "Female":
                    UserpBox.BackgroundImage = Properties.Resources.LoginLogoACDP;
                    break;
                default:
                    break;

            }
        }
    }
}
