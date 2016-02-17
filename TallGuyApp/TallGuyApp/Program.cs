using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallGuyApp
{
    class Program
    {
        static void Main(string[] args)
        {
			//TallGuy guy = new TallGuy("Tommy", 50);
			//guy.TalkAboutMyself();
			//guy.Honk();

			ScaryScary fingersTheClown = new ScaryScary("big balls", 14);
			FunnyFunny someFunnyClown = fingersTheClown;
			IScaryClown someOtherScaryClown = someFunnyClown as ScaryScary;
			someOtherScaryClown.Honk();
			Console.ReadKey();
			
		}
    }
}
