using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BirdsApp
{
	public class Bird
	{
		public string Name { get; set; }

		public virtual void Fly()
		{
			Console.WriteLine("Let's fly away.");
		}

		public override string ToString()
		{
			return "Bird's name " + Name;
		}
	}
}
