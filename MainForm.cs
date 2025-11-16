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
using ColdChainConnectSystem_ACDP.ClassResources.Instances;
using ColdChainConnectSystem_ACDP.AppForms.MainPanel.Dashboard;
using ColdChainConnectSystem_ACDP.AppForms.MainPanel.Inventory;
using ColdChainConnectSystem_ACDP.ClassResources;
using ColdChainConnectSystem_ACDP.AppForms.MainPanel.Settings;

namespace ColdChainConnectSystem_ACDP
{
    public partial class MainForm : Form
    {
        public static int settingFlag;
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Icon = ColdChainConnectSystem_ACDP.Properties.Resources.CCC_Logo;
            settingFlag = 1;
        }

        public void NavigateTo(Form screen)
        {
            DisplayPanel.Controls.Clear();
            screen.Dock = DockStyle.Fill;
            screen.TopLevel = false;
            DisplayPanel.Controls.Add(screen);
            screen.Show();
        }



        public Form currentForm(string cf)
        {
            switch (cf)
            {
                case "dbform":
                    return new DashoardForm();
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
                    return new DashoardForm();
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
            this.DialogResult = DialogResult.Cancel;
        }

        private void userAccountControl1_Load(object sender, EventArgs e)
        {
            uacUserProfile.UAC_namelbl.Text = ConnectionClass.fname + " " + ConnectionClass.mname + " " + ConnectionClass.lname; ;
            uacUserProfile.UAC_positionlbl.Text = ConnectionClass.position;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (settingFlag == 1)
            {
                MainInstance.i.NavigateTo(SettingsInstance.i);
                settingFlag = 0;
            }
            else if (settingFlag == 0)
            {
                MainInstance.i.NavigateTo(currentForm(CurrentFormClass.form));
                settingFlag = 1;
            }
        }

        private void DisplayPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }//class
}//namespace
