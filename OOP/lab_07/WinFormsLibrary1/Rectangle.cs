using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace WinFormsLibrary1
{
    public class RectangleM:Line
    {
       

        public RectangleM()
        {
        }

        public RectangleM(RectangleM ectangle) : base(ectangle)
        {
        
        }

        public RectangleM(int x, int y, int r, int g, int b, int dx, int dy) : base(x, y, r, g, b,dx,dy)
        {
        }

        public override void Draw(Graphics graphics)
        {
            Pen p = new Pen(Color.FromArgb(R, G, B), 2);
            graphics.DrawRectangle(p, X, Y, Dx, Dy);
        }

    }
}
