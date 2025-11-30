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

namespace ColdChainConnectSystem_ACDP.AppForms.Header.Settings.Employee
{
    public partial class EditAddressInformation : UserControl
    {
        public EditAddressInformation()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // Apply to the form
        }

        public string HouseNum
        {
            get { return txtHouseNum.Texts; }
            set { txtHouseNum.Texts = value; }
        }
        public string Barangay
        {
            get { return txtBarangay.Texts; }
            set { txtBarangay.Texts = value; }
        }
        public string Municipality
        {
            get { return cbxCity.Texts; }
            set { cbxCity.Texts = value; }
        }
        public string Province
        {
            get { return cbxProvince.Texts; }
            set { cbxProvince.Texts = value; }
        }
        public string Postal
        {
            get { return txtPostal.Texts; }
            set { txtPostal.Texts = value; }
        }
        private void AddressEdit_Load(object sender, EventArgs e)
        {

        }

        private void cbxProvince_OnSelectedIndexChanged_1(object sender, EventArgs e)
        {
            cbxCity.Items.Clear();
            cbxCity.Texts = "";
            foreach (string i in MunicipalityListClass.municipality)
            {
                string[] current = i.Split(',');
                string selected = " " + cbxProvince.Texts;
                   if (current[1].Equals(selected))
                {
                    cbxCity.Items.Add(current[0]);
                }
            }
        }

        private void cbxProvince_Leave(object sender, EventArgs e)
        {
            cbxCity.Items.Clear();
            cbxCity.Texts = "";
            foreach (string i in MunicipalityListClass.municipality)
            {
                string[] current = i.Split(',');
                string selected = " " + cbxProvince.Texts;
                if (current[1].Equals(selected))
                {
                    cbxCity.Items.Add(current[0]);
                }
            }
        }

        private void cbxProvince_Layout(object sender, LayoutEventArgs e)
        {

        }
    }
}
