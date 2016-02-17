using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingCardsApp
{
	public class Deck
	{
		private List<Card> cards;
		private int _count;

		public Deck()
		{
			cards = new List<Card>();
			for (int suit = 0; suit <= 3; suit++)
			{
				for (int value = 0; value <= 13; value++)
				{
					cards.Add(new Card((Suits)suit, (Values)value));
				}
			}
		}

		public Deck(IEnumerable<Card> initialCards)
		{
			cards = new List<Card>(initialCards);
		}

		public int Count
		{
			get
			{
				return cards.Count;
			}
		}

		public void AddCard(Card cardToAdd)
		{
			cards.Add(cardToAdd);
		}

		public Card Deal(int index)
		{
			Card cardToDeal = cards[index];
			cards.RemoveAt(index);
			return cardToDeal;
		}

		public void 
	}
}
