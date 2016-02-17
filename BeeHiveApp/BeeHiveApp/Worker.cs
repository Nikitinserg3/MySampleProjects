using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHiveApp
{
    class Worker : Bee
    {
        private string[] _jobsICanDo;
        private int _shiftsToWork;
        private int _shiftsWorked;
        private string _currentJob = "";
        const double _honeyUnitsPerShitWorked = .65;

        public string CurrentJob
        {
            get
            {
                return _currentJob;
            }
        }

        public int ShiftsLeft
        {
            get
            {
                return _shiftsToWork - _shiftsWorked;
            }
        }

        public Worker(string[] jobsICanDo, double weighMg) : base(weighMg)
        {
            this._jobsICanDo = jobsICanDo;
        }

        public override double HoneyConsumtionRate()
        {
            double consumtion = base.HoneyConsumtionRate();
            consumtion += _shiftsWorked * _honeyUnitsPerShitWorked;
            return consumtion;
        }

        public bool DoThisJob(string job, int numberOfShifts)
        {
            if (!String.IsNullOrEmpty(_currentJob))
            {
                return false;
            }
            for (int i = 0; i < _jobsICanDo.Length; i++)
            {
                if (_jobsICanDo[i] == job)
                {
                    _currentJob = job;
                    this._shiftsToWork = numberOfShifts;
                    _shiftsWorked = 0;
                    return true;
                }
            }
            return false;
        }

        public bool DidYouFinish()
        {
            if (String.IsNullOrEmpty(_currentJob))
            {
                return false;
            }
            _shiftsWorked++;
            if (_shiftsWorked > _shiftsToWork)
            {
                _shiftsToWork = 0;
                _shiftsWorked = 0;
                _currentJob = "";
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
