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
    public partial class EditAccountInformation : UserControl
    {
        public EditAccountInformation()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // Apply to the form
        }
        public string PositionInfo
        {
            get { return lblPosition.Text; }
            set { lblPosition.Text = value; }
        }
        public string ContactInfo
        {
            get { return txtContact.Texts; }
            set { txtContact.Texts = value; }
        }

        public string StatusInfo
        {
            get { return lblStatus.Text; }
            set { lblStatus.Text = value; }
        }

        public string EmailInfo
        {
            get { return txtEmail.Texts; }
            set { txtEmail.Texts = value; }
        }

    }
}
