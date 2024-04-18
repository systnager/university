using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Teacher : Student
    {
        protected string Position;
        protected string Department;
        protected string Institution;

        public Teacher() { }

        public Teacher(string name, string surname, string date, int zno, int edudoc, string nameschool, string kurs, string group, string fakult, string zaklad, string position, string department, string institution) : base(name, surname, date, zno, edudoc, nameschool, kurs, group, fakult, zaklad)
        {
            Position = position;
            Department = department;
            Institution = institution;
        }
        public Teacher(string name, string surname, int zno, string schoolname, string group, string faf, string zakl, string position, string institution) : base(name, surname, zno, schoolname, group, faf, zakl)
        {
            Institution = institution;
            Position = position;
            Department = "none";
        }
        public Teacher(Teacher teacher) : base(teacher)
        {
            Position = teacher.Position;
            Department = teacher.Department;
            Institution = teacher.Institution;
        }

        public void SetPosition(string position)
        {
            Position = position;
        }
        public void SetDepartment(string department)
        {
            Department = department;
        }
        public void SetInstitution(string institution)
        {
            Institution = institution;
        }

        public string GetPosition()
        {
            return Position;
        }
        public string GetDepartment()
        {
            return Department;
        }
        public string GetInstitution()
        {
            return Institution;
        }

        public override string Showinfo()
        {
            return $"{Name} {Surname} {Birthday}\r\nPosition: {Position}; Department: {Department}; Institution: {Institution}";
        }


    }
}
