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
    public partial class EditAccountInformation : UserControl
    {
        private OpenFileDialog ofdSaveImage;

        public EditAccountInformation()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // Apply to the form
            ofdSaveImage = new OpenFileDialog();

            // Initialize position combobox
            if (cbxPosition != null)
            {
                cbxPosition.Items.Clear();
                cbxPosition.Items.Add("Administrator");
                cbxPosition.Items.Add("Assistant");
                cbxPosition.Items.Add("Inventory");
                cbxPosition.Items.Add("Sales");
            }
        }
        public string PositionInfo
        {
            get { return cbxPosition.Texts; }
            set { cbxPosition.Texts = value; }
        }
        public string ContactInfo
        {
            get { return txtContact.Texts; }
            set { txtContact.Texts = value; }
        }

        public string StatusInfo
        {
            get { return lblStatus.Text; }
            set { lblStatus.Text = value; }
        }

        public string EmailInfo
        {
            get { return txtEmail.Texts; }
            set { txtEmail.Texts = value; }
        }

        public Image ProfileImage
        {
            get { return pbxProfile.BackgroundImage; }
            set { pbxProfile.BackgroundImage = value; }
        }

        public string ImageFileName
        {
            get { return ofdSaveImage.FileName; }
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            ofdSaveImage.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            ofdSaveImage.Title = "Select an Image File";

            if (ofdSaveImage.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Load the selected image into the PictureBox
                    pbxProfile.BackgroundImage = Image.FromFile(ofdSaveImage.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbxPosition_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            PositionInfo = cbxPosition.Texts;
        }

        private void tscStatus_CheckChanged(object sender, EventArgs e)
        {
            if (tscStatus.Checked)
            {
                StatusInfo = "Active";
                tscStatus.ToggleBarText = "Active";
                tscStatus.ToggleCircleColor = Color.Green;
            }
            else
            {
                StatusInfo = "Inactive";
                tscStatus.ToggleBarText = "Inactive";
                tscStatus.ToggleCircleColor = Color.Red;
            }
        }
    }
}
