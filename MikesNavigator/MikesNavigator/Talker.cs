using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MikesNavigator
{
    class Talker
    {
        public static int BlahBlah(string thingToSay, int numberOfTimes)
        {
            string finalString = "";
            for (int count = 1; count <= numberOfTimes; count++)
            {
                finalString = finalString + thingToSay + Environment.NewLine;
            }
            MessageBox.Show(finalString);
            return finalString.Length;
        }
    }
}
