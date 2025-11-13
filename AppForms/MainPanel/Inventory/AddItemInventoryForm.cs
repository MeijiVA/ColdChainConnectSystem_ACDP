using ColdChainConnectSystem_ACDP.ClassResources;
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
        public AddItemInventoryForm()
        {
            InitializeComponent();
            string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm.mf.NavigateTo(new InventoryForm());
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
                    pbxImage.Image = Image.FromFile(ofdSaveImage.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            string filePath = Directory.GetCurrentDirectory() + "\\InventoryImage\\";
            if (!Directory.Exists(filePath))
            {
                // Create the directory
                Directory.CreateDirectory(filePath);
            }
            pbxImage.Image.Save(filePath + System.IO.Path.GetFileName(ofdSaveImage.FileName));

            //  0        0    1    2    3     4        blank   5      6         7            8              9
            //checkbox,  id, sku, desc,img,unitprice, amount, kg, quantity, buttonedit, button view, button delete
        }

    }
}
