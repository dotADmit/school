using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school
{
    class MarkGenerator
    {
        private int _probabilityAn5Mark;
        private int _probabilityAn4Mark;
        private int _probabilityAn3Mark;
        private int _probabilityAn2Mark;
        private Random _rnd = new Random();
        public void SetMarkSettings(MarkGeneratorSettings settings)
        {
            _probabilityAn5Mark = settings.ProbabilityAn5Mark;
            _probabilityAn4Mark = settings.ProbabilityAn4Mark;
            _probabilityAn3Mark = settings.ProbabilityAn3Mark;
            _probabilityAn2Mark = settings.ProbabilityAn2Mark;
        }
        public int GetRandomMark()
        {
            int numOf100 = _rnd.Next(0, 101);
            if (numOf100 <= _probabilityAn2Mark && _probabilityAn2Mark != 0)
            {
                return 2;
            }
            if (numOf100 > _probabilityAn2Mark && numOf100 <= _probabilityAn2Mark + _probabilityAn3Mark && _probabilityAn3Mark != 0)
            {
                return 3;
            }
            if (numOf100 > _probabilityAn2Mark + _probabilityAn3Mark && numOf100 <= _probabilityAn2Mark + _probabilityAn3Mark + _probabilityAn4Mark && _probabilityAn4Mark != 0)
            {
                return 4;
            }
            return 5;
        }
    }
}
