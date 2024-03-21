using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            textBox4.Text = "";

            float a, b, h, y;
            bool ax = float.TryParse(textBox1.Text, out a);
            bool bx = float.TryParse(textBox2.Text, out b);
            bool hx = float.TryParse(textBox3.Text, out h);
            if (!ax || !bx || !hx)
            {
                MessageBox.Show("Введіть значення ще раз", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            textBox4.Text += "x              y\r\r\r\n";
            for (float i = a; i <= b; i += h)
            {
                y = (float)(Math.Pow(Math.Cos(i * i), 3)) / (float)(1.5 * i + 2);
                textBox4.Text += $"{i:F3}  {y, 10:F3}\r\r\r\n";
            }
        }
    }
}
