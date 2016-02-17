using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elephants
{
    public class Elephant
    {
        private string _name;
        private string _ear;
        public long Hui { get; set; }

        public Elephant(string name, string ear)
        {
            _name = name;
            _ear = ear;
        }


        public void WhoIAm()
        {
            var result = String.Format("My name is {0} and I have ear size of {1}", _name, _ear);
            MessageBox.Show(result);
        }

        public void TellMe(string message, Elephant whoSaidIt)
        {
            MessageBox.Show(whoSaidIt._name + " says + " + message);
        }

        public void SayTo(Elephant whoTalkTo, string message)
        {
            whoTalkTo.TellMe(message, this);

        }
    }
}
