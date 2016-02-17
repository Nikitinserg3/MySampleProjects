using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
	class SampleClass : MyAbstractClass
	{
		protected override int Number
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		protected override void DoItNow()
		{
			throw new NotImplementedException();
		}
		protected override int GetSomeNumber()
		{
			return base.GetSomeNumber();
		}
	}
}
