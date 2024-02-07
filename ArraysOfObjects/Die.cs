using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysOfObjects
{
    internal class Die
    {

        private int _sideUp;
        private int _numSides;

        public Die(int numSides)
        {
            _numSides = numSides;
            Roll();
        }

        public void Roll()
        {
            Random rng = new Random();
            _sideUp = rng.Next(1, _numSides + 1);
        }

        public int GetSideUp()
        {
            return _sideUp;
        }
    }
}
