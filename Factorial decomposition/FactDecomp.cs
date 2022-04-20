using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Excercises.Factorial_decomposition
{
    internal class FactDecomp
    {
        public static string Decomp(int n)
        {
            if (n == 1) return "1";

            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 2; i <= n; i++)
            {
                int currentNum = i;
                int counter = 0;

                for (int k = 2; k <= i;)
                {
                    int remainder = currentNum % k;

                    if (remainder != 0 || currentNum <= 1)
                    {
                        if (counter != 0)
                        {
                            if (dict.ContainsKey(k))
                            {
                                dict[k] = (int)dict[k] + counter;
                            }
                            else
                            {
                                dict.Add(k, counter);
                            }
                        }

                        k++;
                        counter = 0;
                    }
                    else
                    {
                        counter++;
                        currentNum /= k;
                    }
                }
            }
            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<int, int> entry in dict)
            {
                if (sb.Length != 0)
                {
                    sb.Append(" * ");
                }

                sb.Append(entry.Key);

                if ((int)entry.Value != 1)
                {
                    sb.Append("^").Append(entry.Value);
                }
            }
            return sb.ToString();
        }
    }
}
