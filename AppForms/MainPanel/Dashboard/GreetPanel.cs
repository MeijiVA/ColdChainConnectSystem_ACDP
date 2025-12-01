using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ColdChainConnectSystem_ACDP.ClassResources;


namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Dashboard
{
    public partial class GreetPanel : UserControl
    {
        public GreetPanel()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // Apply to the form
        }

        private void GreetPanel_Load(object sender, EventArgs e)
        {
            greetlbl.Text = "Good to See you, " + ConnectionClass.fname + "!";
            timelbl.Text = DateTime.Now.ToString("HH:mm tt");
            daylbl.Text = DateTime.Now.ToString("dddd");
            datelbl.Text = DateTime.Now.ToString("MMMM dd, yyyy");

        }

        private void customPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
