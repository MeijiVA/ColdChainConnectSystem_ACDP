using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ColdChainConnectSystem_ACDP.ClassResources;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ColdChainConnectSystem_ACDP.AppForms.Header.Settings.PersonalDetails
{
    public partial class EditPersonalInformation : UserControl
    {
        public EditPersonalInformation()
        {
            InitializeComponent();
        }

        public string First_NameInfo
        {
            get { return lblFName.Text; }
            set { lblFName.Text = value; }
        }
        public string Middle_NameInfo
        {
            get { return lblMName.Text; }
            set { lblMName.Text = value; }
        }
        public string Last_NameInfo
        {
            get { return lblLName.Text; }
            set { lblLName.Text = value; }
        }

        public string AgeInfo
        {
            get { return lblAge.Text; }
            set { lblAge.Text = value; }
        }

        public string DOBInfo
        {
            get { return lblDOB.Text; }
            set { lblDOB.Text = value; }
        }
        public string SexInfo
        {
            get { return lblGender.Text; }
            set { lblGender.Text = value; }
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Personal_Information_Load(object sender, EventArgs e)
        {

        }
    }
}
