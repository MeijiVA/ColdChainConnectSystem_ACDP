using ColdChainConnectSystem_ACDP.ClassResources;
using ColdChainConnectSystem_ACDP.ClassResources.Instances;
using ColdChainConnectSystem_ACDP.Popup;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Customer
{
    public partial class AddCustomerForm : Form
    {
        CustomMessageBox cmb;
        public AddCustomerForm()
        {
            InitializeComponent();
            string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            MainInstance.i.NavigateTo(new CustomerForm());
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            cmb = new CustomMessageBox("Add Supplier", "Confirm?", MessageBoxButtons.OKCancel);
            if (cmb.ShowDialog() == DialogResult.OK)
            {
                {
                    try
                    {
                        if (txtHouseNum.Texts.Equals("") || txtBarangay.Texts.Equals("") || cbxCity.Texts.Equals("") || cbxProvince.Texts.Equals("") || txtPostalCode.Texts.Equals(""))
                        {
                            throw new Exception("Fill in all Fields");
                        }
                        String Address = txtHouseNum.Texts + "," + txtBarangay.Texts + "," + cbxCity.Texts + "," + cbxProvince.Texts + "," + txtPostalCode.Texts;
                        Console.WriteLine(Address);
                        if (CustomerClass.writeCustomerData(txtCustomerName.Texts, txtPhoneNumber.Texts, dpRegDate.Value.ToString("yyyy-MM-dd"), Address, cbxPaymentTerm.Texts, cbxStatus.Texts))
                        {//custName phonenum regdate address payterm status
                            this.Close();
                            MainInstance.i.NavigateTo(CustomerInstance.i);
                            CustomerInstance.i.UpdateTable();
                        }
                    }
                    catch (Exception ex)
                    {
                        cmb = new CustomMessageBox("Missing Element", ex.Message, MessageBoxButtons.OK);
                        cmb.Show();
                    }
                }

            }
        }
        private void customTextBox6_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void AddItemInventoryForm_Load(object sender, EventArgs e)
        {
            // Add payment term values
            cbxPaymentTerm.Items.Clear();
            cbxPaymentTerm.Items.Add("GCASH");
            cbxPaymentTerm.Items.Add("CASH");
            cbxPaymentTerm.Items.Add("MAYA");
            cbxPaymentTerm.Items.Add("BANK");

            // Add customer status values
            cbxStatus.Items.Clear();
            cbxStatus.Items.Add("Active");
            cbxStatus.Items.Add("Inactive");

            // Set default date to today
            dpRegDate.Value = DateTime.Now;
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

        private void lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
