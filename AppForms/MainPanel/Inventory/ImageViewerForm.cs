using System;
using System.Drawing;
using System.Windows.Forms;

namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Inventory
{
    public partial class ImageViewerForm : Form
    {
        private PictureBox pictureBox;

        public ImageViewerForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        // Fixed size for all images - matching a reasonable viewing size
        private const int FixedImageWidth = 400;
        private const int FixedImageHeight = 400;

        public void SetImage(Image image, string description = "")
        {
            if (image != null)
            {
                pictureBox.Image = image;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                // Set fixed size for all images - same size for every image
                pictureBox.Size = new Size(FixedImageWidth, FixedImageHeight);
                pictureBox.Location = new Point(10, 10);

                // Set form size to match the fixed image size
                this.ClientSize = new Size(FixedImageWidth + 20, FixedImageHeight + 60);

                // Set form title based on description
                if (!string.IsNullOrEmpty(description))
                {
                    this.Text = description;
                }
                else
                {
                    this.Text = "Image Viewer";
                }
            }
        }

        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(10, 10);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(400, 400);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // ImageViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 460);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImageViewerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

