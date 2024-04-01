using System;

namespace Arrays1DConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                     System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            Console.WriteLine("Enter n:");
            int n = int.Parse(Console.ReadLine());
            double[] arr1 = new double[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                arr1[i] = rnd.Next(-1051, 1053) / 100.0;
                Console.WriteLine($"[{i}] = {arr1[i]}");
            }
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (i % 3 == 0)
                    sum += arr1[i];
            }
            Console.WriteLine($"Sum of elements with indices divisible by 3: {sum}");
            int halfLength = n / 2;
            double[] arr2 = new double[halfLength];
            Array.Copy(arr1, arr2, halfLength);
            Array.Sort(arr2);

            Console.WriteLine($"Sorted first half of the array:");
            for (int i = 0; i < halfLength; i++)
            {
                arr1[i] = arr2[i];
                Console.WriteLine($"arr1[{i}] = {arr1[i]}");
            }
        }
    }
}
