using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballPlayersApp
{
	public enum Name
	{
		Johny,
		Ricardo,
		Pablo,
		Max,
		Vanturasko,
		Kianu,

	}

	public enum LastName
	{
		Fox,
		Bertalucci,
		Honsales,
		Eskaban,
		Petrov,
		Mafakin,
	}

	
	class PlayerInfo
	{
		public string PlayerName { get; set; }
		public string PlayerLastName { get; set; }
		public int Year { get; set; }

		public PlayerInfo(string playerName, string lastName, int year)
		{
			PlayerName = playerName;
			PlayerLastName = lastName;
			Year = year;
		}
			
	}
}
