using ColdChainConnectSystem_ACDP.ClassResources;
using ColdChainConnectSystem_ACDP.ClassResources.Instances;
using ColdChainConnectSystem_ACDP.Popup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Inventory
{
    public partial class AddItemInventoryForm : Form
    {
        CustomMessageBox cmb;
        public AddItemInventoryForm()
        {
            InitializeComponent();
            string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            MainInstance.i.NavigateTo(new InventoryForm());
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            ofdSaveImage.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            ofdSaveImage.Title = "Select an Image File";

            if (ofdSaveImage.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Load the selected image into the PictureBox
                    pbxImage.BackgroundImage = Image.FromFile(ofdSaveImage.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            cmb = new CustomMessageBox("Add Item","Confirm?",MessageBoxButtons.OKCancel);
            if (cmb.ShowDialog() == DialogResult.OK)
            {
                if(InventoryClass.writeInventoryData(txtSKU.Texts, txtDescription.Texts, txtUnitPrice.Texts, System.IO.Path.GetFileName(ofdSaveImage.FileName), txtWeight.Texts, txtQuantity.Texts, dpExpiry.Value.ToString("yyyy-MM-dd")))
                {
                    try
                    {
                        string fileName;
                        string filePath = Directory.GetCurrentDirectory() + "\\InventoryImage\\";
                        if (!Directory.Exists(filePath))
                        {
                            // Create the directory
                            Directory.CreateDirectory(filePath);
                        }//no directory
                        Console.WriteLine(ofdSaveImage.FileName);
                        if (ofdSaveImage.FileName.Equals(""))
                        {
                            fileName = "NoImage.png";
                        }// if no image selected
                        else
                        {
                            fileName = ofdSaveImage.FileName;
                        }//if has image
                            pbxImage.BackgroundImage.Save(filePath + System.IO.Path.GetFileName(fileName));
                        this.Close();
                        MainInstance.i.NavigateTo(new InventoryForm());
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
