﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHiveApp
{
    class NectarCollector : Worker
    {
        public int Nectar { get; set; }

        public NectarCollector(string[] jobsICanDo, double weighMg) : base (jobsICanDo, weighMg)
        {

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
