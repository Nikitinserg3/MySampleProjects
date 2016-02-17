using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLegacyLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Owner owner = new Owner();
            Safe safe = new Safe();
            JewelTheif jewelsTheif = new JewelTheif();
            jewelsTheif.OpenSafe(safe, owner);
            Console.ReadKey();
        }
    }
}
