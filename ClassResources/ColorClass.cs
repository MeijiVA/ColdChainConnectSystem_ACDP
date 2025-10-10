using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColdChainConnectSystem_ACDP
{
    public abstract class CColor
    {
        public abstract Color SetCustomColor(string color);
    }


    internal class ColorClass : CColor
    {
        public override Color SetCustomColor(string color)
        {
            Color custColor = ColorTranslator.FromHtml(color);
            return custColor;
        }
    }
}
