using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmerApp
{
    public partial class Form1 : Form
    {
        private Farmer _farmer; 
        public Form1()
        {
            _farmer = new Farmer(15, 30);

            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("I need {0} bags of meat for {1} cows", _farmer.BagsOfFeed, _farmer.NumberOfCows);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            _farmer.NumberOfCows = (int)numericUpDown1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
