using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class UserOfLibrary : Teacher
    {
        protected int NumberTicket;
        protected string DateOut;
        protected int SizeInputMoney;

        public UserOfLibrary() { }

        public UserOfLibrary(string name, string surname, string date, int zno, int edudoc, string nameschool, string kurs, string group, string fakult, string zaklad, string position, string kafedra, string zakladt, int numbertick, string dateout, int sizemoney) : base(name, surname, date, zno, edudoc, nameschool, kurs, group, fakult, zaklad, position, kafedra, zakladt)
        {
            NumberTicket = numbertick;
            DateOut = dateout;
            SizeInputMoney = sizemoney;

        }
        public UserOfLibrary(string name, string surname, int zno, string schoolname, string group, string faf, string zakl, string position, string zakladt, int numbertick, string dateout, int sizemoney) : base(name, surname, zno, schoolname, group, faf, zakl, position, zakladt)
        {
            NumberTicket = numbertick;
            DateOut = dateout;
            SizeInputMoney = sizemoney;
        }
        public UserOfLibrary(UserOfLibrary userOfLibrary) : base(userOfLibrary)
        {
            NumberTicket = userOfLibrary.NumberTicket;
            DateOut = userOfLibrary.DateOut;
            SizeInputMoney = userOfLibrary.SizeInputMoney;
        }

        public void SetNumberTicket(int ticket)
        {
            NumberTicket = ticket;
        }
        public void SetDateout(string date)
        {
            DateOut = date;
        }
        public void SetSizemoney(int money)
        {
            SizeInputMoney = money;
        }


        public int GetNumberTicket()
        {
            return NumberTicket;
        }
        public string GetDateOut()
        {
            return DateOut;
        }
        public int GetSizeMoney()
        {
            return SizeInputMoney;
        }


        public override string Showinfo()
        {
            return $"{Name} {Surname} {Birthday}\r\n Number of ticket: {NumberTicket}; Date out: {DateOut}; Size of money input: {SizeInputMoney}";
        }


    }
}
