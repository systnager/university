using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApp2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            textBox2.Text = "";

            string t = textBox1.Text;
            string[] s = t.Split(' ');
            int k = s.Length;
            int[] ar = new int[k];

            if (k > 2)
            {
                MessageBox.Show("Забагато значень", "Забагато значень", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            for (int i = 0; i < k; i++)
            {
                bool are = int.TryParse(s[i], out ar[i]);
                if (!are)
                {
                    MessageBox.Show("Помилка", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                textBox2.Text += $"number = {ar[i]}\r\n";
            }

            float c = ar[0] % ar[1];
            textBox2.Text += $"{ar[0]} % {ar[1]} = {c}";

            DrawingVisual drawingVisual = new DrawingVisual();
            using (DrawingContext drawingContext = drawingVisual.RenderOpen())
            {
                if (ar[0] % ar[1] == 1)
                {
                    drawingContext.DrawEllipse(Brushes.Red, new Pen(Brushes.Black, 5), new Point(420, 70), 100, 100);
                }
                else if (ar[0] % ar[1] == 2)
                {
                    drawingContext.DrawRectangle(Brushes.Blue, new Pen(Brushes.Black, 5), new Rect(420, 70, 100, 100));
                }
            }

            VisualBrush visualBrush = new VisualBrush(drawingVisual);
            canvas1.Background = visualBrush;
        }
    }
}
