using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Excercises.Primes_in_numbers
{
    internal class PrimeDecomp
    {
        public static String factors(int lst)
        {
            int i = 2;
            Dictionary<int, int> res = new Dictionary<int, int>();

            while ((lst / i) != 0)
            {
                if (lst % i == 0)
                {
                    if (res.ContainsKey(i))
                    {
                        res[i] = (int)res[i] + 1;
                    }
                    else
                    {
                        res[i] = 1;
                    }
                    lst = lst / i;
                }
                else
                {
                    i += 1;
                }
            }

            if (!res.ContainsKey(i))
            {
                res[i] = 1;
            }

            List<int> keys = res.Keys.ToList();
            keys.Sort();

            StringBuilder st = new StringBuilder();
            foreach (int factor in keys)
            {
                //"(2**5)(5)(7**2)(11)"
                //"2^10 * 3^5 * 5^2 * 7 * 11"
                if ((int)res[factor] == 1)
                {
                    st.Append("(" + factor + ")");
                }
                else
                {
                    st.Append("(" + factor + "**" + res[factor] + ")");
                }
            }
            return st.ToString();
        }

    }
}
