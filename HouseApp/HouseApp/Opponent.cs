using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseApp
{
	class Opponent
	{
		private Location _currentLocation;
		private Random _random;


		public Opponent(Location location)
		{
			_currentLocation = location;
			_random = new Random();
		}

		public void Move()
		{
			bool hidden = false;
			while (!hidden)
			{
				if (_currentLocation is IHaveExteriorDoor)
				{
					if (_random.Next(2) == 1)
					{
						_currentLocation = ((IHaveExteriorDoor)_currentLocation).DoorLocation;
					}


				}
				_currentLocation = _currentLocation.Exits[_random.Next(_currentLocation.Exits.Length)];
				if (_currentLocation is IHidingPlace)
				{
					hidden = true;
				}
			}
		}



		public bool Check(Location location)
		{
			if (location != _currentLocation)
			{
				return false;
			}
			else
			{
				return true;
			}
		}
	}
}
