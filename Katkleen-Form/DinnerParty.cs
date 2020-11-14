using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katkleen_Form
{
    public class DinnerParty
    {
        public const decimal CostOfFoodPerPerson = 25.00M;
        private int NumberOfPeople { get; set; }
        public decimal CostOfBeveragesPerPerson { get; set; }
        public decimal CostOfDecorations { get; set; }

        public void SetPartyOptions(int people, bool fancy)
        {
            NumberOfPeople = people;
            CalculateCostOfDecorations(fancy);
        }

        public void SetHealthyOption(bool healthy)
        {
            if (healthy) {
                CostOfBeveragesPerPerson = 5.00M;
            }
            else {
                CostOfBeveragesPerPerson = 20.00M;
            }                
        }

        public void CalculateCostOfDecorations(bool fancy)
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

        public decimal CalculateCost( bool healthy)
        {
            decimal totalCost = CostOfDecorations + ((CostOfBeveragesPerPerson + CostOfFoodPerPerson) * NumberOfPeople);

            if (healthy) {
                return totalCost * .95M;
            }
            else {
                return totalCost;
            }
        }
    }
}
