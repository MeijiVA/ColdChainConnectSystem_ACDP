using ColdChainConnectSystem_ACDP.ClassResources;
using ColdChainConnectSystem_ACDP.ClassResources.Display;
using ColdChainConnectSystem_ACDP.ClassResources.Instances;
using ColdChainConnectSystem_ACDP.Popup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Inventory
{
    public partial class EditItemInventory : Form
    {
        public EditItemInventory()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // Apply to the form
        }

        private void EditItemInventory_Load(object sender, EventArgs e)
        {
            InventoryClass.SetSuppliers(lblSupplierID);
            string query = $"SELECT * FROM Inventory WHERE [numid] = {ClassResources.Instances.VarView.id}";
            SqlConnection con = ConnectionClass.Connection();
            con.Open();
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {//num  custid custname phonenum address payterm regdate status
                        lblID.Text = "NUM ID : [" + reader[0].ToString() + "]";
                        lblSKU.Texts = reader[1].ToString();
                        lblUnitPrice.Texts = reader[2].ToString();
                        lblWeight.Texts = reader[3].ToString();
                        lblQuantity.Texts = reader[4].ToString();
                        dpExpiry.Value = Convert.ToDateTime(reader[5]);
                        //pboxExpiry reader[6]
                        lblDescription.Texts = reader[7].ToString();
                        lblSupplierID.Texts = reader[8].ToString();
                        //Image
                        pboxImage.BackgroundImage = InventoryClass.getImage(reader[6].ToString());

                    }
                }
            }
            con.Close();
        }
        private void btnExitView_Click(object sender, EventArgs e)
        {
            if(InventoryClass.updateInventoryData(VarView.id, lblSKU.Texts, lblDescription.Texts, lblUnitPrice.Texts, System.IO.Path.GetFileName(ofdSaveImage.FileName), lblWeight.Texts, lblQuantity.Texts, dpExpiry.Value.ToString("yyyy-MM-dd"), lblSupplierID.Texts))
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
                    if (ofdSaveImage.FileName.Equals(""))
                    {
                        fileName = "NoImage.png";
                    }// if no image selected
                    else
                    {
                        fileName = ofdSaveImage.FileName;
                    }//if has image
                    pboxImage.BackgroundImage.Save(filePath + System.IO.Path.GetFileName(fileName));
                    this.Close();
                    MainInstance.i.NavigateTo(new InventoryForm());
                    InventoryInstance.i.UpdateTable();
                }
                catch (Exception ex)
                {
                    new CustomMessageBox("Missing Element", ex.Message, MessageBoxButtons.OK).ShowDialog();
                }
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            ofdSaveImage.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            ofdSaveImage.Title = "Select an Image File";

            if (ofdSaveImage.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Load the selected image into the PictureBox
                    pboxImage.BackgroundImage = Image.FromFile(ofdSaveImage.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
