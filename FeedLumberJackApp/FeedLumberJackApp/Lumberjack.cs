using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedLumberJackApp
{
	public class Lumberjack
	{
		public string Name { get; set; }
		public int FlapjackCount { get { return meal.Count; } }

		private Stack<Flapjack> meal;


		public Lumberjack(string name)
		{
			Name = name;
			meal = new Stack<Flapjack>();
		}

		public void TakeFlapjacks(Flapjack food, int howMany)
		{
			for (int i = 0; i < howMany; i++)
			{
				meal.Push(food);
			}
		}

		public void EatFlapjacks()
		{
			Console.WriteLine(Name + "'s eating flapjacks");
			while (meal.Count > 0)
			{
				Console.WriteLine(Name + " ate a " + meal.Pop().ToString().ToLower() + " flapjack");
			}
		}

	}
}
