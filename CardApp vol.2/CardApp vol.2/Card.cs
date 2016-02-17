using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardApp_vol._2
{
	public enum Color
	{
		Red,
		Black,
	}

	public enum Suits
	{
		Spades = 0,
		Clubs = 1,
		Diamonds = 2,
		Hearts = 3,
	}

	public enum Values
	{
		Ace = 1,
		Two = 2,
		Three = 3,
		Four = 4,
		Five = 5,
		Six = 6,
		Seven = 7,
		Eight = 8,
		Nine = 9,
		Ten = 10,
		Jack = 11,
		Queen = 12,
		King = 13,
	}

	public class Card
	{
		public Suits Suit { get; }
		public Values Value { get; }

		public string Name
		{
			get
			{
				return Value.ToString() + " of " + Suit.ToString();
			}
		}

		public Card(Suits suit, Values value)
		{
			Suit = suit;
			Value = value;
		}

		public override string ToString()
		{
			return Name;
		}

		public static bool DoesCardMatch (Card cardToCheck, Suits suit)
		{
			if (cardToCheck.Suit == suit)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		static public bool DoesCardMatch(Card cardToCheck, Values value)
		{
			if (cardToCheck.Value == value)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
