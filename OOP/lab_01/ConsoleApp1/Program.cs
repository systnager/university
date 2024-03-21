using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        Console.WriteLine("Введіть x:");
        int x = GetValidInput();

        Console.WriteLine("Введіть y:");
        int y = GetValidInput();

        Console.WriteLine("Введіть z:");
        int z = GetValidInput();

        double result = Calculate(x, y, z);

        Console.WriteLine($"Результат: {result:F3}");

    }

    static int GetValidInput()
    {
        int coefficient;
        while (true)
        {
            string input = Console.ReadLine();
            input = input.Replace(',', '.');
            if (double.TryParse(input, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out double temp))
            {
                coefficient = (int)temp;
                break;
            }
            else
            {
                Console.WriteLine("Помилка введення. Введіть ціле число знову:");
            }
        }
        return coefficient;
    }


    static double Calculate(int x, int y, int z)
    {
        double a = 2 * Math.Cos(x * x) - 0.5;
        double b = 0.5 + Math.Sin(Math.Pow(y, 2 - z));
        double c = z * z / (7 - z / 3);
        return a / b + c;
    }
}
