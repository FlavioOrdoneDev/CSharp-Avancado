using System;
using System.Collections.Generic;
using System.Text;

namespace AppRentACar.Entities
{
    public class Installments
    {
        public Installments(double installment, DateTime date)
        {
            Installment = installment;
            Date = date;
        }

        public double Installment { get; set; }
        public DateTime Date { get; set; }
    }
}
