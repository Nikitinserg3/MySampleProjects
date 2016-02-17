using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallGuyApp
{
    class TallGuy : IClown
    {
        public string Name { get; set; }
        public int Height { get; set; }

        public string FunnyThingIHave
        {
            get
            {
                return "funny double-barrel";
            }
        }

        public TallGuy(string name, int heigh)
        {
            this.Name = name;
            this.Height = heigh;
        }

        public void TalkAboutMyself()
        {
            Console.WriteLine("My name is {0} and I'm {1} inches tall.", Name, Height);
            Console.ReadKey();
        }

        public void Honk()
        {
            Console.WriteLine("Honk! Honk!");
            Console.ReadKey();
        }
    }
}
