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
using ColdChainConnectSystem_ACDP.AppForms.SidePanel;
using ColdChainConnectSystem_ACDP.ClassResources;

namespace ColdChainConnectSystem_ACDP
{
    public partial class LoginForm : Form
    {
        DisplayClass cc = new DisplayClass();
        private ConnectionClass conc;
        private static MainForm mf; //singleton
        public LoginForm()
        {
            string baseBlue = "#070760";
            string baseWhite = "#FFFFFF";
            InitializeComponent();
            //FORM DISPLAY
            LoginSplContainer.Panel1.BackColor = cc.SetCustomColor(baseBlue);
            LoginSplContainer.Panel2.BackColor = cc.SetCustomColor(baseWhite);
            loginBtn.BackColor = cc.SetCustomColor(baseBlue);
            userLbl.ForeColor = cc.SetCustomColor(baseBlue);
            passLbl.ForeColor = cc.SetCustomColor(baseBlue);
            cc.SetDisplayRectangle(loginBtn);
            cc.SetDisplayRectangle(LoginSplContainer.Panel1, 0, 0, 50, 0);
            cc.myPanel = PanelLogin;
            LoginSplContainer.Panel2.Paint += new PaintEventHandler(cc.Panel_Paint);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        
        private void loginBtn_Click(object sender, EventArgs e)
        {
            conc = new ConnectionClass();
            String verify = (usernTbox.Text) + "," + (passTbox.Text);
            switch (conc.LoginAccount(verify))
            {
                case "admin":
                    if(mf == null)
                    {
                        mf = new MainForm();
                    }
                    UserAccountControl uc = new UserAccountControl();
                    Admin af = new Admin();

                    uc.Dock = DockStyle.Fill;
                    af.Dock = DockStyle.Fill;

                    mf.MainSidePanel.Controls.Clear();
                    mf.UserSidePanel.Controls.Clear();

                    mf.MainSidePanel.Controls.Add(af);
                    mf.UserSidePanel.Controls.Add(uc);

                    uc.UAC_namelbl.Text = conc.name;
                    uc.UAC_positionlbl.Text = conc.position;

                    af.Show();
                    this.Hide();

                    if(mf.ShowDialog() == DialogResult.Cancel)
                    {
                        this.Show();
                        passTbox.Text = "";
                        usernTbox.Text = "";
                    }
                    
                    break;
                case "sales":
                    break;
                case "assist":
                    break;
                case "inv":
                    break;
                case "default":
                    break;
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
