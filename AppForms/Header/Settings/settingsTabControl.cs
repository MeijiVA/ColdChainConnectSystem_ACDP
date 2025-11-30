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
            this.DoubleBuffered = true; // Apply to the form
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
            LabelStatus("hide", lblExtra3,3, "");
            LabelStatus("hide", lblExtra1,4, "");
            LabelStatus("hide", lblExtra2,5, "");

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
            lblExtra3.Location = new Point(lblExtra3.Location.X, 0);
            lblExtra1.Location = new Point(lblExtra1.Location.X, 0);
            lblExtra2.Location = new Point(lblExtra2.Location.X, 0);
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

        private void lblAudit_Click(object sender, EventArgs e)
        {
            if (Clickable[2] == true)
            {
                LabelClick(lblAudit);
                SettingsInstance.i.NavigateTo(SettingForm.audf);
            }
        }

        private void lblExtra1_Click(object sender, EventArgs e)
        {
            if (Clickable[3] == true)
            {
                LabelClick(lblExtra1);

            }
        }

        private void lblExtra2_Click(object sender, EventArgs e)
        {
            if (Clickable[4] == true)
            {
                LabelClick(lblExtra2);
            }
        }

        private void lblExtra3_Click(object sender, EventArgs e)
        {
            if (Clickable[5] == true)
            {
                LabelClick(lblExtra3);
            }
        }
    }
}
