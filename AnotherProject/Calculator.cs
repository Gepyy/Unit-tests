using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherProject
{
    public class Calculator
    {
        public Fractions Fract = new Fractions();
        public Calculator()
        {

        }
        public Calculator(Fractions fract)
        {
            Fract = fract;
        }

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
            return i1 > i2;
        }
        public string SumFractions(int x1, int x2, int y1, int y2)
        {
            return Fract.SumFractions(x1, x2, y1, y2);
        }
    }
}
