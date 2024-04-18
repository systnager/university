using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsLibrary1;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();

            Shape[] shapes = new Shape[20];
            Random rand = new Random();
            for (int i = 0; i < 20; i++)
            {
               
                switch (rand.Next(0, 5))
                {   case 0:shapes[i] = new Pointe(); break;
                    case 1: shapes[i] = new Line(); break;
                    case 2: shapes[i] = new Circle(); break;
                    case 3: shapes[i] = new RectangleM(); break;
                    case 4: shapes[i] = new Ellipse(); break;
                }
            }

            for (int i = 0; i < 20; i++)
            {
                shapes[i].Draw(graphics);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics graphicss = pictureBox1.CreateGraphics();
            graphicss.Clear(DefaultBackColor);
        }
    }
}
