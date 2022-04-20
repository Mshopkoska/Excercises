using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.Perimeter_of_squares_in_a_rectangle
{
    internal class SumFct
    {

        public static BigInteger perimeter(BigInteger n)
        {
            // your code
            BigInteger sum = 2;
            BigInteger first = 1, second = 1;
            BigInteger temp = 0;

            if (n <= 0)
                return 0;

            for (int i = 1; i < n; i++)
            {
                temp = first;
                first = second;
                second += temp;

                sum += second;
            }

            sum = sum << 2;

            return sum;

        }
    }
}
