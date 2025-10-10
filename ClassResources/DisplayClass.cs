using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColdChainConnectSystem_ACDP
{
    public abstract class CColor
    {
        public abstract Color SetCustomColor(string color);
        public abstract void SetDisplayRectangle(Button b);
        public abstract void SetDisplayRectangle(Panel b);
    }


    internal class DisplayClass : CColor
    {
        public override Color SetCustomColor(string color)
        {
            Color custColor = ColorTranslator.FromHtml(color);
            return custColor;
        }



        public override void SetDisplayRectangle(Button b)
        {
            GraphicsPath p = new GraphicsPath();
            Rectangle Rect = new Rectangle(0, 0, b.Width, b.Height);
            p.AddArc(Rect.X, Rect.Y, 50, 50, 180, 90);
            p.AddArc(Rect.X + Rect.Width - 50, Rect.Y, 50, 50, 270, 90);
            p.AddArc(Rect.X + Rect.Width - 50, Rect.Y + Rect.Height - 50, 50, 50, 0, 90);
            p.AddArc(Rect.X, Rect.Y + Rect.Height - 50, 50, 50, 90, 90);
            b.Region = new Region(p);
        }

        public override void SetDisplayRectangle(Panel b)
        {
            GraphicsPath p = new GraphicsPath();
            Rectangle Rect = new Rectangle(0, 0, b.Width, b.Height);
            p.AddArc(Rect.X, Rect.Y, 50, 50, 180, 90);
            p.AddArc(Rect.X + Rect.Width, Rect.Y, 50, 50, 270, 90);
            p.AddArc(Rect.X + Rect.Width, Rect.Y + Rect.Height - 50, 50, 50, 0, 90);
            p.AddArc(Rect.X, Rect.Y + Rect.Height, 50, 50, 90, 90);
            b.Region = new Region(p);
        }
    }
}
