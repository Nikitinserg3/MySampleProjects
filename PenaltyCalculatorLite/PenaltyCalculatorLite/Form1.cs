using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PenaltyCalculatorLite
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void saveReportButton_Click(object sender, EventArgs e)
		{
			saveFileDialog.Filter = "Text files (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				Calculate(saveFileDialog.FileName);
			}
		}

		public void Calculate(string fileName)
		{
			double sum = Convert.ToDouble(sumTextBox.Text);
			double penalty = Convert.ToDouble(penaltyTextBox.Text) * 0.01;
			int days = Convert.ToInt32(daysTextBox.Text);

			Stream stream = File.Create("Report.txt");
			StreamWriter writer = new StreamWriter(stream);

			double totalSum = sum;
			double currentPenalty = 0;

			for (int i = 1; i <= days; i++)
			{
				currentPenalty = totalSum * penalty;
				totalSum += currentPenalty;
				writer.WriteLine("День {0} - мне должны {1} денег",i,totalSum);
			}
			writer.Close();
		}
	}
}
