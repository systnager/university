using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace WinFormsLibrary1
{
    public class Circle:Pointe
    {

        public int Radius { set; get; }
        public Circle()
        {
            Random random3 = new Random();
            Radius = random3.Next(1, 25);
            
        }

        public Circle(Circle circle) : base(circle)
        {
            Radius = circle.Radius;
        }

        public Circle(int x, int y, int r, int g, int b, int rad) : base(x, y, r, g, b)
        {
            Radius = rad;
        }

        public override void Draw(Graphics graphics)
        {
            Pen p = new Pen(Color.FromArgb(R, G, B), 2);
            graphics.DrawEllipse(p, X, Y, Radius,Radius);
        }


    }
}
