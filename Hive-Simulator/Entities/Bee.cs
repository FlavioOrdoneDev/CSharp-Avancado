using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hive_Simulator
{
    public class Bee
    {
        public Bee(double weight)
        {
            this.Weight = weight;
        }

        private double Weight { get; set; }
        public virtual int ShiftsLeft { get { return 0; } }

        public virtual double GetHoneyConsuption()
        {
            double total = 0;
            int left = ShiftsLeft;
            
            if (ShiftsLeft == 0)
            {
                total = 7.5;                
            }   
            else
                total = 9 + ShiftsLeft;

            if (Weight > 150)
                total *= 1.35;

            return total;
        }
    }
}
