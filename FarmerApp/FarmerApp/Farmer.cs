using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmerApp
{
    class Farmer
    {
        private int _bagMultiplier;
        private int _numberOfCows;

        public int BagsOfFeed { get; private set; }

        public int BagMultiplier
        {
            get
            {
                return _bagMultiplier;
            }
        }
                
        public int NumberOfCows
        {
            get
            {
                return _numberOfCows;
            }
            set
            {
                _numberOfCows = value;
                BagsOfFeed = _numberOfCows * BagMultiplier;
            }
            
        }

        public Farmer(int _numberOfCows, int _bagMultiplier)
        {
            NumberOfCows = _numberOfCows;
            this._bagMultiplier = _bagMultiplier;
        }
        
    }
}