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

namespace ColdChainConnectSystem_ACDP.AppForms.Header.Settings.Employee
{
    public partial class AddressEdit : UserControl
    {
        public AddressEdit()
        {
            InitializeComponent();
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


    }
}
