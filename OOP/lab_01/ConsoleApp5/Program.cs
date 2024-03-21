using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                        System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            double K;
            bool m;
            int plus = 0, min = 0, pair = 0, nopair = 0;
            do
            {
                Console.WriteLine("Введіть число");
                m = double.TryParse(Console.ReadLine(), out K);
                if (!m)
                {
                    Console.WriteLine("Помилка введеня");
                }
                if (K > 0) plus++;
                if (K < 0) min++;
                if (K % 2 == 0) pair++;
                if (K % 2 != 0) nopair++;

            } while (!m || K != 0); ;
            if (K == 0)
            {
                pair--;

            }
            Console.WriteLine($"Додатніх: {plus}");
            Console.WriteLine($"Від'ємних: {min}");
            Console.WriteLine($"Парних: {pair}");
            Console.WriteLine($"Непарних:  {nopair}");
            Console.ReadLine();
        }
    }
}
