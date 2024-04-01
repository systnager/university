using System;

namespace Arrays2DConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                      System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            Console.WriteLine("Enter n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter m = ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine($"Array [{n};{m}]\r\n");
            double[,] arr = new double[n, m];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = rnd.Next(-11034, 11035) / 100.0;
                    Console.Write($"{arr[i, j],8}");
                }
                Console.Write("\r\n");
            }
            Console.Write("\r\n");

            double[] arrdo = new double[n];
            double sum = 0, max = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    sum += arr[i, j];
                    if (j == m - 1)
                    {
                        arrdo[i] = sum;
                        sum = 0;
                        Console.Write($"sum[{i}] = {arrdo[i]:F2}\r\n");
                    }
                }
            }
            Console.Write("\r\n");
            for (int i = 0; i < n; i++)
                if (arrdo[i] > max) max = arrdo[i];
            Console.Write($"sum[max] = {max:F2}\r\n");

            Console.WriteLine("Enter k = ");
            int k = int.Parse(Console.ReadLine());
            double temp;

            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j % 2 == 0 && j != 0)
                    {
                        temp = arr[j, 0];
                        for (int g = 0; g < m - 1; g++)
                            arr[j, g] = arr[j, g + 1];
                        arr[j, m - 1] = temp;
                    }
                }
            }

            Console.Write("\r\n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{arr[i, j],8}");
                }
                Console.Write("\r\n");
            }
        }
    }
}
