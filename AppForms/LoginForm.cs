
using ColdChainConnectSystem_ACDP.AppForms.MainPanel.Dashboard;
using ColdChainConnectSystem_ACDP.AppForms.MainPanel.Settings;
using ColdChainConnectSystem_ACDP.ClassResources;
using ColdChainConnectSystem_ACDP.ClassResources.Instances;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ColdChainConnectSystem_ACDP
{
    public partial class LoginForm : Form
    {
        bool toggle = false;
        public static string verify;
        DisplayClass dc = new DisplayClass();
        public LoginForm()
        {
            string baseBlue = "#070760";
            string baseWhite = "#FFFFFF";
            InitializeComponent();
            //FORM DISPLAY
            LoginSplContainer.Panel1.BackColor = dc.SetCustomColor(baseBlue);
            LoginSplContainer.Panel2.BackColor = dc.SetCustomColor(baseWhite);
            userLbl.ForeColor = dc.SetCustomColor(baseBlue);
            passLbl.ForeColor = dc.SetCustomColor(baseBlue);
            dc.SetDisplayRectangle(LoginSplContainer.Panel1, 0, 0, 50, 0);
            btnTogglePassword.BackgroundImage = dc.SetImageOpacity(Properties.Resources.passhide, 0.50F);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.Icon = ColdChainConnectSystem_ACDP.Properties.Resources.CCC_Logo;
        }
        
        private void setupMainForm() 
        {
            MainInstance.i.DisplayPanel.Controls.Clear();
        }

        private void MainFormShow(MainForm mf)
        {
            if (mf.ShowDialog() == DialogResult.Cancel)
            {
                this.Show();
                txtPass.Texts = "";
                txtUser.Texts = "";
            }
        }

        public Point mouseLoc;
        public Point bottleMouse;
        public void LoginSplContainer_Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLoc = new Point(-e.X, -e.Y);
        }

        public void LoginSplContainer_Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLoc.X, mouseLoc.Y);
                this.Location = mousePos;
            }
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            MainInstance.i = new MainForm();
            SettingsInstance.i = new SettingForm();

                string accountCredentials = (txtUser.Texts = "AntonDelaPena") + "," + (txtPass.Texts = "123123123");
                verify = ConnectionClass.LoginAccount(accountCredentials);
                switch (verify)
                {
                    case "admin":
                        setupMainForm();
                        this.Hide();
                        MainInstance.i.NavigateTo(new DashoardForm());
                        MainFormShow(MainInstance.i);
                        break;

                    case "sales":
                        setupMainForm();

                        this.Hide();
                        MainFormShow(MainInstance.i);
                        break;

                    case "assist":
                        setupMainForm();

                        this.Hide();
                        MainFormShow(MainInstance.i);
                        break;

                    case "inv":
                        setupMainForm();

                        this.Hide();
                        MainFormShow(MainInstance.i);
                        break;

                    case "default":
                        break;

                }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            MainInstance.i = new MainForm();
            SettingsInstance.i = new SettingForm();
            if (txtUser.Texts.Equals(""))
            {
                MessageBox.Show("Please enter your Username.");
            }
            else if (txtPass.Texts.Equals(""))
            {
                MessageBox.Show("Please enter your Account's Password.");
            }
            else
            {

                string accountCredentials = (txtUser.Texts) + "," + (txtPass.Texts);
                verify = ConnectionClass.LoginAccount(accountCredentials);
                switch (verify)
                {
                    case "admin":
                        setupMainForm();
                        this.Hide();
                        MainInstance.i.NavigateTo(new DashoardForm());
                        MainFormShow(MainInstance.i);
                        break;

                    case "sales":
                        setupMainForm();

                        this.Hide();
                        MainFormShow(MainInstance.i);
                        break;

                    case "assist":
                        setupMainForm();

                        this.Hide();
                        MainFormShow(MainInstance.i);
                        break;

                    case "inv":
                        setupMainForm();

                        this.Hide();
                        MainFormShow(MainInstance.i);
                        break;

                    case "default":
                        break;

                }
            }
        }

        private void btnTogglePassword_Click(object sender, EventArgs e)
        {
            if (!toggle)
            {
                btnTogglePassword.BackgroundImage = dc.SetImageOpacity(Properties.Resources.passshow, 0.50F);
                txtPass.PasswordChar = false;
                toggle = true;
            }
            else if (toggle)
            {
                
                btnTogglePassword.BackgroundImage = dc.SetImageOpacity(Properties.Resources.passhide, 0.50F);
                txtPass.PasswordChar = true;
                toggle = false;
            }
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Prevents the default Enter key behavior (e.g., beep, new line)
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }
    }//class
}//namespace
