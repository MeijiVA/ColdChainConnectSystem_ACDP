using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ColdChainConnectSystem_ACDP.AppForms;
using ColdChainConnectSystem_ACDP.AppForms.MainPanel.Dashboard;
using ColdChainConnectSystem_ACDP.AppForms.SidePanel;
using ColdChainConnectSystem_ACDP.ClassResources;

namespace ColdChainConnectSystem_ACDP
{
    public partial class LoginForm : Form
    {

        DisplayClass dc = new DisplayClass();
        private ConnectionClass conc;
        public static MainForm mf; //singleton
        public LoginForm()
        {
            if (mf == null)
            {
                mf = new MainForm();
            }
            string baseBlue = "#070760";
            string baseWhite = "#FFFFFF";
            InitializeComponent();
            //FORM DISPLAY
            LoginSplContainer.Panel1.BackColor = dc.SetCustomColor(baseBlue);
            LoginSplContainer.Panel2.BackColor = dc.SetCustomColor(baseWhite);
            loginBtn.BackColor = dc.SetCustomColor(baseBlue);
            userLbl.ForeColor = dc.SetCustomColor(baseBlue);
            passLbl.ForeColor = dc.SetCustomColor(baseBlue);
            dc.SetDisplayRectangle(loginBtn);
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
            mf.MainSidePanel.Controls.Clear();
        }

        private void MainFormShow(MainForm mf)
        {
            if (mf.ShowDialog() == DialogResult.Cancel)
            {
                this.Show();
                passTbox.Text = "";
                usernTbox.Text = "";
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (usernTbox.Text.Equals(""))
            {
                MessageBox.Show("Please enter your Username.");
            }
            else if (passTbox.Text.Equals(""))
            {
                MessageBox.Show("Please enter your Account's Password.");
            }
            else
            {
                conc = new ConnectionClass();
                String verify = (usernTbox.Text) + "," + (passTbox.Text);
                switch (conc.LoginAccount(verify))
                {
                    case "admin":

                        Admin af = new Admin();
                        setupMainForm();
                        af.Dock = DockStyle.Fill;
                        mf.MainSidePanel.Controls.Add(af);
                        af.Show();

                        this.Hide();
                        LoginForm.mf.NavigateTo(new DashboardPanel());
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
    }//class
}//namespace
