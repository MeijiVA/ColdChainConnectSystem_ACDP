using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ColdChainConnectSystem_ACDP.ClassResources.Display
{
    internal class InventoryColumn
    {
        public static DataGridViewCellStyle dcsText()
        {
            DataGridViewCellStyle cs = new DataGridViewCellStyle();
            cs.WrapMode = DataGridViewTriState.True;
            return cs;
        }

        public static DataGridViewCellStyle dcsImage()
        {
            DataGridViewCellStyle cs = new DataGridViewCellStyle();
            cs.NullValue = null;
            cs.Alignment = DataGridViewContentAlignment.MiddleCenter;
            cs.WrapMode = DataGridViewTriState.True;
            return cs;
        }






        public static DataGridViewTextBoxColumn columnSkuCode() 
        {
            
            DataGridViewTextBoxColumn sku = new DataGridViewTextBoxColumn();
            sku.HeaderText = "SKU Code";
            sku.Name = "skucode";
            sku.Width = 90;
            sku.DefaultCellStyle = dcsText();
            sku.Resizable = DataGridViewTriState.False;
            return sku;
        }
        public static DataGridViewTextBoxColumn columnDescription()
        {
            DataGridViewTextBoxColumn desc = new DataGridViewTextBoxColumn();
            desc.HeaderText = "Description";
            desc.Name = "desc";
            desc.Width = 170;
            desc.DefaultCellStyle = dcsText();
            desc.Resizable = DataGridViewTriState.False;
            return desc;
        }
        public static DataGridViewImageColumn columnImage()
        {
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img.HeaderText = "Image";
            img.ImageLayout = DataGridViewImageCellLayout.Zoom;
            img.Name = "img";
            img.Width = 90;
            img.DefaultCellStyle = dcsImage();
            img.Resizable = DataGridViewTriState.False;
            return img;
        }

        public static DataGridViewTextBoxColumn columnUnitPrice()
        {
            DataGridViewTextBoxColumn unitp = new DataGridViewTextBoxColumn();
            unitp.HeaderText = "Unit Price";
            unitp.Name = "unitp";
            unitp.Width = 100;
            unitp.DefaultCellStyle = dcsText();
            unitp.Resizable = DataGridViewTriState.False;
            return unitp;
        }
        public static DataGridViewTextBoxColumn columnAmount()
        {
            DataGridViewTextBoxColumn amt = new DataGridViewTextBoxColumn();
            amt.HeaderText = "Amount";
            amt.Name = "amt";
            amt.Width = 100;
            amt.DefaultCellStyle = dcsText();
            amt.Resizable = DataGridViewTriState.False;
            return amt;
        }
        public static DataGridViewTextBoxColumn columnKG()
        {
            DataGridViewTextBoxColumn kg = new DataGridViewTextBoxColumn();
            kg.HeaderText = "KG";
            kg.Name = "kg";
            kg.Width = 40;
            kg.DefaultCellStyle = dcsText();
            kg.Resizable = DataGridViewTriState.False;
            return kg;
        }
        public static DataGridViewTextBoxColumn columnQuantity()
        {
            DataGridViewTextBoxColumn qty = new DataGridViewTextBoxColumn();
            qty.HeaderText = "Quantity";
            qty.Name = "quant";
            qty.Width = 70;
            qty.DefaultCellStyle = dcsText();
            qty.Resizable = DataGridViewTriState.False;
            return qty;
        }
    }
}
