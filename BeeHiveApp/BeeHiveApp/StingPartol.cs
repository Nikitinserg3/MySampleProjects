using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHiveApp
{
    class StingPartol : Worker
    {
        public int AlertLevel { get; private set; }
        public int StingerLength { get; set; }

        public StingPartol(string[] jobsICanDo, double weighMg) : base(jobsICanDo, weighMg)
        {

        }

        public bool SharpenStinger(int length)
        {
            return true;
        }

        public bool LookForEnemies()
        {
            return true;
        }

        public void Sting(string enemy)
        {

        }
    }
}
