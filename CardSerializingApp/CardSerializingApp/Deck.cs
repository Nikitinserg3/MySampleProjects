using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardSerializingApp
{
	[Serializable]
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

		public Card Peek(int cardNumber)
		{
			return cards[cardNumber];
		}

		public Card Deal()
		{
			return Deal(0);
		}

		public bool ContainsValue(Values value)
		{
			foreach (Card card in cards)
			{
				if (card.Suit == value)
				{
					return true;
				}
			}
			return false;
		}

		public Deck PullOutValues (Values value)
		{
			Deck deckToReturn = new Deck(new Card[] { });
			for (int i = cards.Count - 1; i >=0; i--)
			{
				if (cards[i].Suit == value)
				{
					deckToReturn.AddCard(Deal(i));
				}
			}
			return deckToReturn;
		}

		public bool HasBook(Values value)
		{
			int numberOfCards = 0;
			foreach (Card card in cards)
			{
				if (card.Suit == value)
				{
					numberOfCards++;
				}
			}
			if (numberOfCards == 4)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public void SortByValue()
		{
			cards.Sort(new CardComparerByValue());
		}
	}
}
