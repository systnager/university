using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class People
    {
        protected string Name;
        protected string Surname;
        protected string Birthday;

        public People()
        {
        }

        public People(string name, string surname, string date)
        {
            Name = name;
            Surname = surname;
            Birthday = date;

        }
        public People(string name, string surname)
        {
            Name = name;
            Surname = surname;
            Birthday = "30.10.2005";
        }
        public People(People people)
        {
            Name = people.Name;
            Surname = people.Surname;
            Birthday = people.Birthday;
        }

        public void SetName(string name)
        {
            Name = name;
        }
        public void SetSurName(string surname)
        {
            Surname = surname;
        }
        public void SetBirthday(string date)
        {
            Birthday = date;
        }

        public string GetName()
        {
            return Name;
        }
        public string GetSurName()
        {
            return Surname;
        }
        public string GetBirthday()
        {
            return Birthday;
        }

        public virtual string Showinfo()
        {
            return $"{Name} {Surname} {Birthday}";
        }


    }
}
