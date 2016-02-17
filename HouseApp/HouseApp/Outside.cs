using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseApp
{
	 internal class Outside : Location
	{
		private bool _hot;

		public Outside(string name, bool hot) :base(name)
		{
			_hot = hot;
		}
	}
}
