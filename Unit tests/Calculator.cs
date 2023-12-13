using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_tests
{
    internal class Calculator
    {
        public int Sum(int i1, int i2)
        {
            return i1 + i2;
        }

        public int Substract(int i1, int i2)
        {
            return i1 - i2;
        }

        public bool Compare(int i1, int i2)
        {
            var sum = Sum(i1, i2);
            var multiply = Multiply(i1, i2);
            return multiply > sum;
        }

        public int Multiply(int i1, int i2)
        {
            return i1 * i2;
        }

        public bool CompareSimple(int i1, int i2)
        {
            if (i1 > i2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
