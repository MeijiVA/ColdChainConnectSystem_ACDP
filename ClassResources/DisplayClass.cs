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
        public abstract void SetDisplayRectangle(Panel p,int arc1,int arc2,int arc3,int arc4);
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

        public override void SetDisplayRectangle(Panel p, int arc1, int arc2, int arc3, int arc4)
        {
            GraphicsPath g = new GraphicsPath();
            Rectangle rec = new Rectangle(0, 0, p.Width, p.Height);
            g.AddArc(rec.X, rec.Y, 1 + arc1, 1 + arc1, 180, 90);
            g.AddArc(rec.X + rec.Width - arc2, rec.Y, 50, 50, 270, 90);
            g.AddArc(rec.X + rec.Width - arc3, rec.Y + rec.Height - 50, 50, 50, 0, 90);
            g.AddArc(rec.X, rec.Y + rec.Height - arc4, 50, 50, 90, 90);
            p.Region = new Region(g);

        }
    }
}
