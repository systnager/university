using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            People people1 = new People("Taras", "Nagornij", "30.10.2005");
            Console.WriteLine(people1.Showinfo());
            Console.WriteLine("____________________________________________________________");
            Console.WriteLine();

            People people3 = new Abiturient("Artem", "Igorovich", "10.12.2005", 200, 2002, "PZSO");
            Console.WriteLine(people3.Showinfo());
            Console.WriteLine("____________________________________________________________");
            Console.WriteLine();

            People people2 = new Student("Taras", "Nagornij", "30.10.2005", 195, 2003, "PZSO", "1", "VT-23-1", "FIKT", "ZTS");
            Console.WriteLine(people2.Showinfo());
            Console.WriteLine("____________________________________________________________");
            Console.WriteLine();


            People people4 = new Teacher("Tetiana", "Vakalyk", "15.10.1985", 200, 1999, "PZSO", "0", "", "", "", "Programing", "FIKT", "SPA");
            Console.WriteLine(people4.Showinfo());
            Console.WriteLine("____________________________________________________________");
            Console.WriteLine();

            People people5 = new UserOfLibrary("Ivan", "Igorov", "01.01.2005", 0, 0, "", "0", "", "", "", "", "", "", 112332, "15.04.2024", 195);
            Console.WriteLine(people5.Showinfo());
        }
    }
}
