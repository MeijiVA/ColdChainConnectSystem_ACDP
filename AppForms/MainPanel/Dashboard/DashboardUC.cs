using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Dashboard
{
    public partial class DashboardUC : UserControl
    {
        public DashboardUC()
        {
            InitializeComponent();
            GreetPanel gp = new GreetPanel();
            gp.Dock = DockStyle.Fill;
            basicInfopnl.Controls.Clear();
            basicInfopnl.Controls.Add(gp);
        }

        private void basicInfopnl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
