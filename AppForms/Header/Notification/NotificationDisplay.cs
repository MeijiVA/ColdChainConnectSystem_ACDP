using ColdChainConnectSystem_ACDP.AppForms.Header.Settings.Employee;
using ColdChainConnectSystem_ACDP.ClassResources;
using ColdChainConnectSystem_ACDP.ClassResources.Display;
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

namespace ColdChainConnectSystem_ACDP.AppForms.Header.Notification
{
    public partial class NotificationDisplay : UserControl
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

        public NotificationDisplay()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        public void LoadAllNotifs()
        {
            flowLayoutNotif.Controls.Clear();
            int numCount = NotificationClass.GetTotalNotifs();
            for (int i = 1; i <= numCount; i++)
            {
                NotifBar e = new NotifBar();
                e.notifID = NotificationClass.LoadNotifs(i, e.lblEmpID, e.lblDescription);
                flowLayoutNotif.Controls.Add(e);
            }
        }

        private void NotificationDisplay_Load(object sender, EventArgs e)
        {

        }

        private void customPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customPanel1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
