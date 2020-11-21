using System;
using System.Collections.Generic;
using System.Text;

namespace AppRentACar.Entities
{
    public class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public int Installments { get; set; }
        public double Total { get; set; }

        public List<double> ValueInstallments = new List<double>();

        public Contract(int number, DateTime date, int installments, double total)
        {
            Number = number;
            Date = date;
            Installments = installments;
            Total = total;
        }

        public override string ToString()
        {
            return "Number: " + Number
                 + "\nDate: " + Date
                 + "\nContract value: " + Total.ToString("F2")
                 +"\nInstallments: " + Installments;
        }
    }
}
