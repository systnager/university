using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace WinFormsLibrary1
{
    public class Ellipse : Circle
    {
        public int Radius2 { set; get; }
        public Ellipse()
        {
            Random random23 = new Random();
            Radius2 = random23.Next(1, 25);

        }

        public Ellipse(Ellipse ellipse) : base(ellipse)
        {
            Radius2 = ellipse.Radius2;
        }

        public Ellipse(int x, int y, int r, int g, int b, int rad,int rad2) : base(x, y, r, g, b,rad)
        {
            Radius2 = rad2;
        }

        public override void Draw(Graphics graphics)
        {
            Pen p = new Pen(Color.FromArgb(R, G, B), 2);
            graphics.DrawEllipse(p, X, Y, Radius, Radius2);
        }
    }
}
