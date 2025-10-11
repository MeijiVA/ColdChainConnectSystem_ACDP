using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            cc.SetDisplayCircle(UserpBox);
        }
    }
}
