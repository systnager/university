using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

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

        static double GetValidInput(TextBox textBox)
        {
            double coefficient;
            if (! double.TryParse(textBox.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out double temp)) {
                MessageBox.Show($"Помилка введення значення {textBox.Name}! Результат не може бути правильним!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
                textBox.SelectAll();

                textBox.Clear();
                coefficient = 0.0;
            }
            coefficient = (double)temp;
            return coefficient;
        }


        static double Calculate(double x, double y, double z)
        {
            double a = 2 * Math.Cos(x * x) - 0.5;
            double b = 0.5 + Math.Sin(Math.Pow(y, 2 - z));
            double c = z * z / (7 - z / 3);
            return a / b + c;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double xValue = GetValidInput(x);
            double yValue = GetValidInput(y);
            double zValue = GetValidInput(z);

            double result = Calculate(xValue, yValue, zValue);
            r.Text = result.ToString("F2");
        }
    }
}
