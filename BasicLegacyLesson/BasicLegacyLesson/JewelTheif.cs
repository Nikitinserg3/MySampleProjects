using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLegacyLesson
{
    class JewelTheif : Locksmith
    {
        private Jewels _stolenJewels = null;

        public override void ReturnContents(Jewels safeContents, Owner owner)
        {
            _stolenJewels = safeContents;
            Console.WriteLine("Ha-ha! I steal jewels!" + _stolenJewels.Sparkle());
        }
    }
}
