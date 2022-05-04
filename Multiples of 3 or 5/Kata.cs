using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.Multiples_of_3_or_5
{
    public static class Kata
    {
        public static int Solution(int value)
        {
            int result = 0;
            for (int x = 1; x < value; x++) { if (x % 3 == 0 || x % 5 == 0) { result += x; } }
            return result;
        }
    }
}
