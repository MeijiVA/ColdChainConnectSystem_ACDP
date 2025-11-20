using ColdChainConnectSystem_ACDP.ClassResources;
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
    public partial class AddressInformation : UserControl
    {
        public AddressInformation()
        {
            InitializeComponent();
        }
        public string HouseNum
        {
            get { return lblHouseNum.Text; }
            set { lblHouseNum.Text = value; }
        }
        public string Barangay
        {
            get { return lblBarangay.Text; }
            set { lblBarangay.Text = value; }
        }
        public string City
        {
            get { return lblCity.Text; }
            set { lblCity.Text = value; }
        }
        public string Province
        {
            get { return lblProvince.Text; }
            set { lblProvince.Text = value; }
        }
        public string Postal
        {
            get { return lblPostCode.Text; }
            set { lblPostCode.Text = value; }
        }
        private void AddressInformation_Load(object sender, EventArgs e)
        {

        }
    }
}
