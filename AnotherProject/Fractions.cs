using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherProject
{
    public class Fractions
    {
        public virtual string SumFractions(int x1, int x2, int y1, int y2)
        {
            //1 2 3 4
            // 4
            //12
            //6
            //12
            int tempY1 = y1;
            x1 = x1 * y2;
            y1 = y1 * y2;
            x2 = x2 * tempY1;
            y2 = y2 * tempY1;
            return $"{x1 + x2}/{y1}";
        }
    }
}
