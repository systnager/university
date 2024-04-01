using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlazedForms
{
    public class Glazed
    {
        private double width;
        public double Width
        {
            set { if (value > 0) width = value; }
            get { return width; }
        }

        private double height;
        public double Height
        {
            set { if (value > 0) height = value; }
            get { return height; }
        }

        public int Material { set; get; }
        public int Kamers { set; get; }
        public bool Windowsill { set; get; }

        public Glazed(double width, double height, int material,
            int kamers, bool windowsill)
        {

            Width = width;
            Height = height;
            Material = material;
            Kamers = kamers;
            Windowsill = windowsill;
        }

        private double[,] price = new double[2, 3] {{0.25,0.05,0.15},{0.30,0.10,0.20}};

        public double GetPrice1sm(){
            return price[Kamers, Material];
        }

        public double Calc() {
            double res = (double)(Width * Height * GetPrice1sm());
            if (Windowsill) {
                res = res + 35;
            }
        return res;
        }


    }
}
