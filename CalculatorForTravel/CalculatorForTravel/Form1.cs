using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorForTravel
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            
            if (startMileage.Value <= endMileage.Value)
            {
                
                
                totalAmountLabel.Text = "Total payment is $" + Calculation(startMileage.Value, endMileage.Value).ToString();
            }
            else
            {
                MessageBox.Show("Entel correct mileage");
            }

        }
        public double Calculation(decimal start, decimal end)
        {
            start = startMileage.Value;
            end = endMileage.Value;
            double result = 0;

            return result = ((double)end - (double)start) * .38;
        }
    }
}


