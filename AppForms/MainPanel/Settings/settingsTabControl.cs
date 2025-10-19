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
        bool[] Clickable = new bool[6];
        bool[] ClickFlag = new bool[6];
        public settingsTabControl()
        {
            InitializeComponent();
        }
        private void settingsTabControl_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 6; i++)
            {
                ClickFlag[i] = false;
            }
            
            HideLabel(lblEmployee,3);
            HideLabel(lblExtra4,4);
            HideLabel(lblExtra5,5);
            HideLabel(lblExtra6,6);
        }

        private void HideLabel(Label l, int i)
        {
            l.Text = "";
            Clickable[i] = false;
        }
        private void LabelClick(Boolean c, Label l)
        {
            switch (c)
            {
                case true:
                    c = false;
                    l.Location = new Point(l.Location.X, -3);
                    break;
                case false:
                    c = true;
                    l.Location = new Point(l.Location.X, 0);
                    break;
            }
        }


        private void lblPersDetail_Click(object sender, EventArgs e)
        {
            if (Clickable[0] == true)
            {
                LabelClick(ClickFlag[0], lblPersDetail);
            }
        }
        private void lblSecurity_Click(object sender, EventArgs e)
        {
            if (Clickable[0] == true)
            {
                LabelClick(ClickFlag[0], lblSecurity);
            }
        }

        private void lblExtra3_Click(object sender, EventArgs e)
        {
            if (Clickable[3] == true)
            {
                LabelClick(ClickFlag[3], lblEmployee);
            }
        }

        private void lblExtra4_Click(object sender, EventArgs e)
        {
            if (Clickable[4] == true)
            {
                LabelClick(ClickFlag[4], lblExtra4);
            }
        }

        private void lblExtra5_Click(object sender, EventArgs e)
        {
            if (Clickable[5] == true)
            {
                LabelClick(ClickFlag[5], lblExtra5);
            }
        }

        private void lblExtra6_Click(object sender, EventArgs e)
        {
            if (Clickable[6] == true)
            {
                LabelClick(ClickFlag[6], lblSecurity);
            }
        }

    }
}
