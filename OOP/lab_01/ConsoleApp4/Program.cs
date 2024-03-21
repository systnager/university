using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            System.Globalization.CultureInfo customCulture =
                (System.Globalization.CultureInfo)
                        System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            int N, K, sum = 0;
            bool n, m;
            do
            {
                Console.WriteLine("Введіть К: ");
                m = int.TryParse(Console.ReadLine(), out K);
                if (!m || K <= 0)
                {
                    Console.WriteLine("Помилка введеня");
                }
            } while (!m || K <= 0); ;

            do
            {
                Console.WriteLine("Введіть Н: ");
                n = int.TryParse(Console.ReadLine(), out N);
                if (!n || N <= 0)
                {
                    Console.WriteLine("Помилка введеня");
                }
            } while (!n || N <= 0);
            int p;
            for (int i = 1; i <= N; i++)
            {
                p = (int)Math.Pow(i, K);
                sum += p;

            }
            Console.WriteLine($"Результат: {sum}");
            Console.ReadLine();
        }
    }
}
