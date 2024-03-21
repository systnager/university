using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
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



            int n, sum = 0;
            bool input;
            do
            {
                Console.WriteLine("Введіть значення N: ");
                input = int.TryParse(Console.ReadLine(), out n);
                if (!input || n <= 0)
                {
                    Console.WriteLine("Помилка введеня");
                }
            } while (!input || n <= 0);
            int r = 1;

            for (int i = 2; i <= n; i++)
            {

                sum += (int)Math.Pow(i, (n - r));
                r++;
            }
            Console.WriteLine($"Результат: {sum + 1}");
            Console.ReadLine();



        }
    }
}
