using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseApp
{
	class RoomWithDoor : RoomWithHidingPlace, IHaveExteriorDoor
	{
		private string _description;
		
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

		public RoomWithDoor(string name, string decoration, string description, string hidingPlace) : base(name,decoration, hidingPlace)
		{
			_description = description;
		}
	}
}
