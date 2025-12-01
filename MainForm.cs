using ColdChainConnectSystem_ACDP.AppForms.Header.Settings;
using ColdChainConnectSystem_ACDP.AppForms.Header.Settings.PersonalDetails;
using ColdChainConnectSystem_ACDP.AppForms.MainPanel.Dashboard;
using ColdChainConnectSystem_ACDP.AppForms.MainPanel.Inventory;
using ColdChainConnectSystem_ACDP.AppForms.MainPanel.Settings;
using ColdChainConnectSystem_ACDP.ClassResources;
using ColdChainConnectSystem_ACDP.ClassResources.Display;
using ColdChainConnectSystem_ACDP.ClassResources.Instances;
using ColdChainConnectSystem_ACDP.ClassResources.Security;
using ColdChainConnectSystem_ACDP.Popup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColdChainConnectSystem_ACDP
{
    public partial class MainForm : Form
    {
        public static int settingFlag;
        public MainForm()
        {
            InitializeComponent();
            MainInstance.o = new OverlayForm();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            QuantityColor.CreateTxt("QuantityThreshold.txt");

            settingFlag = 1;
        }

        public void NavigateTo(Form screen)
        {
            DisplayPanel.SuspendLayout();
            DisplayPanel.Controls.Clear();
            screen.Dock = DockStyle.Fill;
            screen.TopLevel = false;
            DisplayPanel.Controls.Add(screen);
            screen.Show();
            DisplayPanel.ResumeLayout();
        }



        public Form currentForm(string cf)
        {
            switch (cf)
            {
                case "dbform":
                    return new Dashboard();
                case "invform":
                    return new InventoryForm();
                case "supform":
                    return new InventoryForm(); //change this
                case "salform":
                    return new InventoryForm();//change this
                case "custform":
                    return new InventoryForm();//change this
                case "empform":
                    return new InventoryForm();//change this
                default:
                    return new Dashboard();
            }
        }
















        public Point mouseLoc;
        public Point bottleMouse;
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLoc = new Point(-e.X, -e.Y);
        }
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLoc.X, mouseLoc.Y);
                this.Location = mousePos;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            if(new CustomMessageBox("Log Out","Are you sure you want to log out?",MessageBoxButtons.OKCancel).ShowDialog() == DialogResult.OK)
            {
                this.DialogResult = DialogResult.Cancel;
                AuditLog.AddAuditInfo("Login", "0", ConnectionClass.empid + " Logged out at " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                ConnectionClass.ClearValues();
            }

        }

        private void userAccountControl1_Load(object sender, EventArgs e)
        {
            uacUserProfile.UAC_namelbl.Text = ConnectionClass.fname + " " + ConnectionClass.mname.Substring(0,1) + ". " + ConnectionClass.lname; 
            uacUserProfile.UAC_positionlbl.Text = ConnectionClass.position;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (settingFlag == 1)
            {
                MainInstance.i.NavigateTo(SettingsInstance.i);
                settingFlag = 0;
                // Automatically navigate to PersonalDetailsForm after form loads
                SettingsInstance.i.Load += SettingsForm_Load;
            }
            else if (settingFlag == 0)
            {
                MainInstance.i.NavigateTo(currentForm(CurrentFormClass.form));
                settingFlag = 1;
            }
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            // Remove the event handler to avoid multiple calls
            SettingsInstance.i.Load -= SettingsForm_Load;
            // Navigate to PersonalDetailsForm
            if (SettingForm.pdf != null)
            {
                SettingsInstance.i.NavigateTo(SettingForm.pdf);
            }
            else
            {
                // Initialize if not already done
                SettingForm.pdf = new PersonalDetailsForm();
                SettingsInstance.i.NavigateTo(SettingForm.pdf);
            }
        }

        private void DisplayPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNotif_Click(object sender, EventArgs e)
        {
            if (!notificationDisplay1.Visible)
            {
                notificationDisplay1.Visible = true;
                notificationDisplay1.LoadAllNotifs();
            }
            else if (notificationDisplay1.Visible)
            {
                notificationDisplay1.Visible = false;
            }

        }

        private void notificationDisplay1_Load(object sender, EventArgs e)
        {

        }

        private void notificationDisplay1_Load_1(object sender, EventArgs e)
        {

        }
    }//class
}//namespace
