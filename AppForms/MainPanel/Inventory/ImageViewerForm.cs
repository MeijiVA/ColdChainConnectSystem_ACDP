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

        public void SetImage(Image image, string description = "")
        {
            if (image != null)
            {
                pictureBox.Image = image;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                // Set form size based on popup sizes in the system (similar to CustomMessageBox but larger for images)
                // Using a reasonable popup size: max 800x600
                int maxWidth = 800;
                int maxHeight = 600;

                int imageWidth = image.Width;
                int imageHeight = image.Height;

                // Calculate aspect ratio
                double aspectRatio = (double)imageWidth / imageHeight;

                if (imageWidth > maxWidth || imageHeight > maxHeight)
                {
                    if (aspectRatio > 1)
                    {
                        // Landscape
                        imageWidth = maxWidth;
                        imageHeight = (int)(maxWidth / aspectRatio);
                    }
                    else
                    {
                        // Portrait
                        imageHeight = maxHeight;
                        imageWidth = (int)(maxHeight * aspectRatio);
                    }
                }

                this.ClientSize = new Size(imageWidth + 20, imageHeight + 60);
                pictureBox.Size = new Size(imageWidth, imageHeight);
                pictureBox.Location = new Point(10, 10);

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

