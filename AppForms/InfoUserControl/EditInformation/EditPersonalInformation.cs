using ColdChainConnectSystem_ACDP.ClassResources;
using Microsoft.Office.Interop.Excel;
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

namespace ColdChainConnectSystem_ACDP.AppForms.Header.Settings.PersonalDetails
{
    public partial class EditPersonalInformation : UserControl
    {
        public EditPersonalInformation()
        {
            InitializeComponent();
        }

        public string First_NAMEInfo
        {
            get { return txtFNAME.Texts; }
            set { txtFNAME.Texts = value; }
        }
        public string Middle_NAMEInfo
        {
            get { return txtMNAME.Texts; }
            set { txtMNAME.Texts = value; }
        }
        public string Last_NAMEInfo
        {
            get { return txtLNAME.Texts; }
            set { txtLNAME.Texts = value; }
        }

        public string AgeInfo
        {
            get { return txtAge.Texts; }
            set { txtAge.Texts = value; }
        }

        public DateTime DOBInfo
        {
            get { return dpDOB.Value; }
            set { dpDOB.Value = value; }
        }
        public string SexInfo
        {
            get { return cbSex.Texts; }
            set { cbSex.Texts = value; }
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Personal_Information_Load(object sender, EventArgs e)
        {

        }
    }
}
