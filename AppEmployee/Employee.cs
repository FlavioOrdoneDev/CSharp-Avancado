using System;
using System.Collections.Generic;
using System.Text;

namespace AppEmployee
{
    public class Employee
    {
        public Employee(string name, int hours, double valueHour)
        {
            Name = name;
            Hours = hours;
            ValueHour = valueHour;
        }

        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValueHour { get; set; }

        public virtual double Payment()
        {
            return Hours * ValueHour;
        }
    }
}
