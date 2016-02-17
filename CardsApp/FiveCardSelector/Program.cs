using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardsApp;

namespace FiveCardSelector
{
	class Program
	{
		static void Main(string[] args)
		{
			Random random = new Random();
			List<Card> koloda = new List<Card>();
			for (int i = 0; i < 5; i++)
			{
				koloda.Add(new Card((Suits)random.Next(0, 4), (Values)random.Next(1, 14)));
			}
			Print(koloda);
			koloda.Sort(new CardComparer_byValue());
			Console.WriteLine("\n");
			Print(koloda);
			Console.ReadKey();
		}

		static void Print(List<Card> koloda)
		{
			foreach (Card item in koloda)
			{
				Console.WriteLine(item.Name);
			}
		}
	}
}
