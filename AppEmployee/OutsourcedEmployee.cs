using System;
using System.Collections.Generic;
using System.Text;

namespace AppEmployee
{
    public class OutsourcedEmployee : Employee
    {
        public OutsourcedEmployee(string name, int hours, double valueHour, double additionalCharge)
            : base(name, hours, valueHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public double AdditionalCharge { get; set; }

        public override double Payment()
        {
            return base.Payment() + AdditionalCharge * 1.10;
        }
    }
}
