using System;
using System.Globalization;
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

        static int GetValidInput(TextBox textBox)
        {
            int coefficient;
            while (!int.TryParse(textBox.Text, out coefficient))
            {
                MessageBox.Show($"Помилка введення значення {textBox.Name}!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
                textBox.SelectAll();

                textBox.Clear();

                if (MessageBox.Show("Бажаєте вийти?", "Помилка", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }
            }
            return coefficient;
        }


        static double Calculate(int x, int y, int z)
        {
            double a = 2 * Math.Cos(x * x) - 0.5;
            double b = 0.5 + Math.Sin(Math.Pow(y, 2 - z));
            double c = z * z / (7 - z / 3);
            return a / b + c;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int xValue = GetValidInput(x);
            int yValue = GetValidInput(y);
            int zValue = GetValidInput(z);

            double result = Calculate(xValue, yValue, zValue);
            r.Text = result.ToString("F2");
        }
    }
}
