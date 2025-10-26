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

namespace ColdChainConnectSystem_ACDP.AppForms.Header.Settings.PersonalDetails
{
    public partial class Personal_Information : UserControl
    {
        public Personal_Information()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Personal_Information_Load(object sender, EventArgs e)
        {
            lblFName.Text = ConnectionClass.fname;
            lblMName.Text = ConnectionClass.mname;
            lblLName.Text = ConnectionClass.lname;
            lblAge.Text = ConnectionClass.age;
            lblDOB.Text = ConnectionClass.dob;
            lblGender.Text = ConnectionClass.sex;
        }
    }
}
