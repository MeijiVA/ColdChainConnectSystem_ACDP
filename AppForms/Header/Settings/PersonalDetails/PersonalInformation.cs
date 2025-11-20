using System;
using System.Windows.Forms;

namespace ColdChainConnectSystem_ACDP.AppForms.Header.Settings.PersonalDetails
{
    public partial class Personal_Information : UserControl
    {
        public Personal_Information()
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
