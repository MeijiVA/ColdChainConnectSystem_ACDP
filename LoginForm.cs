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
using ColdChainConnectSystem_ACDP;

namespace ColdChainConnectSystem_ACDP
{
    public partial class LoginForm : Form
    {
        DisplayClass cc = new DisplayClass();
        public LoginForm()
        {
            string baseBlue = "#070760";
            string baseWhite = "#FFFFFF";
            InitializeComponent();
            //FORM DISPLAY
            splitContainer1.Panel1.BackColor = cc.SetCustomColor(baseBlue);
            splitContainer1.Panel2.BackColor = cc.SetCustomColor(baseWhite);
            loginBtn.BackColor = cc.SetCustomColor(baseBlue);
            userLbl.ForeColor = cc.SetCustomColor(baseBlue);
            passLbl.ForeColor = cc.SetCustomColor(baseBlue);
            cc.SetDisplayRectangle(loginBtn);
            cc.SetDisplayRectangle(splitContainer1.Panel1, 0, 0, 50, 0);
            cc.myPanel = PanelLogin;
            splitContainer1.Panel2.Paint += new PaintEventHandler(cc.Panel_Paint);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }



        //Allows the form to move via mouseHoldDrag
        
        public Point mouseLoc;
        public Point bottleMouse;
        private void SplitPanelLogo_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLoc = new Point(-e.X, -e.Y);
        }

        private void SplitPanelLogo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLoc.X, mouseLoc.Y);
                Location = mousePose;
            }
        }


        private void loginBtn_Click(object sender, EventArgs e)
        {
            String verify = (usernTbox.Text) + "," + (passTbox);
        }


    }//class
}//namespace
