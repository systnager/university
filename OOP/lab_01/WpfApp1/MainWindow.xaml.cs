using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            int xValue = GetValidInput(textBoxX);
            int yValue = GetValidInput(textBoxY);
            int zValue = GetValidInput(textBoxZ);

            double result = Calculate(xValue, yValue, zValue);
            textBoxR.Text = result.ToString("F2");
        }

        private int GetValidInput(TextBox textBox)
        {
            int coefficient;
            while (!int.TryParse(textBox.Text, out coefficient))
            {
                MessageBox.Show($"Помилка введення значення {textBox.Name}!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                textBox.Focus();
                textBox.SelectAll();
                textBox.Clear();

                if (MessageBox.Show("Бажаєте вийти?", "Помилка", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    Environment.Exit(0);
                }
            }
            return coefficient;
        }

        private double Calculate(int x, int y, int z)
        {
            double a = 2 * Math.Cos(x * x) - 0.5;
            double b = 0.5 + Math.Sin(Math.Pow(y, 2 - z));
            double c = z * z / (7 - z / 3);
            return a / b + c;
        }
    }
}
