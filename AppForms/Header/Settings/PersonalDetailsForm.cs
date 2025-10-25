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

namespace ColdChainConnectSystem_ACDP.AppForms.Header.Settings
{
    public partial class PersonalDetailsForm : Form
    {
        public PersonalDetailsForm()
        {
            InitializeComponent();
        }

        private void PersonalDetailsForm_Load(object sender, EventArgs e)
        {
            txtFName.Text = ConnectionClass.fname;
            txtMName.Text = ConnectionClass.mname;
            txtLName.Text = ConnectionClass.lname;
            txtAge.Text = ConnectionClass.age;
            dtpDOB.Value = Convert.ToDateTime(ConnectionClass.dob);
            txtAddress.Text = ConnectionClass.address;
        }
    }
}
