using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedLumberJackApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private Queue<Lumberjack> breakfastLine = new Queue<Lumberjack>();

		private void addFlapjackButton_Click(object sender, EventArgs e)
		{
			if (breakfastLine.Count == 0)
			{
				return;
			}

			Flapjack food;

			if (crispyButton.Checked == true)
			{
				food = Flapjack.Crispy;
			}
			else if (soggyButton.Checked == true)
			{
				food = Flapjack.Soggy;
			}
			else if (brownedButton.Checked == true)
			{
				food = Flapjack.Browned;
			}
			else
			{
				food = Flapjack.Banana;
			}
		}

		private void addLumberjackButton_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(nameTextBox.Text)) return;
			breakfastLine.Enqueue(new Lumberjack(nameTextBox.Text));
			nameTextBox.Text = "";
			RedrawList();
		}

		private void RedrawList()
		{
			int number = 1;
			lineListBox.Items.Clear();
			foreach (Lumberjack item in breakfastLine)
			{
				lineListBox.Items.Add(number + ". " + item.Name);
				number++;
			}
			if (breakfastLine.Count == 0)
			{
				groupBox1.Enabled = false;
				nextInLine.Text = "";
			}
			else
			{
				groupBox1.Enabled = true;
				Lumberjack currentLumberjack = breakfastLine.Peek();
				nextInLine.Text = currentLumberjack.Name + " has " + currentLumberjack.FlapjackCount + " flapjacks";
			}
		}

		private void nextLumberjackButton_Click(object sender, EventArgs e)
		{
			if (breakfastLine.Count == 0)
			{
				return;
			}
			Lumberjack nextLumberjack = breakfastLine.Dequeue();
			nextLumberjack.EatFlapjacks();
			nextInLine.Text = "";
			RedrawList();
		}
	}
}
