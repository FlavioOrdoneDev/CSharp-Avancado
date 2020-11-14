using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Kathleen_Party_Heranca
{
    public class DinnerParty : Party
    {
        public decimal CostOfBeveragesPerPerson;
        private bool HealthyOption;

        public DinnerParty(int numberOfPeople,bool healthyOption, bool fancyDecorations)
            :base(numberOfPeople, fancyDecorations)
        {
            CalculateCostOfDecorations(fancyDecorations);
            SetHealthyOption(healthyOption);
        }

        
        public void SetHealthyOption(bool healthyOption)
        {
            if (healthyOption)
            {
                CostOfBeveragesPerPerson = 5.00M;
            }
            else
            {
                CostOfBeveragesPerPerson = 20.00M;
            }
            HealthyOption = healthyOption;
        }

        public override decimal CalculateCost()
        {
            decimal totalCost = base.CalculateCost() + (CostOfBeveragesPerPerson * NumberOfPeople);

            if (HealthyOption)
            {                
                totalCost = totalCost * .95M;
            }
            
            return totalCost;
        }
    }
}

