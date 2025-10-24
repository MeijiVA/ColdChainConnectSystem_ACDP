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
        public abstract void SetDisplayRectangle(Button p, int arc1, int arc2, int arc3, int arc4);
        public abstract void SetDisplayCircle(PictureBox b);
        public abstract void SetDisplayRectangle(Label l, int arc1, int arc2, int arc3, int arc4);
        public abstract void SetDisplayRectangle(Panel p,int arc1,int arc2,int arc3,int arc4);
        public abstract void Panel_Paint(object sender, PaintEventArgs e);

        public abstract void SetDisplayRectangle(TextBox t, int arc1, int arc2, int arc3, int arc4);

    }


    internal class DisplayClass : CColor
    {
        public Panel myPanel;
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

        public override void Panel_Paint(object sender, PaintEventArgs e)
        {
 
            if (myPanel != null)
            {
                Color[] shadowColors = new Color[5];
                shadowColors[0] = Color.FromArgb(130, 130, 130); // Darkest shade
                shadowColors[1] = Color.FromArgb(181, 181, 181); // Darker shade
                shadowColors[2] = Color.FromArgb(195, 195, 195); // Medium shade
                shadowColors[3] = Color.FromArgb(211, 211, 211); // Lighter shade
                shadowColors[4] = Color.FromArgb(230, 230 ,230); // Lightest shade
                using (Pen pen = new Pen(shadowColors[0]))
                {
                    Point pt = myPanel.Location;
                    pt.Y += myPanel.Height;

                    for (int sp = 0; sp < 5; sp++)
                    {
                        pen.Color = shadowColors[sp];
                        e.Graphics.DrawLine(pen, pt.X + sp, pt.Y, pt.X + myPanel.Width - 1 + sp, pt.Y); // Bottom shadow
                        e.Graphics.DrawLine(pen, myPanel.Right + sp, myPanel.Top + sp, myPanel.Right + sp, myPanel.Bottom + sp); // Right shadow
                        pt.Y++;
                    }
                }
            }
        }

        public override void SetDisplayCircle(PictureBox pb)
        {
            System.Drawing.Drawing2D.GraphicsPath obj = new System.Drawing.Drawing2D.GraphicsPath();
            obj.AddEllipse(0,0,pb.Width,pb.Height);
            Region rg = new Region(obj);
            pb.Region = rg;
        }

        public override void SetDisplayRectangle(Button b, int arc1, int arc2, int arc3, int arc4)
        {
            GraphicsPath g = new GraphicsPath();
            Rectangle rec = new Rectangle(0, 0, b.Width, b.Height);
            g.AddArc(rec.X, rec.Y, 1 + arc1, 1 + arc1, 180, 90);
            g.AddArc(rec.X + rec.Width - arc2, rec.Y, 50, 50, 270, 90);
            g.AddArc(rec.X + rec.Width - arc3, rec.Y + rec.Height - 50, 50, 50, 0, 90);
            g.AddArc(rec.X, rec.Y + rec.Height - arc4, 50, 50, 90, 90);
            b.Region = new Region(g);

        }

        public override void SetDisplayRectangle(Label l, int arc1, int arc2, int arc3, int arc4)
        {
            GraphicsPath g = new GraphicsPath();
            Rectangle rec = new Rectangle(0, 0, l.Width, l.Height);
            g.AddArc(rec.X, rec.Y, 1 + arc1, 1 + arc1, 180, 90);
            g.AddArc(rec.X + rec.Width - arc2, rec.Y, 50, 50, 270, 90);
            g.AddArc(rec.X + rec.Width - arc3, rec.Y + rec.Height - 50, 50, 50, 0, 90);
            g.AddArc(rec.X, rec.Y + rec.Height - arc4, 50, 50, 90, 90);
            l.Region = new Region(g);
        }

        public override void SetDisplayRectangle(TextBox t, int arc1, int arc2, int arc3, int arc4)
        {
            GraphicsPath g = new GraphicsPath();
            Rectangle rec = new Rectangle(0, 0, t.Width, t.Height);
            g.AddArc(rec.X, rec.Y, 1 + arc1, 1 + arc1, 180, 90);
            g.AddArc(rec.X + rec.Width - arc2, rec.Y, 50, 50, 270, 90);
            g.AddArc(rec.X + rec.Width - arc3, rec.Y + rec.Height - 50, 50, 50, 0, 90);
            g.AddArc(rec.X, rec.Y + rec.Height - arc4, 50, 50, 90, 90);
            t.Region = new Region(g);
        }
    }//class color
}//namespace
