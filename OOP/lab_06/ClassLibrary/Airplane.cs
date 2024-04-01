﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleClassLibrary
{
    public class Airplane
    {
        protected string StartCity;
        protected string FinishCity;
        protected Date StartDate;
        protected Date FinishDate;
        protected double RangeflyinKm;
        public Airplane()
        {
            StartCity = "California";
            FinishCity = "Zhytomyr";
            StartDate = new Date(2024, 1, 1, 3, 30);
            FinishDate = new Date(2024, 3, 3, 3, 55);
            RangeflyinKm = 1500;
        }

        public double RangeInKilometers
        {
            set { RangeflyinKm = value; }
            get { return RangeflyinKm; }
        }

        public double RangeInMetres
        {
            set { RangeflyinKm = value / 1000; }
            get { return RangeflyinKm * 1000; }
        }

        public double RangeInMiles
        {
            set { RangeflyinKm = value / 0.6214; }
            get { return RangeflyinKm * 0.6214; }
        }




        public Airplane(string startcity, string finishcity, Date startdate, Date finishdate, double range)
        {
            StartCity = startcity;
            FinishCity = finishcity;
            StartDate = startdate;
            FinishDate = finishdate;
            RangeflyinKm = range;
        }
        public Airplane(string startcity, string finishcity)
        {

            StartCity = startcity;
            FinishCity = finishcity;
            StartDate = new Date(2024, 1, 1, 3, 30);
            FinishDate = new Date(2024, 3, 3, 3, 55);
        }
        public Airplane(Airplane airplane)
        {

            StartCity = airplane.StartCity;
            FinishCity = airplane.FinishCity;
            StartDate = airplane.StartDate;
            FinishDate = airplane.FinishDate;
        }

        public void SetStartCity(string startcity)
        {
            if (startcity.Length > 0) StartCity = startcity;
        }
        public void SetFinishCity(string finishcity)
        {
            if (finishcity.Length > 0) FinishCity = finishcity;
        }
        public void SetStartDate(Date date)
        {
            StartDate = date;
        }
        public void SetFinishtDate(Date date)
        {
            FinishDate = date;
        }


        public string GetStartCity()
        {
            return StartCity;
        }
        public string GetFinishCity()
        {
            return FinishCity;
        }
        public Date GetStartDate()
        {
            return StartDate;
        }
        public Date GetFinishtDate()
        {
            return FinishDate;
        }

        public static double GetTotalTime(Airplane airplanes)
        {
            DateTime date1 = new DateTime(airplanes.GetStartDate().GetYear(),
                airplanes.GetStartDate().GetMonth(), airplanes.GetStartDate().GetDay(),
                airplanes.GetStartDate().GetHours(), airplanes.GetStartDate().GetMinutes(), 0);
            DateTime date2 = new DateTime(airplanes.GetFinishtDate().GetYear(),
               airplanes.GetFinishtDate().GetMonth(), airplanes.GetFinishtDate().GetDay(),
               airplanes.GetFinishtDate().GetHours(), airplanes.GetFinishtDate().GetMinutes(), 0);
            TimeSpan interval = date2 - date1;
            double x = double.Parse(interval.TotalMinutes.ToString());
            return x;
        }
        public static bool IsArrivingToday(Airplane[] airplanes)
        {
            bool x = false;
            for (int i = 0; i < airplanes.Length; i++)
            {
                if (airplanes[i].GetStartDate().GetDay() == airplanes[i].GetFinishtDate().GetDay())
                {
                    Console.WriteLine($"{airplanes[i].GetStartCity()} - {airplanes[i].GetFinishCity()} ");
                    Console.WriteLine($"Відправлення у цей же день = true");
                    x = true;
                }
            }
            return x;
        }
    }
}
