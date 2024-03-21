using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";

            Graphics draw1 = this.CreateGraphics();
            Pen p1 = new Pen(Color.Black,5);
            Pen p2 = new Pen(Color.Red, 5);
            SolidBrush b1 = new SolidBrush(Color.Blue);
            SolidBrush b2 = new SolidBrush(Color.Red);

            
            string t = textBox1.Text;
            string[] s = t.Split(' ');
            int k = s.Length;
            int[] ar = new int[k];
            if (k > 2)
            {
                MessageBox.Show("Забагато значень", "Забагато значень", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < k; i++)
            {
                    bool are = int.TryParse(s[i], out ar[i]);
                if (!are)
                {
                    MessageBox.Show("Помилка", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                    textBox2.Text += $"number = {ar[i]}\r\n";
            }
            float c = ar[0] % ar[1];
            textBox2.Text += $"{ar[0]} % {ar[1]} = {c}";
            if (ar[0] % ar[1] == 1)
            {
               
                draw1.DrawEllipse(p2, 420, 70, 100, 100);

            }
            if (ar[0] % ar[1] == 2)
            {
                draw1.FillRectangle(b1, 420, 70, 100, 100);
                draw1.DrawRectangle(p1, 420, 70, 100, 100);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
