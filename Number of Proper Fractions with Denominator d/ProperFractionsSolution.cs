using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.Number_of_Proper_Fractions_with_Denominator_d
{
    public class ProperFractionsSolution
    {
        private static List<long> primeFactors(long numbers)
        {
            long n = numbers;
            List<long> factors = new List<long>();
            for (long i = 2; i <= n / i; i++)
                while (n % i == 0)
                {
                    factors.Add(i);
                    n /= i;
                }
            if (n > 1) factors.Add(n);
            var set = new HashSet<long>(factors);
            Array.Sort(set.ToArray());

            return set.ToList();
        }
        public static long ProperFractions(long n)
        {
            if (n == 1) return 0;
            long c = n;
            List<long> pfs = primeFactors(n);
            foreach(long pf in pfs) c -= c / pf;
            return c;
        }
    }
}
