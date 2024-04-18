using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace WinFormsLibrary1
{
    public class Pointe : Shape
    {

       

        public Pointe() : base()
        {
          
        }

        public Pointe(Pointe point) : base(point)
        {
        }
        public Pointe(int x, int y, int r, int g, int b):base(x,y,r,g,b)
        {
        }
        public override void Draw(Graphics graphics)
        {
            Pen p = new Pen(Color.FromArgb(R, G, B),2);
            graphics.DrawEllipse(p, X ,Y,2,2);
        }

    }
}
