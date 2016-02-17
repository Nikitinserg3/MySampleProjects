using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHiveApp
{
    class Bee
    {
        public const double _honeyUnitConsumedPerMg = .25;
        public double WeightMg { get; private set; }

        public Bee(double weightMg)
        {
            WeightMg = weightMg;
        }

        public virtual double HoneyConsumtionRate()
        {
            return WeightMg + _honeyUnitConsumedPerMg;
        }
    }
}
