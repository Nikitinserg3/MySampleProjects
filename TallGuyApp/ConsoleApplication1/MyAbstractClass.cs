using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
	abstract class MyAbstractClass
	{
		protected abstract int Number { get; }

		protected abstract void DoItNow();

		protected virtual int GetSomeNumber()
		{
			return 6;
		}
	}
}
