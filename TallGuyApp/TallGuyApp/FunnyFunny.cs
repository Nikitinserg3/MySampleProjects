using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallGuyApp
{
	public class FunnyFunny : IClown
	{
		protected string _funnyStuff;

		public string FunnyThingIHave
		{
			get
			{
				return _funnyStuff;
			}
		}

		public FunnyFunny(string thing)
		{
			_funnyStuff = thing;
		}

		public void Honk()
		{
			Console.WriteLine("Look! I have {0}.", FunnyThingIHave);
		}
	}
}
