using System;
using System.Drawing;
namespace WinFormsLibrary1
{
    public class Shape
    {

        public int X { set; get; }
        public int Y { set; get; }
        public int R { set; get; }
        public int G { set; get; }
        public int B { set; get; }

        public Shape()
        {
            Random random = new Random();
            X = random.Next(0, 400);
            Y = random.Next(0, 300);
            R = random.Next(0, 256);
            G = random.Next(0, 256);
            B = random.Next(0, 256);
        }

        public Shape(Shape shape)
        {
            X = shape.X;
            Y = shape.Y;
            R = shape.R;
            G = shape.G;
            B = shape.B;
        }
        public Shape(int x,int y,int r,int g,int b)
        {
            X = x;
            Y = y;
            R = r;
            G = g;
            B = b;
        }
        public virtual void Draw(Graphics graphics)
        { 
        }

    }
}
