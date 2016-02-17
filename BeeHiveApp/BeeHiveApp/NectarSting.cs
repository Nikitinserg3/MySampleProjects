using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHiveApp
{
    class NectarStinger : Worker, IStingPatrol, INectarCollector
    {
        public int AlertLevel { get; set; }
        public int StingerLength { get; set;}
        public int Nectar { get; set; }

        public NectarStinger(string[] jobsICanDo, double weighMg) : base(jobsICanDo, weighMg)
        {

        }

        public bool LookForEnemies()
        {
            return true;
        }

        public int SharpenStinger (int length)
        {
            return length;
        }

        public void FindFlowers()
        {

        }

        public void GatherNectar()
        {

        }

        public void ReturnToHive()
        {

        }
    }
}
