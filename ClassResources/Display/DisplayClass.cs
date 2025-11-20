using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace ColdChainConnectSystem_ACDP
{
    public abstract class CColor
    {
        public abstract Color SetCustomColor(string color);
        public abstract void SetDisplayRectangle(Button b);
        public abstract void SetDisplayRectangle(Button p, int arc1, int arc2, int arc3, int arc4);
        public abstract void SetDisplayRectangle(Label l, int arc1, int arc2, int arc3, int arc4);
        public abstract void SetDisplayRectangle(Panel p, int arc1, int arc2, int arc3, int arc4);
        public abstract void SetDisplayRectangle(TextBox t, int arc1, int arc2, int arc3, int arc4);
        public abstract void SetDisplayRectangle(Form f, int arc1, int arc2, int arc3, int arc4);
        public abstract Image SetImageOpacity(Image image, float opacity);
    }


    internal class DisplayClass : CColor
    {

        public override Image SetImageOpacity(Image image, float opacity)
        {
            Bitmap bmp = new Bitmap(image.Width, image.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                ColorMatrix matrix = new ColorMatrix();
                matrix.Matrix33 = opacity;
                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default,
                                                  ColorAdjustType.Bitmap);
                g.DrawImage(image, new Rectangle(0, 0, bmp.Width, bmp.Height),
                                   0, 0, image.Width, image.Height,
                                   GraphicsUnit.Pixel, attributes);
            }
            return bmp;
        }


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

        public override void SetDisplayRectangle(Form f, int arc1, int arc2, int arc3, int arc4)
        {
            GraphicsPath g = new GraphicsPath();
            Rectangle rec = new Rectangle(0, 0, f.Width, f.Height);
            g.AddArc(rec.X, rec.Y, 1 + arc1, 1 + arc1, 180, 90);
            g.AddArc(rec.X + rec.Width - arc2, rec.Y, 50, 50, 270, 90);
            g.AddArc(rec.X + rec.Width - arc3, rec.Y + rec.Height - 50, 50, 50, 0, 90);
            g.AddArc(rec.X, rec.Y + rec.Height - arc4, 50, 50, 90, 90);
            f.Region = new Region(g);
        }
    }//class color
}//namespace
