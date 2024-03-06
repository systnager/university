using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter coefficients for the quadratic equation (a, b, c):");

        double a, b, c;

        while (true)
        {
            Console.Write("a = ");
            if (double.TryParse(Console.ReadLine(), out a))
                break;
            else
                Console.WriteLine("Incorrect input. Please try again.");
        }

        while (true)
        {
            Console.Write("b = ");
            if (double.TryParse(Console.ReadLine(), out b))
                break;
            else
                Console.WriteLine("Incorrect input. Please try again.");
        }

        while (true)
        {
            Console.Write("c = ");
            if (double.TryParse(Console.ReadLine(), out c))
                break;
            else
                Console.WriteLine("Incorrect input. Please try again.");
        }

        double discriminant = b * b - 4 * a * c;

        if (discriminant > 0)
        {
            double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

            Console.WriteLine($"Discriminant: {discriminant}");
            Console.WriteLine($"Roots: x1 = {x1}, x2 = {x2}");
        }
        else if (discriminant == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"Discriminant: {discriminant}");
            Console.WriteLine($"One root: x = {x}");
        }
        else
        {
            Console.WriteLine($"Discriminant: {discriminant}");
            Console.WriteLine("No roots.");
        }
    }
}
