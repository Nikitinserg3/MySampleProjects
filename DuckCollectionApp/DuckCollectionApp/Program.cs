using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckCollectionApp
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Duck> ducks = new List<Duck>()
			{
				new Duck() {Kind = KindOfDuck.Mallard, Size = 17},
				new Duck() {Kind = KindOfDuck.Muscovy, Size = 18},
				new Duck() {Kind = KindOfDuck.Decoy, Size = 14},
				new Duck() {Kind = KindOfDuck.Muscovy, Size = 11},
				new Duck() {Kind = KindOfDuck.Mallard , Size = 14},
				new Duck() {Kind = KindOfDuck.Decoy, Size = 13},
			};

			DuckComparer duckComparer = new DuckComparer(SortCriteria.KindThenSize);

			//Duck[] duckArray = new Duck[6];
			//duckArray.GetEnumerator();
			//ducks[0].CompareTo(ducks[1]);
			//ducks.OrderBy(x => x.Size);
			//DuckComparerBySize sizeComparer = new DuckComparerBySize();
			//DuckComparerByKInd kindComparer = new DuckComparerByKInd();
			////ducks.Sort(sizeComparer);
			//ducks.Sort(kindComparer);
			ducks.Sort(duckComparer);
			ducks.GetEnumerator();
			PrintDucks(ducks);
			Console.ReadKey();


		}

		static void PrintDucks(List<Duck> ducks)
		{
			foreach (Duck item in ducks)
			{
				Console.WriteLine(item);
			}

		}
	}
}
