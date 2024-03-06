using System.Globalization;

class Program {
    static void Main() {
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

    static int GetValidInput() {
        int coefficient;
        while (!int.TryParse(Console.ReadLine()
                .Replace(',', '.'), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out coefficient)){
            Console.WriteLine("Помилка введення. Введіть число знову:");
        }
        return coefficient;
    }

    static double Calculate(int x, int y, int z){
        double a = 2 * Math.Cos(x*x)-0.5;
        double b = 0.5 + Math.Sin(y^(2-z));
        double c = z*z/(7-z/3);
        return a/b+c;
    }
}
