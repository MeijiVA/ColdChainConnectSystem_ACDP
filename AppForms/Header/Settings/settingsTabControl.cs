using ColdChainConnectSystem_ACDP.AppForms.Header.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Settings
{
    public partial class settingsTabControl : UserControl
    {
        bool[] Clickable = new bool[6];
        public settingsTabControl()
        {
            InitializeComponent();

        }
        private void settingsTabControl_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                Clickable[i] = true;
            }
            HideLabel(lblExtra4,3);
            HideLabel(lblExtra5,4);
            HideLabel(lblExtra6,5);
        }

        private void HideLabel(Label l, int i)
        {
            l.Text = "";
            Clickable[i] = false;
        }

        private void LabelClick(Label l)
        {
            lblPersDetail.Location = new Point(lblPersDetail.Location.X, 0);
            lblSecurity.Location = new Point(lblSecurity.Location.X, 0);
            lblEmployee.Location = new Point(lblEmployee.Location.X, 0);
            lblExtra4.Location = new Point(lblExtra4.Location.X, 0);
            lblExtra5.Location = new Point(lblExtra5.Location.X, 0);
            lblExtra6.Location = new Point(lblExtra6.Location.X, 0);
            l.Location = new Point(l.Location.X, -3);
        }


        private void lblPersDetail_Click(object sender, EventArgs e)
        {
            if (Clickable[0] == true)
            {
                LabelClick(lblPersDetail);
                LoginForm.sf.NavigateTo(SettingForm.pdf);
            }
        }
        private void lblSecurity_Click(object sender, EventArgs e)
        {
            if (Clickable[1] == true)
            {
                LabelClick(lblSecurity);
            }
        }

        private void lblExtra3_Click(object sender, EventArgs e)
        {
            if (Clickable[2] == true)
            {
                LabelClick(lblEmployee);
            }
        }

        private void lblExtra4_Click(object sender, EventArgs e)
        {
            if (Clickable[3] == true)
            {
                LabelClick(lblExtra4);
            }
        }

        private void lblExtra5_Click(object sender, EventArgs e)
        {
            if (Clickable[4] == true)
            {
                LabelClick(lblExtra5);
            }
        }

        private void lblExtra6_Click(object sender, EventArgs e)
        {
            if (Clickable[5] == true)
            {
                LabelClick(lblExtra6);
            }
        }

    }
}
