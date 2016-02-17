using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallGuyApp
{
	public class ScaryScary : FunnyFunny, IScaryClown
	{
		private int _number;
		

		public ScaryScary(string thing, int numberOfScaryThings) : base(thing)
		{
			_number = numberOfScaryThings;
		}

		public string ScaryThingIHave
		{
			get
			{
				return _number + " spiders";
			}
		}

		public void ScaryLittleChildren()
		{
			Console.WriteLine("Fuck U! I've GOT YA!!!");
		}
	}
}
