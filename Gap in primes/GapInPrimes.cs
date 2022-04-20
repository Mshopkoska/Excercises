using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.Gap_in_primes
{
    internal class GapInPrimes
    {

        public static Boolean isPrime(long number)
        {
            if (number <= 0 || number == 1) return false;

            int i = 2;
            while (i <= Math.Sqrt(number))
            {
                if (number % i == 0)
                    return false;
                i += 1;
            }
            return true;
        }
        public static long[] Gap(int g, long m, long n)
        {
            long start = 0;
            long end = 0;
            int counter = 0;
            long[] result = new long[2];
            for (long i = m; i <= n + 1; i++)
            {
                if (isPrime(i))
                {
                    result[counter++] = i;
                    if (start == 0)
                    {
                        start = i;
                    }
                    else if (end == 0)
                    {
                        end = i;
                    }
                    else
                    {
                        start = end;
                        end = i;
                    }
                }
                if (end - start == g)
                {
                    result[0] = start;
                    result[1] = end;
                    return result;
                }
                counter = 0;
            }

            return null;
        }
    }

}
