using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenaltyCalculator
{
	class Contract
	{
		private DateTime _endDate;
		private DateTime _currentDate;
		private double _sum;
		private double _penalty;



		public Contract(double sum, double penalty, DateTime endDate, DateTime currentDate)
		{
			_sum = sum;
			_penalty = penalty * 0.01;
			_endDate = endDate;
			_currentDate = currentDate;
		}

		public void Calculating()
		{
			Stream stream = File.Create("Report.txt");
			StreamWriter writer = new StreamWriter(stream);

			//for (DateTime i = _endDate; i < _currentDate; i++)
			//{
			//	double totalSum = _sum;
			//	double currentPenalty = totalSum * _penalty;
			//	totalSum += currentPenalty;
			//	writer.WriteLine("{0} - Текущая сумма с учетом пени = {1}", i, totalSum);
			//}
		}
	}
}
