using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kathleen_Party_Heranca
{
    public abstract class Party
    {
        public Party(int numberOfPeople, bool fancyDecorations)
        {
            this.NumberOfPeople = numberOfPeople;
            this.fancyDecorations = fancyDecorations;
        }

        public const decimal CostOfPartyPerPerson = 25M;
        private bool fancyDecorations;
        public decimal CostOfDecorations = 0;

        private int numberOfPeople;
        public virtual int NumberOfPeople 
        {
            get
            {
                return numberOfPeople;
            }
            set
            {
                numberOfPeople = value;
                CalculateCostOfDecorations(fancyDecorations);
            } 
        }        
        
        public virtual void CalculateCostOfDecorations(bool fancy)
        {
            if (fancy)
            {
                CostOfDecorations = (NumberOfPeople * 15.00M) + 50.00M;
            }
            else
            {
                CostOfDecorations = (NumberOfPeople * 7.50M) + 30.00M;
            }
        }
        public virtual decimal CalculateCost()
        {
            decimal totalCost = CostOfDecorations + (CostOfPartyPerPerson * numberOfPeople);

            if (NumberOfPeople >= 12)
                return totalCost += 100M;
            return totalCost;
        }        
    }
}
