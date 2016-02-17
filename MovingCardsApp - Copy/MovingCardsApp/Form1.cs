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
			RedrawDeck(1, true);
			RedrawDeck(2, true);
		}

		private void RedrawDeck(int deckNumber, bool isNew)
		{
			if (deckNumber == 1)
			{
				deck1ListBox.Items.Clear();

				if (isNew)
				{
					deck1.Clear();

					for (int i = 0; i < 10; i++)
					{
						deck1.Add(new Card((Suits)random.Next(4), (Values)random.Next(1, 14)));
					}
				}
				foreach (Card cardName in deck1)
				{
					deck1ListBox.Items.Add(cardName.Suit + " " + cardName.Value);
				}
				label1.Text = "Deck #1 (" + deck1.Count + " cards)";
			}
			else
			{
				deck2ListBox.Items.Clear();
				if (isNew)
				{
					deck2.Clear();
					for (int i = 0; i < 52; i++)
					{
						deck2.Add(new Card((Suits)random.Next(4), (Values)random.Next(1, 14)));
					}
				}
				foreach (Card cardName in deck2)
				{
					deck2ListBox.Items.Add(cardName.Suit + " " + cardName.Value);
				}
				label2.Text = "Deck #2 (" + deck2.Count + " cards)";
			}
		}

		private void moveToDeck2Button_Click(object sender, EventArgs e)
		{
			int selectedIndex = deck1ListBox.SelectedIndex;
			var selectedCard = deck1[selectedIndex];
			deck1.Remove(selectedCard);
			deck2.Add(selectedCard);
			RedrawDeck(1, false);
			RedrawDeck(2, false);
		}

		private void resetDeck1Button_Click(object sender, EventArgs e)
		{
			RedrawDeck(1, true);
		}

		private void resetDeck2Button_Click(object sender, EventArgs e)
		{
			RedrawDeck(2, true);
		}

		private void moveToDeck1Button_Click(object sender, EventArgs e)
		{
			int selectedIndex = deck2ListBox.SelectedIndex;
			var selectedCard = deck2[selectedIndex];
			deck2.Remove(selectedCard);
			deck1.Add(selectedCard);
			RedrawDeck(1, false);
			RedrawDeck(2, false);
		}

		private void ShuffleDeck(int deckNumber)
		{
			if (deckNumber == 1)
			{
				List<Card> tempDeck = new List<Card>();
				int count = deck1.Count;
                for (int i = 0; i < count; i++)
				{
					Card randomCard = deck1[random.Next(deck1.Count)];
                    tempDeck.Add(randomCard);
					deck1.Remove(randomCard);
				}
				deck1 = tempDeck;
			}
			else
			{
				List<Card> tempDeck = new List<Card>();
				int count = deck2.Count;
				for (int i = 0; i < count; i++)
				{
					Card randomCard = deck2[random.Next(deck2.Count)];
					tempDeck.Add(randomCard);
					deck2.Remove(randomCard);
				}
				deck2 = tempDeck;
			}
		}

		private void shuffleDeck1Button_Click(object sender, EventArgs e)
		{
			ShuffleDeck(1);
			RedrawDeck(1, false);
		}

		private void shuffleDeck2Button_Click(object sender, EventArgs e)
		{
			ShuffleDeck(2);
			RedrawDeck(2, false);
		}
	}
}
