using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        Console.WriteLine("Введіть x:");
        double x = GetValidInput();

        Console.WriteLine("Введіть y:");
        double y = GetValidInput();

        Console.WriteLine("Введіть z:");
        double z = GetValidInput();

        double result = Calculate(x, y, z);

        Console.WriteLine($"Результат: {result:F3}");

    }

    static double GetValidInput()
    {
        double coefficient;
        while (true)
        {
            string input = Console.ReadLine();
            input = input.Replace(',', '.');
            if (double.TryParse(input, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out double temp))
            {
                coefficient = (double)temp;
                break;
            }
            else
            {
                Console.WriteLine("Помилка введення. Введіть ціле число знову:");
            }
        }
        return coefficient;
    }


    static double Calculate(double x, double y, double z)
    {
        double a = 2 * Math.Cos(x * x) - 0.5;
        double b = 0.5 + Math.Sin(Math.Pow(y, 2 - z));
        double c = z * z / (7 - z / 3);
        return a / b + c;
    }
}
