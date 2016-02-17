using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseApp
{
	internal class OutsideWithHidingPlace : Outside, IHidingPlace
	{

		private string _hidingPlaceName;

		public string HidingPlaceName
		{
			get
			{
				return _hidingPlaceName;
			}
		}

		public OutsideWithHidingPlace(string name, bool hot, string hidingPlace) : base(name, hot)
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
