using ColdChainConnectSystem_ACDP.ClassResources.Instances;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColdChainConnectSystem_ACDP.Popup
{
    public partial class CustomMessageBox : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
(
    int nLeftRect,     // x-coordinate of upper-left corner
    int nTopRect,      // y-coordinate of upper-left corner
    int nRightRect,    // x-coordinate of lower-right corner
    int nBottomRect,   // y-coordinate of lower-right corner
    int nWidthEllipse, // width of ellipse
    int nHeightEllipse // height of ellipse
);
        public CustomMessageBox(String lbl, String desc)
        {
            InitializeComponent();
            MainInstance.o.Show(MainInstance.i);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            btnOK.Visible = true;
            lblTitle.Text = lbl;
            lblDescription.Text = desc;
        }
        public CustomMessageBox(String lbl, String desc, MessageBoxButtons messageBoxButtons)
        {
            if (messageBoxButtons == MessageBoxButtons.OKCancel)
            {
                InitializeComponent();
                MainInstance.o.Show(MainInstance.i);
                this.FormBorderStyle = FormBorderStyle.None;
                this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
                btnOK.Visible = true;
                btnCancel.Visible = true;
                lblTitle.Text = lbl;
                lblDescription.Text = desc;
            }
            else if (messageBoxButtons == MessageBoxButtons.OK)
            {
                InitializeComponent();
                this.FormBorderStyle = FormBorderStyle.None;
                this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
                btnOK.Visible = true;
                btnCancel.Visible = false;
                lblTitle.Text = lbl;
                lblDescription.Text = desc;
            }
            else
            {
                InitializeComponent();
                this.FormBorderStyle = FormBorderStyle.None;
                this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
                btnOK.Visible = false;
                btnCancel.Visible = false;
                lblTitle.Text = lbl;
                lblDescription.Text = desc;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            MainInstance.o.Hide();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            MainInstance.o.Hide();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            MainInstance.o.Hide();
        }

        public Point mouseLoc;
        public Point bottleMouse;
        private void customPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLoc = new Point(-e.X, -e.Y);
        }

        private void customPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLoc.X, mouseLoc.Y);
                this.Location = mousePos;
            }
        }

        private void CustomMessageBox_Load(object sender, EventArgs e)
        {

        }
    }
}