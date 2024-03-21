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

        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            int a, b, c;
            bool _x = int.TryParse(textBoxA.Text, out a);
            bool _y = int.TryParse(textBoxB.Text, out b);
            bool _z = int.TryParse(textBoxC.Text, out c);
            if (!_x || a == 0 || !_z || !_y)
            {
                MessageBox.Show("Помилка введення значення", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
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
                label4.Visibility = Visibility.Visible; textBoxX1.Visibility = Visibility.Visible;
                label5.Visibility = Visibility.Visible; textBoxX2.Visibility = Visibility.Visible;
                textBoxX1.Text = x1.ToString("F3");
                textBoxX2.Text = x2.ToString("F3");

            }
            else if (d == 0)
            {
                x1 = (float)(-b) / (2 * a);
                textBoxX1.Text = x1.ToString("F3");
                label4.Visibility = Visibility.Visible ; textBoxX1.Visibility = Visibility.Visible;
                label5.Visibility = Visibility.Hidden; textBoxX2.Visibility = Visibility.Hidden;
            }
            else
            {
                string del = "Коренів німа :(";
                textBoxX1.Text = del.ToString();
                label4.Visibility = Visibility.Visible; textBoxX1.Visibility = Visibility.Visible;
                label5.Visibility = Visibility.Hidden; textBoxX2.Visibility = Visibility.Hidden;
            }
        }
    }
}
