using ColdChainConnectSystem_ACDP.AppForms.Header.Settings;
using ColdChainConnectSystem_ACDP.AppForms.Header.Settings.PersonalDetails;
using ColdChainConnectSystem_ACDP.AppForms.MainPanel.Settings;
using ColdChainConnectSystem_ACDP.ClassResources;
using ColdChainConnectSystem_ACDP.ClassResources.Instances;
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
            this.DoubleBuffered = true; // Apply to the form
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

        public String AccountName
        {
            get { return UAC_namelbl.Text; }
            set { UAC_namelbl.Text = value; }
        }
        private void UAC_namelbl_Click(object sender, EventArgs e)
        {
            NavigateToPersonalDetails();
        }

        private void UserAccountControl_Click(object sender, EventArgs e)
        {
            NavigateToPersonalDetails();
        }

        private void NavigateToPersonalDetails()
        {
            try
            {
                // Navigate to settings and then to personal details
                MainForm.settingFlag = 1;
                MainInstance.i.NavigateTo(SettingsInstance.i);
                MainForm.settingFlag = 0;

                // Navigate to PersonalDetailsForm
                if (SettingForm.pdf != null)
                {
                    SettingsInstance.i.NavigateTo(SettingForm.pdf);
                }
                else
                {
                    SettingForm.pdf = new PersonalDetailsForm();
                    SettingsInstance.i.NavigateTo(SettingForm.pdf);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error navigating to personal details: " + ex.Message);
            }
        }
    }
}
