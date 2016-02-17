using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHiveApp
{
    class Queen : Bee
    {
        private Worker[] workers;
        private int _shiftNumber = 0;

        public Queen(Worker[] workers, double weightMg) : base(weightMg)
        {
            this.workers = workers;
        }

        public bool AssignToWork(string job, int numberOfShifts)
        {
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].DoThisJob(job, numberOfShifts))
                {
                    return true;
                }
            }
            return false;
        }

        public string WorkTheNextShift()
        {
            double honeyConsumed = HoneyConsumtionRate();
            _shiftNumber++;
            string report = "Report for shift#" + _shiftNumber + "\r\n";
            for (int i = 0; i < workers.Length; i++)
            {
                honeyConsumed += workers[i].HoneyConsumtionRate();
                if (workers[i].DidYouFinish())
                {
                    report += "Worker #" + (i + 1) + "just finished  work\r\n";
                }
                if (String.IsNullOrEmpty(workers[i].CurrentJob))
                {
                    report += "Worker #" + (i + 1) + "doesn't work\r\n";
                }
                else
                {
                    if (workers[i].ShiftsLeft > 0)
                    {
                        report += "Worker #" + (i + 1) + "is doing '" + workers[i].CurrentJob + "' still " + workers[i].ShiftsLeft + " shifts\r\n";
                    }
                    else
                    {
                        report += "Worker #" + (i + 1) + "will finish '" + workers[i].CurrentJob + "' after this shift\r\n";
                    }
                }
            }
            report += "Total honey consumed for the shift: " + honeyConsumed + " units \r\n";
            return report;
        }

        private void DefendTheHive(IStingPatrol patroller)
        {

        }
    }
}
