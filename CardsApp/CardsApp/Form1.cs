using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardsApp
{
	public partial class Form1 : Form
	{
		Random random = new Random();


		public Form1()
		{
			InitializeComponent();
			int numberBetween0and3 = random.Next(4);
			int numberBetween1and13 = random.Next(1, 14);
			int anyRandomInteger = random.Next();

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void cardSelecterButton_Click(object sender, EventArgs e)
		{
			Card card = new Card((Suits)random.Next(4), (Values)random.Next(1, 14));
			MessageBox.Show(card.Name);
		}
	}
}
