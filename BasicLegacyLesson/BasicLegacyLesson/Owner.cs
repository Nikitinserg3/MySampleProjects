using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLegacyLesson
{
    class Owner
    {
        private Jewels _returnedContents;
        public void ReceivedContents(Jewels safeContents)
        {
            _returnedContents = safeContents;
            Console.WriteLine("Thx for returning my jewels " + safeContents.Sparkle());
        }
    }
}
