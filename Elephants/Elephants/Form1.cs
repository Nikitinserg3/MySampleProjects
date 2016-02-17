using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elephants
{
    public partial class Form1 : Form
    {
        Elephant lloyd = new Elephant("Lloyd", "33") { Hui = 1000};
        Elephant lucinda = new Elephant("Lucinda", "20");
        Rat bobby = new Rat { Name = "Bobby", Age = 3 };


        public Form1()
        {
            InitializeComponent();
        }

        private void lloydButton_Click(object sender, EventArgs e)
        {
            lloyd.SayTo(lucinda,"Hide");
        }

        private void lucindaButton_Click(object sender, EventArgs e)
        {
            lucinda.WhoIAm();
        }

        private void swapButton_Click(object sender, EventArgs e)
        {
            var temp = lloyd;
            lloyd = lucinda;
            lucinda = temp;
            MessageBox.Show("Elephants were swapped");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lloyd.TellMe("Hi", lucinda);
        }
    }
}
