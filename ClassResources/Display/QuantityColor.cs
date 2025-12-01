using ColdChainConnectSystem_ACDP.Popup;
using CustomControls.RJControls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColdChainConnectSystem_ACDP.ClassResources.Display
{
    internal class QuantityColor
    {
        public static void CreateTxt(string fileName, string defaultContent = "100")
        {
            // 1. Determine the full file path
            string currentDirectory = Directory.GetCurrentDirectory();
            string filePath = Path.Combine(currentDirectory, fileName);

            try
            {
                if (!File.Exists(filePath))
                {
                    File.WriteAllText(filePath, defaultContent);
                }
            }
            catch (Exception ex)
            {
                new CustomMessageBox("Exception", ex.Message, MessageBoxButtons.OK).ShowDialog();
            }
        }

        public static int QuantityThreshold = 0;
        public static void LoadQuantity(string fileName)
        {
            string newPath = Directory.GetCurrentDirectory() +"\\"+ fileName;
            using (StreamReader sr = File.OpenText(newPath))
            {
                string _getText = "";
                    while ((_getText = sr.ReadLine()) != null)
                    {
                        QuantityThreshold =  Convert.ToInt32(_getText);
                    }
               
            }
        }

        public static void WriteQuantity(string fileName, CustomTextBox tbox)
        {
            string newPath = Directory.GetCurrentDirectory() + "\\" + fileName;
            StreamWriter sw = new StreamWriter(newPath);
            QuantityThreshold = Convert.ToInt32(tbox.Texts);
            sw.Write(QuantityThreshold);
            sw.Flush();
            sw.Close();
        }




    }
}
