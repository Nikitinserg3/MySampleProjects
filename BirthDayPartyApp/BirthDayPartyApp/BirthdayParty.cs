using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthDayPartyApp
{
    class BirthdayParty
    {
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public string CakeWriting { get; set; }
        
        private const int _foodPerPerson = 25;

        private int _actualLength
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLength())
                {
                    return MaxWritingLength();
                }
                else
                {
                    return CakeWriting.Length;
                }
            }
            set
            {

            }
        }

        private int CakeSize()
        {
            if (NumberOfPeople <= 4) return 8;
            else return 16;
        }

        private int MaxWritingLength()
        {
            if (CakeSize() == 4) return 16;
            else return 40;
        }

        public bool CakeWritingTooLong
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLength()) return true;
                else return false;
            }
        }

        private decimal CalculateCostOfDecorations()
        {
            decimal costOfFancyDecoration;
            if (FancyDecorations)
            {
                costOfFancyDecoration = (NumberOfPeople * 15.00M) + 50M;
            }
            else
            {
                costOfFancyDecoration = (NumberOfPeople * 7.50M) + 30M;
            }
            return costOfFancyDecoration;
        }

        public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += _foodPerPerson * NumberOfPeople;
                decimal cakeCost;
                if (CakeSize() == 8)
                {
                    cakeCost = 40M + _actualLength;
                }
                return totalCost;
            }
        }

        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            CakeWriting = cakeWriting;
        }
    }
}
