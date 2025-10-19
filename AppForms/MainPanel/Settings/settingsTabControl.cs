using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Settings
{
    public partial class settingsTabControl : UserControl
    {
        bool ClickFlag1;
        bool ClickFlag2;
        bool ClickFlag3;
        bool ClickFlag4;
        bool ClickFlag5;
        bool ClickFlag6;
        public settingsTabControl()
        {
            InitializeComponent();
        }
        private void settingsTabControl_Load(object sender, EventArgs e)
        {
            ClickFlag1 = false;
            ClickFlag2 = false;
            ClickFlag3 = false;
            ClickFlag4 = false;
            ClickFlag5 = false;
            ClickFlag6 = false;
        }



        private void lblPersDetail_Click(object sender, EventArgs e)
        {
            switch (ClickFlag1)
            {
                case true:
                    ClickFlag1 = false;
                    lblPersDetail.Location = new Point(0, -3);
                    break;
                case false:
                    ClickFlag1 = true;
                    lblPersDetail.Location = new Point(0, 0);
                    break;
            }
        }

        private void lblSecurity_Click(object sender, EventArgs e)
        {
            switch (ClickFlag2)
            {
                case true:
                    ClickFlag2 = false;
                    lblSecurity.Location = new Point(120, -3);
                    break;
                case false:
                    ClickFlag2 = true;
                    lblSecurity.Location = new Point(120, 0);
                    break;
            }
        }

        private void lblExtra3_Click(object sender, EventArgs e)
        {
            switch (ClickFlag3)
            {
                case true:
                    ClickFlag3 = false;
                    lblEmployee.Location = new Point(240, -3);
                    break;
                case false:
                    ClickFlag3 = true;
                    lblEmployee.Location = new Point(240, 0);
                    break;
            }
        }

        private void lblExtra4_Click(object sender, EventArgs e)
        {
            switch (ClickFlag4)
            {
                case true:
                    ClickFlag4 = false;
                    lblExtra4.Location = new Point(360, -3);
                    break;
                case false:
                    ClickFlag4 = true;
                    lblExtra4.Location = new Point(360, 0);
                    break;
            }
        }

        private void lblExtra5_Click(object sender, EventArgs e)
        {
            switch (ClickFlag5)
            {
                case true:
                    ClickFlag5 = false;
                    lblExtra5.Location = new Point(480, -3);
                    break;
                case false:
                    ClickFlag5 = true;
                    lblExtra5.Location = new Point(480, 0);
                    break;
            }
        }

        private void lblExtra6_Click(object sender, EventArgs e)
        {
            switch (ClickFlag6)
            {
                case true:
                    ClickFlag6 = false;
                    lblExtra6.Location = new Point(600, -3);
                    break;
                case false:
                    ClickFlag6 = true;
                    lblExtra6.Location = new Point(600, 0);
                    break;
            }
        }

    }
}
