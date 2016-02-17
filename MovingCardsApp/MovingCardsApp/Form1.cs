using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingCardsApp
{
	public partial class Form1 : Form
	{

		Random random = new Random();
		List<Card> deck1 = new List<Card>();
		List<Card> deck2 = new List<Card>();

		public Form1()
		{
			InitializeComponent();
		}

		private void RedrawDeck(int deckNumber)
		{
			if (deckNumber == 1)
			{
				deck1ListBox.Items.Clear();
				foreach (string cardName in deck1.GetCardNames())
				{
					deck1ListBox.Items.Add(cardName);
				}
				label1.Text = "Deck #1 (" + deck1.Count + " cards)";
			}
			else
			{
				deck2ListBox.Items.Clear();
				foreach (string cardName in deck1.GetCardNames())
				{
					deck2ListBox.Items.Add(cardName);
				}
				label2.Text = "Deck #2 (" + deck1.Count + " cards)";
			}
		}

		private void moveToDeck2Button_Click(object sender, EventArgs e)
		{
			int selectedIndex = deck1ListBox.SelectedIndex;
			var selectedCard = deck1[selectedIndex];
		}
	}
}
