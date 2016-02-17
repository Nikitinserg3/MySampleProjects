using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersGame
{
    class Stats
    {
        public int _total;
        public int _missed;
        public int _correct;
        public int _accuracy;

        public void UpdateStats(bool correctKey)
        {
            _total++;
            if (correctKey == true)
            {
                _correct++;
            }
            else
            {
                _missed++;
            }
            _accuracy = _correct * 100 / (_missed + _correct);
        }
    }
}
