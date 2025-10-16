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
using ColdChainConnectSystem_ACDP.AppForms.MainPanel;
using ColdChainConnectSystem_ACDP.ClassResources;

namespace ColdChainConnectSystem_ACDP
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Icon = ColdChainConnectSystem_ACDP.Properties.Resources.CCC_Logo;
        }

        public void NavigateTo(Form screen)
        {
            DisplayPanel.Controls.Clear();
            screen.Dock = DockStyle.Fill;
            screen.TopLevel = false;
            DisplayPanel.Controls.Add(screen);
            screen.Show();
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
            userAccountControl1.UAC_namelbl.Text = ConnectionClass.fname + " " + ConnectionClass.mname + " " + ConnectionClass.lname; ;
            userAccountControl1.UAC_positionlbl.Text = ConnectionClass.position;
        }
    }//class
}//namespace
