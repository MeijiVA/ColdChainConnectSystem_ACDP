using ColdChainConnectSystem_ACDP.ClassResources;
using ColdChainConnectSystem_ACDP.ClassResources.Instances;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
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

            LabelStatus("hide", lblPersDetail, 3, "");
            LabelStatus("hide", lblSecurity, 4, "");
            LabelStatus("hide", lblAudit, 5, "");
            LabelStatus("hide", lblExtra4,3, "");
            LabelStatus("hide", lblExtra5,4, "");
            LabelStatus("hide", lblExtra6,5, "");

            switch (LoginForm.verify)
            {
            case "admin":
                    LabelStatus("show", lblPersDetail, 0,"Personal Detail");
                    LabelStatus("show", lblSecurity, 1, "Security");
                    LabelStatus("show", lblAudit, 2, "Audit Log");
                    break;
            case "assist":
            case "sales":
            case "inv":
                    LabelStatus("show", lblPersDetail, 0, "Personal Detail");
                    LabelStatus("show", lblSecurity, 1, "Security");
                    break;
            }
        }

        private void LabelStatus(String state, Label l, int i,String txt)
        {
            switch (state)
            {
                case "show":
                    l.Text = txt;
                    Clickable[i] = true;
                    break;

                case "hide":
                    l.Text = "";
                    Clickable[i] = false;
                    break;
            }

        }


        private void LabelClick(Label l)
        {
            lblPersDetail.Location = new Point(lblPersDetail.Location.X, 0);
            lblSecurity.Location = new Point(lblSecurity.Location.X, 0);
            lblAudit.Location = new Point(lblAudit.Location.X, 0);
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
                SettingsInstance.i.NavigateTo(SettingForm.pdf);
            }
        }
        private void lblSecurity_Click(object sender, EventArgs e)
        {
            if (Clickable[1] == true)
            {
                
                LabelClick(lblSecurity);
                SettingsInstance.i.NavigateTo(SettingForm.secf);
            }
        }

        private void lblExtra3_Click(object sender, EventArgs e)
        {
            if (Clickable[2] == true)
            {
                LabelClick(lblExtra4);

            }
        }

        private void lblExtra4_Click(object sender, EventArgs e)
        {
            if (Clickable[3] == true)
            {
                LabelClick(lblAudit);
                /*SettingsInstance.i.NavigateTo(SettingForm.empf);*/
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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
