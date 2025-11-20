using ColdChainConnectSystem_ACDP.ClassResources;
using System;
using System.Windows.Forms;


namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Dashboard
{
    public partial class GreetPanel : UserControl
    {
        public GreetPanel()
        {
            InitializeComponent();
        }

        private void GreetPanel_Load(object sender, EventArgs e)
        {
            greetlbl.Text = "Good to See you, " + ConnectionClass.fname + "!";
            timelbl.Text = DateTime.Now.ToString("HH:mm tt");
            daylbl.Text = DateTime.Now.ToString("dddd");
            datelbl.Text = DateTime.Now.ToString("MMMM dd, yyyy");

        }
    }
}
