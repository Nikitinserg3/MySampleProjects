using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLegacyLesson
{
    class Safe
    {
        private Jewels contents = new Jewels();
        private string _safeCombination = "12345";

        public Jewels OpenSafe(string combination)
        {
            if (combination == _safeCombination)
            {
                return contents;
            }
            else
            {
                return null;
            }
        }

        public void PickLock(Locksmith lockpicker)
        {
            lockpicker.WriteDownCombination(_safeCombination);
        }
    }
}
