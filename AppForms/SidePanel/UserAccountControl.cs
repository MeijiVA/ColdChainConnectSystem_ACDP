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
            switch(ConnectionClass.sex)
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

        public String AccountName
        {
            get { return UAC_namelbl.Text; }
            set { UAC_namelbl.Text = value; }
        }
        private void UAC_namelbl_Click(object sender, EventArgs e)
        {

        }
    }
}
