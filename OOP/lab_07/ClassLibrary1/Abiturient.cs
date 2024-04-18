using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Abiturient : People
    {
        protected int ZNO;
        protected int EduDocum;
        protected string NameSchool;

        public Abiturient()
        {
        }

        public Abiturient(string name, string surname, string date, int zno, int edudoc, string nameschool) : base(name, surname, date)
        {
            ZNO = zno;
            EduDocum = edudoc;
            NameSchool = nameschool;

        }
        public Abiturient(string name, string surname, int zno, string schoolname) : base(name, surname)
        {
            ZNO = zno;
            NameSchool = schoolname;
            EduDocum = 0;
        }
        public Abiturient(Abiturient abiturient) : base(abiturient)
        {
            ZNO = abiturient.ZNO;
            EduDocum = abiturient.EduDocum;
            NameSchool = abiturient.NameSchool;
        }

        public void SetZNOAverage(int zno)
        {
            ZNO = zno;
        }
        public void SetEducationDocNUM(int edudoc)
        {
            EduDocum = edudoc;
        }
        public void SetNameSchool(string nameschool)
        {
            NameSchool = nameschool;
        }

        public int GetZNOAverage()
        {
            return ZNO;
        }
        public int GetEduDOC()
        {
            return EduDocum;
        }
        public string GetNamesschool()
        {
            return NameSchool;
        }

        public override string Showinfo()
        {
            return $"{Name} {Surname} {Birthday} Average ZNO: {ZNO}; NumEduDoc: {EduDocum}; Nameschool: {NameSchool}";
        }



    }
}
