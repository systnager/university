using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleClassLibrary
{
    public class Date
    {
        protected int Year;
        protected int Month;
        protected int Day;
        protected int Hours;
        protected int Minutes;

        public Date()
        {
            Year = 2024;
            Month = 5;
            Day = 12;
            Hours = 5;
            Minutes = 40;
        }
        public Date(int year, int month, int day, int hours, int minutes)
        {
            Year = year;
            Month = month;
            Day = day;
            Minutes = minutes;
        }
        public Date(int year, int month)
        {
            Year = year;
            Month = month;
            Day = 8;
            Minutes = 30;
        }
        public Date(Date date)
        {
            Year = date.Year;
            Month = date.Month;
            Day = date.Day;
            Minutes = date.Minutes;
        }

        public void SetYear(int year)
        {
            Year = year;
        }
        public void SetMonth(int month)
        {
            Month = month;
        }
        public void SetDay(int day)
        {
            Day = day;
        }
        public void SetHours(int hours)
        {
            Hours = hours;
        }
        public void SetMinutes(int minutes)
        {
            Minutes = minutes;
        }

        public int GetYear()
        {
            return Year;
        }
        public int GetMonth()
        {
            return Month;
        }
        public int GetDay()
        {
            return Day;
        }
        public int GetMinutes()
        {
            return Minutes;
        }
        public int GetHours()
        {
            return Hours;
        }

    }
}
