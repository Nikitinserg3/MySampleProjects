using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseApp
{
	interface IHaveExteriorDoor
	{
		string DoorDescription { get; }
		Location DoorLocation { get; set; }
	}
}
