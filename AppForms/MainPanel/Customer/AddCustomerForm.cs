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
            cmb = new CustomMessageBox("Add Item", "Confirm?", MessageBoxButtons.OKCancel);
            if (cmb.ShowDialog() == DialogResult.OK)
            {
                //fix this later meiji ok!
               /* if (CustomerClass.writeCustomerData())*/
                {
                    try
                    {

                        this.Close();
                        MainInstance.i.NavigateTo(new CustomerForm());
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

        }


    }
}
