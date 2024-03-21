using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            textBox4.Text = "";

            float a, b, h, y;
            bool ax = float.TryParse(textBox1.Text, out a);
            bool bx = float.TryParse(textBox2.Text, out b);
            bool hx = float.TryParse(textBox3.Text, out h);
            if (!ax || !bx || !hx)
            {
                MessageBox.Show("Введіть значення ще раз", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                textBox4.Text += "x              y\r\r\r\n";
            for (float i = a; i <= b; i+=h)
            {
                y = (float)(Math.Pow(Math.Cos(i * i), 3)) / (float)(1.5 * i + 2);
                textBox4.Text += $"{i:F3}  {y, 10:F3}\r\r\r\n";
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
