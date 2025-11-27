using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColdChainConnectSystem_ACDP.AppForms.Header.Settings.PersonalDetails
{
    public partial class AccountInformation : UserControl
    {
        public AccountInformation()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // Apply to the form
        }
        public string PositionInfo
        {
            get { return lblPosition.Text; }
            set { lblPosition.Text = value; }
        }
        public string ConNum
        {
            get { return lblConNum.Text; }
            set { lblConNum.Text = value; }
        }

        public string StatusInfo
        {
            get { return lblStatus.Text; }
            set { lblStatus.Text = value; }
        }

        public string EmailInfo
        {
            get { return lblEmail.Text; }
            set { lblEmail.Text = value; }
        }

    }
}
