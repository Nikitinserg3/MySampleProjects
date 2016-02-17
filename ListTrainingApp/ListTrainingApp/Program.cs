using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTrainingApp
{
	class Program
	{
		static void Main(string[] args)
		{
			var shoeCloset = new List<IOnMyLegs>();
			shoeCloset.Add(new Shoe() { Style = ShoeStyle.Sneakers, Color = ShoeColor.Black });
			shoeCloset.Add(new Shoe() { Style = ShoeStyle.Clogs, Color = ShoeColor.Brown });
			shoeCloset.Add(new Shoe() { Style = ShoeStyle.Wingtips, Color = ShoeColor.Black });
			shoeCloset.Add(new Shoe() { Style = ShoeStyle.Loafers, Color = ShoeColor.White });
			shoeCloset.Add(new Shoe() { Style = ShoeStyle.Loafers, Color = ShoeColor.Red });
			shoeCloset.Add(new Shoe() { Style = ShoeStyle.Sneakers, Color = ShoeColor.Green });

			int numberOfShoes = shoeCloset.Count;
			foreach (Shoe shoe in shoeCloset)
			{
				shoe.Style = ShoeStyle.Flipflops;
				shoe.Color = ShoeColor.Orange;
			}

			shoeCloset.RemoveAt(4);

			Shoe thirdShoe = (Shoe)shoeCloset[2];
			Shoe secondShoe = (Shoe)shoeCloset[1];
			shoeCloset.Clear();

			shoeCloset.Add(thirdShoe);

			if (!shoeCloset.Contains(secondShoe))
			{
				Console.WriteLine("WTF?");
				
			}

			Console.ReadKey();

			IOonMyHead hat = new Hat();
		}
	}
}
