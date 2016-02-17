using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseApp
{
	internal abstract class Location
	{
		internal string Name { get; private set; }
		internal Location[] Exits { get; set; }
		
		public Location(string name)
		{
			Name = name;
		}

		internal virtual string Description
		{
			get
			{
				string description = "Вы находитесь в " + Name + ". Вы видите двери ведущие в: ";
				for (int i = 0; i < Exits.Length; i++)
				{
					description += " " + Exits[i].Name;
					if (i != Exits.Length - 1)
					{
						description += ",";
					}
					description += ".";
				}
				return description;
			}
		}
	}
}
