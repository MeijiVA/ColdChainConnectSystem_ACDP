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
using ColdChainConnectSystem_ACDP.AppForms;
using ColdChainConnectSystem_ACDP.AppForms.MainPanel.Dashboard;
using ColdChainConnectSystem_ACDP.AppForms.SidePanel;
using ColdChainConnectSystem_ACDP.ClassResources;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ColdChainConnectSystem_ACDP.AppForms.MainPanel.Settings;

namespace ColdChainConnectSystem_ACDP
{
    public partial class LoginForm : Form
    {
        public static string verify;
        DisplayClass dc = new DisplayClass();
        public static MainForm mf; //singleton
        public static SettingForm sf; //singleton
        public LoginForm()
        {
            string baseBlue = "#070760";
            string baseWhite = "#FFFFFF";
            InitializeComponent();
            //FORM DISPLAY
            LoginSplContainer.Panel1.BackColor = dc.SetCustomColor(baseBlue);
            LoginSplContainer.Panel2.BackColor = dc.SetCustomColor(baseWhite);
            btnLogin.BackColor = dc.SetCustomColor(baseBlue);
            userLbl.ForeColor = dc.SetCustomColor(baseBlue);
            passLbl.ForeColor = dc.SetCustomColor(baseBlue);
            dc.SetDisplayRectangle(btnLogin);
            dc.SetDisplayRectangle(LoginSplContainer.Panel1, 0, 0, 50, 0);
            dc.myPanel = PanelLogin;
            LoginSplContainer.Panel2.Paint += new PaintEventHandler(dc.Panel_Paint);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.Icon = ColdChainConnectSystem_ACDP.Properties.Resources.CCC_Logo;
        }
        
        private void setupMainForm() 
        {
            mf.DisplayPanel.Controls.Clear();
        }

        private void MainFormShow(MainForm mf)
        {
            if (mf.ShowDialog() == DialogResult.Cancel)
            {
                this.Show();
                txtPass.Text = "";
                txtUser.Text = "";
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            mf = new MainForm();
            sf = new SettingForm();
            if (txtUser.Text.Equals(""))
            {
                MessageBox.Show("Please enter your Username.");
            }
            else if (txtPass.Text.Equals(""))
            {
                MessageBox.Show("Please enter your Account's Password.");
            }
            else
            {
                
                string accountCredentials = (txtUser.Text) + "," + (txtPass.Text);
                verify = ConnectionClass.LoginAccount(accountCredentials);
                switch (verify)
                {
                    case "admin":
                        setupMainForm();
                        this.Hide();
                        LoginForm.mf.NavigateTo(new DashoardForm());
                        MainFormShow(mf);
                        break;

                    case "sales":
                        setupMainForm();

                        this.Hide();
                        MainFormShow(mf);
                        break;

                    case "assist":
                        setupMainForm();

                        this.Hide();
                        MainFormShow(mf);
                        break;

                    case "inv":
                        setupMainForm();

                        this.Hide();
                        MainFormShow(mf);
                        break;

                    case "default":
                        break;

                }
            }
        }





        private void usernTbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void passTbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                SendKeys.Send("{TAB}");
                SendKeys.Send("{ENTER}");
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
            
            ConnectionClass.empid = "ADM-0001";
            ConnectionClass.username = "AntonDelaPena";
            ConnectionClass.account = "AntonDelaPena,123123123";
            ConnectionClass.fname = "Antonio";
            ConnectionClass.mname = "C";
            ConnectionClass.lname = "Dela Pena";
            ConnectionClass.address = "Pampanga";
            ConnectionClass.contnum = "09999245959";
            ConnectionClass.age = "40";
            ConnectionClass.dob = "01/01/1985";
            ConnectionClass.position = "Administrator";
            ConnectionClass.status = "Active";
            ConnectionClass.sex = "Alot";
            setupMainForm();
            this.Hide();
            LoginForm.mf.NavigateTo(new DashoardForm());
            MainFormShow(mf);
        }
    }//class
}//namespace
