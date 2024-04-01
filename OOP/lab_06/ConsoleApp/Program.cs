using System;
using SimpleClassLibrary;
namespace SimpleClassConlsole
{
    class Program
    {
        static public Airplane[] ReadAirplaneArray(int n)
        {
            Airplane[] airplanes = new Airplane[n];
            for (int i = 0; i < n; i++)
            {
                airplanes[i] = new Airplane();
                Console.WriteLine($"Літак №{i + 1}");
                Console.WriteLine($"Початкове місто:");
                airplanes[i].SetStartCity(Console.ReadLine());
                Console.WriteLine($"Кінцеве місто:");
                airplanes[i].SetFinishCity(Console.ReadLine());
                Console.WriteLine($"Оберіть одиницю вимірювання:");
                Console.WriteLine($"1 - Кілометри");
                Console.WriteLine($"2 - Метри");
                Console.WriteLine($"3 - Милі");
                int d = Numbchek();
                switch (d)
                {
                    case 1:
                        Console.WriteLine($"Кілометрів:");
                        airplanes[i].RangeInKilometers = double.Parse(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine($"Метрів:");
                        airplanes[i].RangeInMetres = double.Parse(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine($"Миль:");
                        airplanes[i].RangeInMiles = double.Parse(Console.ReadLine());
                        break;
                }
                Date dateStart = new Date();


                Console.WriteLine($"Початкова дата:");
                Console.WriteLine($"Рік:");
                dateStart.SetYear(Numbchek());
                Console.WriteLine($"Місяць:");
                dateStart.SetMonth(Numbchek());
                Console.WriteLine($"День:");
                dateStart.SetDay(Numbchek());
                Console.WriteLine($"Година:");
                dateStart.SetHours(Numbchek());
                Console.WriteLine($"Хвилина:");
                dateStart.SetMinutes(Numbchek());
                airplanes[i].SetStartDate(dateStart);


                Date dateFinish = new Date();
                Console.WriteLine($"Кінцева дата:");
                Console.WriteLine($"Рік:");
                dateFinish.SetYear(Numbchek());
                Console.WriteLine($"Місяць:");
                dateFinish.SetMonth(Numbchek());
                Console.WriteLine($"День:");
                dateFinish.SetDay(Numbchek());
                Console.WriteLine($"Години:");
                dateFinish.SetHours(Numbchek());
                Console.WriteLine($"Хвилини:");
                dateFinish.SetMinutes(Numbchek());
                airplanes[i].SetFinishtDate(dateFinish);
                Console.WriteLine($"************************************************************");
            }
            return airplanes;
        }

        static public void PrintAirplane(Airplane[] airplanes)
        {
            Console.WriteLine($"Уведіть кількість польотів:");
            int x = Numbchek();
            x -= 1;
            Console.WriteLine($"Інформація про літак №{x + 1}");
            Console.WriteLine($"{airplanes[x].GetStartCity()} - {airplanes[x].GetFinishCity()}");
            Console.WriteLine($"{airplanes[x].GetStartDate().GetYear()}.{airplanes[x].GetStartDate().GetMonth()}.{airplanes[x].GetStartDate().GetDay()}  {airplanes[x].GetStartDate().GetHours()}:{airplanes[x].GetStartDate().GetMinutes()}");
            Console.Write($"{airplanes[x].GetFinishtDate().GetYear()}.{airplanes[x].GetFinishtDate().GetMonth()}.{airplanes[x].GetFinishtDate().GetDay()}  {airplanes[x].GetFinishtDate().GetHours()}:{airplanes[x].GetFinishtDate().GetMinutes()}");
            Console.WriteLine($"************************************************************");
        }

        static public void PrintAirplanes(Airplane[] airplanes)
        {
            for (int i = 0; i < airplanes.Length; i++)
            {
                Console.WriteLine($"Подорож#{i + 1}               Початкова дата              Кінцева дата  ");
                Console.WriteLine($"{airplanes[i].GetStartCity()} - {airplanes[i].GetFinishCity()}     {airplanes[i].GetStartDate().GetYear()}.{airplanes[i].GetStartDate().GetMonth()}.{airplanes[i].GetStartDate().GetDay()} {airplanes[i].GetStartDate().GetHours()}:{airplanes[i].GetStartDate().GetMinutes()}          {airplanes[i].GetFinishtDate().GetYear()}.{airplanes[i].GetFinishtDate().GetMonth()}.{airplanes[i].GetFinishtDate().GetDay()} {airplanes[i].GetFinishtDate().GetHours()}:{airplanes[i].GetFinishtDate().GetMinutes()}");
                Console.WriteLine($"Відстань у кілометрах:");
                Console.WriteLine($"{airplanes[i].RangeInKilometers}");
                Console.WriteLine($"Відстань у метрах:");
                Console.WriteLine($"{airplanes[i].RangeInMetres}");
                Console.WriteLine($"Відстань у милях:");
                Console.WriteLine($"{airplanes[i].RangeInMiles:F2}");
                Console.WriteLine($"************************************************************");

            }
        }

        static public void GetAirplaneInfo(Airplane[] airplane, out double max, out double min)
        {
            max = Airplane.GetTotalTime(airplane[0]);
            min = Airplane.GetTotalTime(airplane[0]);
            for (int i = 0; i < airplane.Length; i++)
            {
                if (Airplane.GetTotalTime(airplane[i]) > max) max = Airplane.GetTotalTime(airplane[i]);
            }

            for (int i = 0; i < airplane.Length; i++)
            {
                if (Airplane.GetTotalTime(airplane[i]) < min) min = Airplane.GetTotalTime(airplane[i]);
            }

        }

        static void Main(string[] args)
        {


            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.SetWindowSize(75, 25);
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            int c;
            Console.Title = "Лабораторна робота №6";
            Console.WriteLine("Створення рейсів");
            Console.WriteLine("Кількість рейсів:");
            int n = Numbchek(); Airplane[] airplanesOk = ReadAirplaneArray(n);
            do
            {
                Console.WriteLine("************************************************************");
                Console.WriteLine("Введіть дію:");
                Console.WriteLine("1 - Вивести рейс");
                Console.WriteLine("2 - Вивести рейсИ");
                Console.WriteLine("3 - Вивести усі рейси у яких відправленн і прибуття в той же день");
                Console.WriteLine("4 - Найбільший та найменший час подорожі");
                Console.WriteLine("5 - Сортування за спаданням дати відправлення");
                Console.WriteLine("6 - Сортування за зростанням час подорожі");
                Console.WriteLine("************************************************************");
                c = Numbchek();
                Console.WriteLine("************************************************************");
                switch (c)
                {
                    case 0: break;
                    case 1: PrintAirplane(airplanesOk); break;
                    case 2: PrintAirplanes(airplanesOk); break;
                    case 3: Airplane.IsArrivingToday(airplanesOk); break;
                    case 4:
                        double max, min;
                        GetAirplaneInfo(airplanesOk, out max, out min);
                        Console.WriteLine($"Максимум: {max}");
                        Console.WriteLine($"Мінімум: {min}"); break;
                    case 5: Array.Sort(airplanesOk, SortAirplanesByDate); break;
                    case 6: Array.Sort(airplanesOk, SortAirplanesByTotalTime); break;


                }

                Console.WriteLine("************************************************************");
            } while (c != 0);
        }
        public static int Numbchek()
        {
            int x;
            bool ok = true;
            do
            {
                ok = int.TryParse(Console.ReadLine(), out x);
                if (!ok)
                {
                    Console.WriteLine("Помилка вводу. Спробуйте ще раз");
                }

            } while (!ok || x < 0);
            return x;
        }

        public static int SortAirplanesByDate(Airplane a, Airplane b)
        {
            if (FirstDate(a) > FirstDate(b))
                return -1;
            else if (FirstDate(a) < FirstDate(b))
                return 1;
            return 0;
        }

        public static DateTime FirstDate(Airplane airplanes)
        {
            DateTime date1 = new DateTime(airplanes.GetStartDate().GetYear(),
                airplanes.GetStartDate().GetMonth(), airplanes.GetStartDate().GetDay(),
                airplanes.GetStartDate().GetHours(), airplanes.GetStartDate().GetMinutes(), 0);

            return date1;

        }


        public static int SortAirplanesByTotalTime(Airplane a, Airplane b)
        {
            if (Airplane.GetTotalTime(a) > Airplane.GetTotalTime(b))
                return 1;
            else if (Airplane.GetTotalTime(a) < Airplane.GetTotalTime(b))
                return -1;
            return 0;
        }

    }
}
