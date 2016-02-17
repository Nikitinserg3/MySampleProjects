using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseApp
{
	class OutsideWithDoor : Outside, IHaveExteriorDoor
	{
		private string _description;


		public OutsideWithDoor(string name, bool hot, string description) : base(name, hot)
		{
			_description = description;
		}

		public string DoorDescription
		{
			get
			{
				return _description;
			}
		}

		public Location DoorLocation
		{
			get;
			set;
		}
	}
}
