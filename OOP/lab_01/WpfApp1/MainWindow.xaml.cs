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

            double x, y, z;
            bool _x = double.TryParse(textBoxX.Text, out x);
            bool _y = double.TryParse(textBoxY.Text, out y);
            bool _z = double.TryParse(textBoxZ.Text, out z);
            if (!_x || !_z || !_y)
            {
                MessageBox.Show("Помилка введення значення", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            double a = 2 * Math.Cos(x * x) - 0.5;
            double b = 0.5 + Math.Sin(Math.Pow(y, 2 - z));
            double c = z * z / (7 - z / 3);
            double res = a / b + c;

            textBoxS.Text = res.ToString("F2");
        }

        private void textBoxS_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
    }
}
