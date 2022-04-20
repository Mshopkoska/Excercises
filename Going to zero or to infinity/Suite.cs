using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.Going_to_zero_or_to_infinity
{
    internal class Suite
    {
        public static double going(int n)
        {
            double result = 0;

            if (n == 0)
                return 0;
            if (n == 1)
                return 1;

            for (int i = 2; i <= n; i++)
                result = (result + 1) / i;

            double temp = result * 1000000;
            double dTemp = temp;
            result = (dTemp / 1000000);

            return result + 1;
        }
    }
}
