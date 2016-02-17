using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinnerParty
{
    
    public partial class Form1 : Form
    {
        DinnerParty party = new DinnerParty();

        public Form1()
        {
            InitializeComponent();
        }

        private void healthyOptionCheck_CheckedChanged(object sender, EventArgs e)
        {
            //party.SetHealthyOption(healthyOptionCheck.Checked);
            totalCostLabel.Text = party.CalculateCostReborn(fancyDecorationCheck.Checked, healthyOptionCheck.Checked).ToString("C");
        }

        private void fancyDecorationCheck_CheckedChanged(object sender, EventArgs e)
        {
            //party.SetFancyDecoration(fancyDecorationCheck.Checked);
            totalCostLabel.Text = party.CalculateCostReborn(fancyDecorationCheck.Checked, healthyOptionCheck.Checked).ToString("C");
        }

        private void numberOfGuests_ValueChanged(object sender, EventArgs e)
        {
            party.NumberOfPeople = (int)numberOfGuests.Value;
            totalCostLabel.Text = party.CalculateCostReborn(fancyDecorationCheck.Checked, healthyOptionCheck.Checked).ToString("C");
        }

        private void totalCostLabel_Click(object sender, EventArgs e)
        {

        }

    }
}
