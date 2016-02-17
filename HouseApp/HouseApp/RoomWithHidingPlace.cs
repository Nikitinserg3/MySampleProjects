using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseApp
{
	class RoomWithHidingPlace : Room, IHidingPlace
	{
		private string _hidingPlaceName;

		public string HidingPlaceName
		{
			get
			{
				return _hidingPlaceName;
			}
		}

		public RoomWithHidingPlace(string name, string decoration, string hidingPlace) : base(name, decoration)
		{
			_hidingPlaceName = hidingPlace;
		}

		internal override string Description
		{
			get
			{
				return base.Description + "Cмпрятаться можно в " + _hidingPlaceName + ".";
			}
		}

	}
}
