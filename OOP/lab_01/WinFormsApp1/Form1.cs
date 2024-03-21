using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y, z;
            bool _x = double.TryParse(x_.Text, out x);
            bool _y = double.TryParse(y_.Text, out y);
            bool _z = double.TryParse(z_.Text, out z);
            if (!_x || !_z || !_y)
            {
                MessageBox.Show($"Помилка введення значення! Результат не може бути правильним!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double a = 2 * Math.Cos(x * x) - 0.5;
            double b = 0.5 + Math.Sin(Math.Pow(y, 2 - z));
            double c = z * z / (7 - z / 3);
            double res = a / b + c;
            r.Text = res.ToString("F2");
        }
    }
}
