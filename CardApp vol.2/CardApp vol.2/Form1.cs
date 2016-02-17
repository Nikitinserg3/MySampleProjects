using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardApp_vol._2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void checkButton_Click(object sender, EventArgs e)
		{
			Card cardToCheck = new Card(Suits.Clubs, Values.Three);
			bool doesItMatch = Card.DoesCardMatch(cardToCheck, Suits.Hearts);
			textBox.Text = doesItMatch.ToString();
		}
	}
}
