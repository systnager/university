using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;


namespace WinFormsLibrary1
{
    public class Line:Pointe
    {
        public int Dx { set; get; }
        public int Dy { set; get; }

        public Line()
        {
            Random random1 = new Random();
            Dx = random1.Next(1, 25);
            Dy = random1.Next(1, 25);
        }

        public Line(Line line) : base(line)
        {
            Dx = line.Dx;
            Dy = line.Dy;
        }

        public Line(int x, int y, int r, int g, int b, int dx, int dy) : base(x, y, r, g, b)
        {
            Dx = dx;
            Dy = dy;
        }

        public override void Draw(Graphics graphics)
        {
            Pen p = new Pen(Color.FromArgb(R, G, B), 2);
            graphics.DrawLine(p, X, Y, X+Dx, Y+Dy);
        }



    }
}
