using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Student : Abiturient
    {
        protected string Course;
        protected string Group;
        protected string Faculty;
        protected string Institution;

        public Student() { }

        public Student(string name, string surname, string date, int zno, int edudoc, string nameschool, string course, string group, string faculty, string institution) : base(name, surname, date, zno, edudoc, nameschool)
        {
            Course = course;
            Group = group;
            Faculty = faculty;
            Institution = institution;
        }
        public Student(string name, string surname, int zno, string schoolname, string group, string faculty, string institution) : base(name, surname, zno, schoolname)
        {
            Group = group;
            Faculty = faculty;
            Institution = institution;
            Course = "1";
        }
        public Student(Student student) : base(student)
        {
            Course = student.Course;
            Group = student.Group;
            Faculty = student.Faculty;
            Institution = student.Institution;
        }

        public void SetCourse(string course)
        {
            Course = course;
        }
        public void SetGroup(string group)
        {
            Group = group;
        }
        public void SetFaculty(string faculty)
        {
            Faculty = faculty;
        }
        public void SetInstitution(string institution)
        {
            Institution = institution;
        }

        public string GetCourse()
        {
            return Course;
        }
        public string GetGroup()
        {
            return Group;
        }
        public string GetFaculty()
        {
            return Faculty;
        }
        public string GetInstitution()
        {
            return Institution;
        }

        public override string Showinfo()
        {
            return $"{Name} {Surname} {Birthday}\r\nCourse: {Course}; Group: {Group}; Faculty: {Faculty}; Institution: {Institution}";
        }


    }
}
