using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.Bit_Counting
{
    public class Kata
     {
        public static int CountBits(int n)
        {
            int result = 0;
            while (n > 0)
            {
                if (n % 2 == 1)
                    result++;
                n >>= 1;
            }
            return result;
        }
    }
}

