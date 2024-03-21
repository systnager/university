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
            int a, b, c;
            bool _x = int.TryParse(textBoxX.Text, out a);
            bool _y = int.TryParse(textBoxY.Text, out b);
            bool _z = int.TryParse(textBoxZ.Text, out c);
            if (!_x || a == 0 || !_z || !_y)
            {
                MessageBox.Show("Помилка введення значення", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int d;
            d = b * b - 4 * a * c;
            textBoxD.Text = d.ToString();
            double x1, x2;

            if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                label4.Visible = true; textBoxX1.Visible = true;
                label5.Visible = true; textBoxX2.Visible = true;
                textBoxX1.Text = x1.ToString("F3");
                textBoxX2.Text = x2.ToString("F3");

            }
            else if (d == 0)
            {
                x1 = (float)(-b) / (2 * a);
                textBoxX1.Text = x1.ToString("F3");
                label4.Visible = true; textBoxX1.Visible = true;
                label5.Visible = false; textBoxX2.Visible = false;
            }
            else
            {
                string als = "Коренів немає";
                textBoxX1.Text = als.ToString();
                label4.Visible = true; textBoxX1.Visible = true;
                label5.Visible = false; textBoxX2.Visible = false;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                        System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        }

        private void textBoxX_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
