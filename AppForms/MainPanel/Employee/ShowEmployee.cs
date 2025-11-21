using ColdChainConnectSystem_ACDP.AppForms.MainPanel.Inventory;
using ColdChainConnectSystem_ACDP.AppForms.MainPanel.Sales;
using ColdChainConnectSystem_ACDP.ClassResources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColdChainConnectSystem_ACDP.AppForms.Header.Settings.Employee
{
    public partial class ShowEmployee : UserControl
    {
        public ShowEmployee()
        {
            InitializeComponent();
        }
        [Category("Data")]
        public string EMPID
        {
            get { return lblEMP.Text; }
            set { lblEMP.Text = value; }
        }

        private void customButton2_Click(object sender, EventArgs e)
        {

        }

        private void customButton3_Click(object sender, EventArgs e)
        {
            AddTransactionSalesForm add = new AddTransactionSalesForm();
            SettingsInstance.i.pnlDisplaySettings.Controls.Add(add);
        }
    }
}
