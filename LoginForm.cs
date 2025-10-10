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
            InitializeComponent();

        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.BackColor = cc.SetCustomColor("#0d0e61");
            splitContainer1.Panel1.BackColor = cc.SetCustomColor("#0d0e61");
            splitContainer1.Panel2.BackColor = cc.SetCustomColor("#FFFFFF");
            loginBtn.BackColor = cc.SetCustomColor("#0d0e61");

            cc.SetDisplayRectangle(loginBtn);
            cc.SetDisplayRectangle(splitContainer1.Panel2);
            splitContainer1.SplitterWidth = 1;
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
            if (e.Button == MouseButtons.Left)//checks if left mouse button is held or pressed : D
            {
                Point mousePose = Control.MousePosition;//point var of mouse cursor from topleft corner of sccreen
                mousePose.Offset(mouseLoc.X, mouseLoc.Y);//translates point depending on the location of mouseLoc
                Location = mousePose;//forms location is moved depending on the location of the point variable 
            }
        }


    }
}
