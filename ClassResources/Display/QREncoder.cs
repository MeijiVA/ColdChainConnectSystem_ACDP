using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColdChainConnectSystem_ACDP.ClassResources.Display
{
    internal class QREncoder
    {

        public static Bitmap GenerateQRCode(string data, int pixelSize = 10, QRCodeGenerator.ECCLevel eccLevel = QRCodeGenerator.ECCLevel.Q)
        {
            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            {
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(data, eccLevel);
                using (QRCode qrCode = new QRCode(qrCodeData))
                {
                    // Create a Bitmap image from the QR code data
                    Bitmap qrCodeImage = qrCode.GetGraphic(pixelSize);
                    return qrCodeImage;
                }
            }
        }

    }
}
