using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Inventory
{
    public partial class SearchUC : UserControl
    {
        DisplayClass dc = new DisplayClass();
        public SearchUC()
        {
            InitializeComponent();

        }

        public string searchTXT
        {
            get { return this.txtSearchBar.Texts; }
            set { this.txtSearchBar.Texts = value; }
        }
        private void customTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearchBar_Enter(object sender, EventArgs e)
        {
            if (txtSearchBar.Texts.Equals("Search Term"))
            {
                txtSearchBar.Texts = "";
            }

        }

        private void txtSearchBar_Leave(object sender, EventArgs e)
        {
            if (txtSearchBar.Texts.Equals(""))
            {
                txtSearchBar.Texts = "Search Term";
            }
        }
    }
}
