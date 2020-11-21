using System;
using System.Collections.Generic;
using System.Text;

namespace AppRentACar.Entities
{
    public class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }
        public double TotalPayment { get { return BasicPayment + Tax; } }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public override string ToString()
        {
            return "Basic Payment: " + BasicPayment.ToString("F2")
                 + "\nTax: " + Tax.ToString("F2")
                 + "\nTotalPayment: " + TotalPayment.ToString("F2"); 
        }
    }
}
