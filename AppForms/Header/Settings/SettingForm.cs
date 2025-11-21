using ColdChainConnectSystem_ACDP.AppForms.Header.Settings;
using ColdChainConnectSystem_ACDP.AppForms.Header.Settings.Employee;
using ColdChainConnectSystem_ACDP.AppForms.Header.Settings.PersonalDetails;
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
        public static PersonalDetailsForm pdf;
        public static SecurityForm secf;
        public static EmployeeForm empf;
        /*public static EmployeeForm ef = new EmployeeForm();*/
        DisplayClass dc = new DisplayClass();
        public SettingForm()
        {
            InitializeComponent();
        }


        public void NavigateTo(Form screen)
        {
            pnlDisplaySettings.Controls.Clear();
            screen.Dock = DockStyle.Fill;
            screen.TopLevel = false;
            pnlDisplaySettings.Controls.Add(screen);
            screen.Show();
        }

        private void setlbl_Click(object sender, EventArgs e)
        {

        }

        private void vsbDisplayPanel_DragOver(object sender, DragEventArgs e)
        {

        }

        private void vsbDisplayPanel_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void tabsSetting_Load(object sender, EventArgs e)
        {
            pdf = new PersonalDetailsForm();
            secf = new SecurityForm();
            empf = new EmployeeForm();
        }
    }
}
