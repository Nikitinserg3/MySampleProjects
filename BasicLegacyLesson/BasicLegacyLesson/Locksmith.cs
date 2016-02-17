using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLegacyLesson
{
    class Locksmith
    {
        private string _writtenDownCombination = null;

        public void OpenSafe(Safe safe, Owner owner)
        {
            safe.PickLock(this);
            Jewels safeContents = safe.OpenSafe(_writtenDownCombination);
            ReturnContents(safeContents, owner);
        }

        public void WriteDownCombination(string combination)
        {
            _writtenDownCombination = combination;
        }

        public virtual void ReturnContents(Jewels safeContetns, Owner owner)
        {
            owner.ReceivedContents(safeContetns);
        }

    }
}
