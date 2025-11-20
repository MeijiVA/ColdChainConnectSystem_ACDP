using ColdChainConnectSystem_ACDP.AppForms.MainPanel.Inventory;
using ColdChainConnectSystem_ACDP.ClassResources;
using System;
using System.ComponentModel;
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
            AddItemSalesForm add = new AddItemInventoryForm();
            SettingsInstance.i.pnlDisplaySettings.Controls.Add(add);
        }
    }
}
