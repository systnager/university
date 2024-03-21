using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                        System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            int a, b, c;
            int d;
            bool ok;
            do
            {
                Console.WriteLine("Введіть a:");
                ok = int.TryParse(Console.ReadLine(), out a);
                if (!ok || a == 0)
                    Console.WriteLine("Помилка вводу, потрібно ввести число знову");
            } while (!ok || a == 0);

            do
            {
                Console.WriteLine("Введіть b:");
                ok = int.TryParse(Console.ReadLine(), out b);
                if (!ok)
                    Console.WriteLine("Помилка вводу, потрібно ввести число знову");
            } while (!ok);


            do
            {
                Console.WriteLine("Введіть c:");
                ok = int.TryParse(Console.ReadLine(), out c);
                if (!ok)
                    Console.WriteLine("Помилка вводу, потрібно ввести число знову");
            } while (!ok);

            d = b * b - 4 * a * c;
            Console.WriteLine("D = {0}", d);
            double x1, x2;

            if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);

                Console.Write($"x1 ={x1:F2}\nx2 = {x2:F2}");
            }
            else if (d == 0)
            {
                x1 = (float)(-b) / (2 * a);
                Console.Write($"x ={x1:F2}");
            }
            else Console.Write("Коренів німа (");

            Console.ReadLine();
        }
    }
}
