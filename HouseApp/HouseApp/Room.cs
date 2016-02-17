using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseApp
{
	internal class Room : Location
	{
		private string _decoration;

		public Room(string name ,string decoration) : base(name)
		{
			_decoration = decoration;
		}

		internal override string Description
		{
			get
			{
				return base.Description + "Вы также видите украшения: " + _decoration + ".";
			}
		}


	}
}
