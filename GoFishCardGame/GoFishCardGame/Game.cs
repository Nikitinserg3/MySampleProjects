using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoFishCardGame
{
	public class Game
	{
		private List<Player> _players;
		private Dictionary<Values, Player> _books;
		private Deck _stock;
		private TextBox _textBoxOnForm;

		public Game(string playerName, IEnumerable<string> opponentsNames, TextBox textBoxOnForm)
		{
			Random random = new Random();
			this._textBoxOnForm = textBoxOnForm;
			_players = new List<Player>();
			_players.Add(new Player(playerName, random, textBoxOnForm));
			foreach (string player in opponentsNames)
			{
				_players.Add(new Player(player, random, textBoxOnForm));
			}
			_books = new Dictionary<Values, Player>();
			_stock = new Deck();
			Deal();
			_players[0].SortHand();
		}

		private void Deal()
		{
			_stock.Shuffle();
			for (int i = 0; i < 5; i++)
			{
				foreach (Player player in _players)
				{
					player.TakeCard(_stock.Deal());
				}
			}
			foreach (Player player in _players)
			{
				PullOutBooks(player);
			}
		}

		public bool PlayOneRound(int selectedPlayerCard)
		{
			Values cardToAskFor = _players[0].Peek(selectedPlayerCard).Value;
			for (int i = 0; i < _players.Count; i++)
			{
				if (i == 0)
				{
					_players[0].AskForACard(_players, 0, _stock, cardToAskFor);
				}
				else
				{
					_players[i].AskForACard(_players, i, _stock);
				}
				if (PullOutBooks(_players[i]))
				{
					_textBoxOnForm.Text += _players[i].Name + " drew a new hand" + Environment.NewLine;
					int card = 1;
					while (card <= 5 && _stock.Count > 0)
					{
						_players[i].TakeCard(_stock.Deal());
						card++;
					}
				}
				_players[0].SortHand();
				if (_stock.Count == 0)
				{
					_textBoxOnForm.Text = "The stock is out of cards. Game over!" + Environment.NewLine;
					return true;
				}
			}
			return false;
		}

		public bool PullOutBooks(Player player)
		{
			IEnumerable<Values> booksPulled = player.PullOutBooks();
			foreach (Values value in booksPulled)
			{
				_books.Add(value, player);
			}
			if (player.CardCount == 0)
			{
				return true;
			}
			return false;
		}

		public string DescribeBooks()
		{
			string whoHasWhichBooks = "";
			foreach (Values value in _books.Keys)
			{
				whoHasWhichBooks += _books[value].Name + " has a book of " + Card.Plural(value) + Environment.NewLine;
			}
			return whoHasWhichBooks;
		}

		public string GetWinnerName()
		{
			Dictionary<string, int> winners = new Dictionary<string, int>();
			foreach (Values value in _books.Keys)
			{
				string name = _books[value].Name;
				if (winners.ContainsKey(name))
				{
					winners[name]++;
				}
				else
				{
					winners.Add(name, 1);
				}
			}
			int mostBooks = 0;
			foreach (string name in winners.Keys)
			{
				if (winners[name] > mostBooks)
				{
					mostBooks = winners[name];
				}
			}
			bool tie = false;
			string winnerList = "";
			foreach (string name in winners.Keys)
			{
				if (winners[name] == mostBooks)
				{
					if (!String.IsNullOrEmpty(winnerList))
					{
						winnerList += " and ";
						tie = true;
					}
					winnerList += name;
				}
			}
			winnerList += " with " + mostBooks + " book";
			if (tie)
			{
				return "A tie between " + winnerList;
			}
			else
			{
				return winnerList;
			}
		}

		public IEnumerable<string> GetPlayerCardNames()
		{
			return _players[0].GetCardNames();
		}

		public string DescribePlayerHands()
		{
			string description = "";
			for (int i = 0; i < _players.Count; i++)
			{
				description += _players[i].Name + " has " + _players[i].CardCount;
				if (_players[i].CardCount == 1)
				{
					description += " card." + Environment.NewLine;
				}
				else
				{
					description += " cards." + Environment.NewLine;
				}
			}
			description += "The stock has " + _stock.Count + " cards left.";
			return description;
		}

		
	}
}
