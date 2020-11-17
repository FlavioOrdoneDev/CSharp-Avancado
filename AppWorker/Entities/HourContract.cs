﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AppWorker.Entities
{
    public class HourContract
    {
        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public double TotalValue()
        {
            return ValuePerHour * Hours;

        }
    }
}