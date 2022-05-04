using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.Number_of_trailing_zeros_of_N_
{
    public static class Kata
    {
        public static int TrailingZeros(int n)
        {
            int zeros = 0;
            while(n> 0)
            {
                n =(int)Math.Floor((decimal)n/5);   
                zeros+=n;
            }
            return zeros;
        }
    }
}
