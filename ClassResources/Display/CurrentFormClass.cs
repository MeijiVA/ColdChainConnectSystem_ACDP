using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColdChainConnectSystem_ACDP.ClassResources
{
    internal class CurrentFormClass
    {
        public static string form { get; set; }

        public static void setPreviousFormTo(string name)
        {
            form = name;
            MainForm.settingFlag = 1;
            Console.WriteLine(name);
        }
    }


}
