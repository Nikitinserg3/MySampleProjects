using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guyz
{
	[Serializable]
	public class Guy
    {
        public string Name { get; set; }
        public int Cash { get; set; }

        public int GiveCash(int amount)
        {
            if (amount <= Cash && amount > 0)
            {
                Cash -= amount;
                return amount;
            }
            else
            {
                MessageBox.Show("У меня не хватает кэша " + amount, Name + " говорит");
                return 0;
            }
        }

        public int ReceiveCash(int amount)
        {
            if (amount > 0)
            {
                Cash += amount;
                return amount;
            }
            else
            {
                MessageBox.Show(amount + " мне не нужно ", Name + " говорит");
                return 0;
            }
        }
        
    }
}
