using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTrainingApp
{
	class Shoe : IOnMyLegs
	{
		public ShoeColor Color { get; set; }
		public ShoeStyle Style { get; set; }
	}
}
