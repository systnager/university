using System;

namespace StructConlsole {
    class Program {
        static void Main(string[] args) {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetWindowSize(75, 25);
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            double min, max; ;
            int n, c;
            Console.Title = "Лабораторна робота №4";

            Console.WriteLine("Введіть кількіcть cтудентів:");
            n = NumberCheking();
            Student[] stud = new Student[n];
            do {
                Console.WriteLine("_____________________________________________________");
                Console.WriteLine("Введіть дію:");
                Console.WriteLine("1 - Створити масив студентів");
                Console.WriteLine("2 - Вивести масив студентів");
                Console.WriteLine("3 - Вивести інф про студента");
                Console.WriteLine("4 - Сортування за середнім значенням");
                Console.WriteLine("5 - Сортування за Прізвищем");
                Console.WriteLine("6 - Найвищий та найнижчий середній бал");
                Console.WriteLine("7 - Cереднє АР студента за №");
                Console.WriteLine("8 - Предмет, за який найкраща оцінка. за № студента");
                Console.WriteLine("9 - Предмет, за який найгірша оцінка. за № студента");
                Console.WriteLine("_____________________________________________________");
                c = NumberCheking();
                Console.WriteLine("_____________________________________________________");
                switch (c) {
                    case 0: break;
                    case 1: ReadStudentsArray(stud); break;
                    case 2: PrintStudents(stud); break;
                    case 3: PrintStudent(stud); break;
                    case 4: Array.Sort(stud, SortStudentsByPoints); break;
                    case 5: Array.Sort(stud, SortStudentsByName); break;
                    case 6:
                        GetStudentsInfo(stud, out min, out max);
                        Console.WriteLine($"MinAverage = {min}");
                        Console.WriteLine($"MaxAverage = {max}");
                        break;
                    case 7: GetAverageForOne(stud); break;
                    case 8:
                        int x;
                        Console.WriteLine("Введіть номер студента");
                        x = NumberCheking() - 1;
                        Console.WriteLine($"Предмет: {stud[x].GetBestSubject(stud[x].Results)}");
                        break;
                    case 9:
                        int b;
                        Console.WriteLine("Введіть номер студента");
                        b = NumberCheking() - 1;
                        Console.WriteLine($"Предмет: {stud[b].GetWorstSubject(stud[b].Results)}");
                        break;
                }

                Console.WriteLine("_____________________________________________________");
            } while (c != 0);
        }

        public struct Result {
            public string Subject;
            public string Teacher;
            public int Point;

            public Result(string subject, string teacher, int point) {
                Subject = subject;
                Teacher = teacher;
                Point = point;
            }
        }

        public struct Student {
            public string Name;
            public string Surname;
            public string Group;
            public int Year;
            public Result[] Results;

            public Student(string name, string surname, string group, int year, Result[] resultsStudents) {
                Name = name;
                Surname = surname;
                Group = group;
                Year = year;
                Results = resultsStudents;
            }

            public double GetAveragePoints(Result[] Results) {
                double res = 0;
                for (int i = 0; i < Results.Length; i++) {
                    res += Results[i].Point;
                }
                res /= Results.Length;
                return res;
            }

            public string GetBestSubject(Result[] Results) {
                int max = 0;
                string maxSub = "";
                for (int i = 0; i < Results.Length; i++) {
                    if (Results[i].Point > max) {
                        maxSub = Results[i].Subject;
                        max = Results[i].Point;
                    }
                }
                return maxSub;
            }

            public string GetWorstSubject(Result[] Results) {
                int min = Results[0].Point;
                string minSub = "";
                for (int i = 0; i < Results.Length; i++) {
                    if (Results[i].Point < min) {
                        minSub = Results[i].Subject;
                        min = Results[i].Point;
                    }
                }
                return minSub;
            }


        }


        static int NumberCheking() {
            int x;
            bool ok = true;
            do {
                ok = int.TryParse(Console.ReadLine(), out x);
                if (!ok) {
                    Console.WriteLine("Try Again!");
                }
            } while (!ok || x <= 0);
            return x;
        }

        static Student[] ReadStudentsArray(Student[] stud) {
            int NumberofSub;
            Console.WriteLine("Введіть кількість предметів  ");
            NumberofSub = NumberCheking();
            for (int i = 0; i < stud.Length; i++) {
                Console.WriteLine($"Student - {i + 1}");
                Console.WriteLine($"Ім'я студента");
                stud[i].Name = Console.ReadLine();
                Console.WriteLine($"Прізвище студента");
                stud[i].Surname = Console.ReadLine();
                Console.WriteLine($"Номер курсу");
                stud[i].Year = NumberCheking();
                Console.WriteLine($"Група");
                stud[i].Group = Console.ReadLine();
                stud[i].Results = new Result[NumberofSub];
                for (int j = 0; j < NumberofSub; j++) {
                    Console.WriteLine($"Предмет - {j + 1}");
                    Console.WriteLine($"Назва предмета");
                    stud[i].Results[j].Subject = Console.ReadLine();
                    Console.WriteLine($"Викладач");
                    stud[i].Results[j].Teacher = Console.ReadLine();
                    Console.WriteLine($"Оцінка");
                    stud[i].Results[j].Point = NumberCheking();
                }
            }
            return stud;
        }

        static void PrintStudents(Student[] stud) {
            for (int i = 0; i < stud.Length; i++) {
                Console.WriteLine($"Ім'я студента: {stud[i].Name}");
                Console.WriteLine($"Прізвище студента: {stud[i].Surname}");
                Console.WriteLine($"Група: {stud[i].Group}");
                Console.WriteLine($"Рік: {stud[i].Year}");
                for (int j = 0; j < stud[i].Results.Length; j++) {
                    Console.WriteLine($"Назва предмета: {stud[i].Results[j].Subject}");
                    Console.WriteLine($"П.І.Б. викладача: {stud[i].Results[j].Teacher}");
                    Console.WriteLine($"Оцінка: {stud[i].Results[j].Point}");
                }
                Console.WriteLine("_____________________________________________________");
            }

        }

        static void PrintStudent(Student[] stud) {
            Console.WriteLine($"Введіть номер студента:");
            int i = NumberCheking();
            i -= 1;
            Console.WriteLine($"Ім'я студента: {stud[i].Name}");
            Console.WriteLine($"Прізвище студента: {stud[i].Surname}");
            Console.WriteLine($"Група: {stud[i].Group}");
            Console.WriteLine($"Рік: {stud[i].Year}");
            for (int j = 0; j < stud[i].Results.Length; j++) {
                Console.WriteLine($"Назва предмета: {stud[i].Results[j].Subject}");
                Console.WriteLine($"П.І.Б. викладача: {stud[i].Results[j].Teacher}");
                Console.WriteLine($"Оцінка: {stud[i].Results[j].Point}");
            }
            Console.WriteLine("_____________________________________________________");

        }

        static void GetStudentsInfo(Student[] stud, out double minPoint, out double maxPoint) {
            minPoint = stud[0].Results[0].Point;
            maxPoint = 0;
            for (int i = 0; i < stud.Length; i++) {
                if (stud[i].GetAveragePoints(stud[i].Results) > maxPoint)
                    maxPoint = stud[i].GetAveragePoints(stud[i].Results);
                if (stud[i].GetAveragePoints(stud[i].Results) < minPoint)
                    minPoint = stud[i].GetAveragePoints(stud[i].Results);
            }
        }

        public static int SortStudentsByPoints(Student a, Student b) {
            if (a.GetAveragePoints(a.Results) > b.GetAveragePoints(b.Results))
                return 1;
            else if (a.GetAveragePoints(a.Results) < b.GetAveragePoints(b.Results))
                return -1;
            return 0;
        }

        public static int SortStudentsByName(Student a, Student b) {
            if (String.Compare(a.Surname, b.Surname) > 0)
                return 1;
            if (String.Compare(a.Surname, b.Surname) < 0)
                return -1;
            if (String.Compare(a.Name, b.Name) > 0)
                return 1;
            if (String.Compare(a.Name, b.Name) < 0)
                return -1;
            return 0;


        }

        static void GetAverageForOne(Student[] stud) {
            int x;
            double a;
            Console.WriteLine("Введіть номер студента");
            x = NumberCheking() - 1;
            a = stud[x].GetAveragePoints(stud[x].Results);
            if (a < 60)
                Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Середнє студента = {a}");
            Console.ForegroundColor = ConsoleColor.Magenta;
        }
    }
}
