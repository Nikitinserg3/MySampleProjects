using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PenaltyCalculator
{
	public partial class Form1 : Form
	{
		Contract contract;

		public Form1()
		{
			InitializeComponent();
		}

		private void penaltySumText_TextChanged(object sender, EventArgs e)
		{

		}

		private void saveReportButtton_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Text File|*.txt";
			saveFileDialog.Title = "Save an Text File";
			saveFileDialog.ShowDialog();

			if (saveFileDialog.FileName != "")
			{
				Stream stream = saveFileDialog.OpenFile();
				contract = new Contract(Convert.ToDouble(contractSumText.Text), Convert.ToDouble(penaltySumText.Text), contractEndDate.Value, currentDate.Value);
				StreamWriter writer = new StreamWriter(stream);

				var startDate = contractEndDate.Value;
				var endDate = currentDate.Value;
				var period = endDate - startDate;

				double startSum = Convert.ToDouble(contractSumText.Text);
				double convPenalty = Convert.ToDouble(penaltySumText.Text) * 0.01;
				double totalSum = startSum;
				
                for (int i = 0; i < period.Days; i++)
				{
					startDate = startDate.AddDays(1);
					totalSum += startSum * convPenalty;
					writer.WriteLine("{0} --- {1}", startDate.ToShortDateString(), Math.Round(totalSum,2));
				}
				writer.Close();
			}
		}
	}
}
