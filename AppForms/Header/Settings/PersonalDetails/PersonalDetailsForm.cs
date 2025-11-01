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
            PersonalUserControl.First_NameInfo = ConnectionClass.fname;
            PersonalUserControl.Middle_NameInfo = ConnectionClass.mname;
            PersonalUserControl.Last_NameInfo = ConnectionClass.lname;
            PersonalUserControl.AgeInfo = ConnectionClass.age;
            PersonalUserControl.DOBInfo = ConnectionClass.dob;
            PersonalUserControl.SexInfo = ConnectionClass.sex;


            ContactUserControl.PositionInfo = ConnectionClass.position;
            ContactUserControl.StatusInfo = ConnectionClass.status;
            ContactUserControl.ConNum = ConnectionClass.contnum;
            ContactUserControl.EmailInfo = ConnectionClass.empid;
            lblEmpID.Text = "    Employee ID : " + ConnectionClass.empid;

            string[] address = ConnectionClass.address.Split(',');
            AddressUserControl.HouseNum = address[0];
            AddressUserControl.Barangay = address[1];
            AddressUserControl.City = address[2];
            AddressUserControl.Province = address[3];
            AddressUserControl.Postal = address[4];

        }
    }
}
