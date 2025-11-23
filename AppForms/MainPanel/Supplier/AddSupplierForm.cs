using ColdChainConnectSystem_ACDP.AppForms.MainPanel.Sales;
using ColdChainConnectSystem_ACDP.ClassResources;
using ColdChainConnectSystem_ACDP.ClassResources.Instances;
using ColdChainConnectSystem_ACDP.Popup;
using Microsoft.Office.Interop.Excel;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Supplier
{
    public partial class AddSupplierForm : Form
    {
        CustomMessageBox cmb;
        public AddSupplierForm()
        {
            InitializeComponent();
            string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            MainInstance.i.NavigateTo(new SupplierForm());
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
                        String Address = txtHouseNum.Texts + "," + txtBarangay.Texts +","+ cbxCity.Texts +","+ cbxProvince.Texts +"," +txtPostalCode.Texts;
                        Console.WriteLine(Address);
                        if(SupplierClass.writeSupplierData(txtCompanyName.Texts,txtContactPerson.Texts,txtContactNumber.Texts,Address, cbxPaymentTerm.Texts))
                        {
                            this.Close();
                            MainInstance.i.NavigateTo(SupplierInstance.i);
                        }
                    }
                    catch (Exception ex)
                    {
                        cmb = new CustomMessageBox("Missing Element", ex.Message, MessageBoxButtons.OK);
                        cmb.Show();
                    }
                }

            }
            //  0        0    1    2    3     4        blank   5      6         7            8              9
            //checkbox,  id, sku, desc,img,unitprice, amount, kg, quantity, buttonedit, button view, button delete
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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
        }

        private void cbxProvince_OnSelectedIndexChanged(object sender, EventArgs e)
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
