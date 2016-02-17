using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerParty
{
    public class DinnerParty
    {
        public int NumberOfPeople { get; set; }
        private bool _healthCheck;
        private bool _fancyCheck;

        public void SetHealthyOption(bool healthCheck)
        {
            _healthCheck = healthCheck;
        }

        public void SetFancyDecoration(bool fancyCheck)
        {
            _fancyCheck = fancyCheck;
        }

        /*        public int CalculateCostOfDrinks(int numberOfPeople, bool healthCheck)
                {
                    int result = 0;

                    if (healthCheck == true)
                    {
                        return result = NumberOfPeople * 20;
                    }
                    else
                    {
                        return result = NumberOfPeople * 5;
                    }

                }
        */
        public double CalculateCost()
        {
            double totalResult = 0;
            
            totalResult = NumberOfPeople * 25;
            if (_fancyCheck)
            {
                totalResult = totalResult + NumberOfPeople * 15 + 50;
            }
            else
            {
                totalResult = totalResult + NumberOfPeople * 7.5 + 30;
            }

            if (_healthCheck)
            {
                totalResult = (totalResult + NumberOfPeople * 5) * 0.95;
            }
            else
            {
                totalResult = totalResult + NumberOfPeople * 20;
            }
            return totalResult;
        }


        public double CalculateCostReborn(bool fancyCheck, bool healthCheck)
        {
            double totalResult = 0;

            totalResult = NumberOfPeople * 25;
            if (fancyCheck)
            {
                totalResult = totalResult + NumberOfPeople * 15 + 50;
            }
            else
            {
                totalResult = totalResult + NumberOfPeople * 7.5 + 30;
            }

            if (healthCheck)
            {
                totalResult = (totalResult + NumberOfPeople * 5) * 0.95;
            }
            else
            {
                totalResult = totalResult + NumberOfPeople * 20;
            }
            return totalResult;
        }
    }
}
