using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Settings
{
    public partial class SettingForm : Form
    {
        DisplayClass dc = new DisplayClass();
        public SettingForm()
        {
            InitializeComponent();
            dc.SetDisplayRectangle(setlbl, 50, 50, 50, 50);
        }

        private void setlbl_Click(object sender, EventArgs e)
        {

        }
    }
}
