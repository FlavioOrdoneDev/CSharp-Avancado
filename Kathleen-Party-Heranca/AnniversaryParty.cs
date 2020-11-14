using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kathleen_Party_Heranca
{
    public class AnniversaryParty : Party
    {
        public int CakeSize;

        public AnniversaryParty(int numberOfPeople, bool fancyDecorations, string cakeWriting)
            :base(numberOfPeople, fancyDecorations)
        {
            CalculateSize();
            this.cakeWriting = cakeWriting;
            CalculateCostOfDecorations(fancyDecorations);
        }        

        private void CalculateSize()
        {
            if (NumberOfPeople <= 4)
                CakeSize = 8;
            else
                CakeSize = 16;
        }

        private string cakeWriting = "";

        public string CakeWriting
        {
            get
            {
                return this.cakeWriting;
            }
            set
            {
                int maxLength;

                if (CakeSize == 8)
                {
                    maxLength = 16;
                }
                else
                {
                    maxLength = 40;
                }

                if (value.Length > maxLength)
                {
                    MessageBox.Show("Too many letters for a " + CakeSize + " inch cake");
                    if (maxLength > this.cakeWriting.Length)
                    {
                        maxLength = this.cakeWriting.Length;
                    }

                    this.cakeWriting = cakeWriting.Substring(0, maxLength);
                }
                else
                {
                    this.cakeWriting = value;
                }
            }
        }

        public override int NumberOfPeople
        {
            get 
            {
                return base.NumberOfPeople; 
            }
            set 
            {
                base.NumberOfPeople = value;
                CalculateSize();
                this.CakeWriting = cakeWriting;
            }
        }

        public override decimal CalculateCost()
        {
            decimal CakeCost;
            
            if (CakeSize == 8)
            {
                CakeCost = 40M + (.25M * cakeWriting.Length);
            }
            else
            {
                CakeCost = 75M + (.25M * cakeWriting.Length);
            }

            return base.CalculateCost() + CakeCost;
        }             
    }
}
