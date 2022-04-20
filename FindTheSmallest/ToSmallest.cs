using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.FindTheSmallest
{
    internal class ToSmallest
    {

        public static long[] Smallest(long n)
        {
            string s = n.ToString();
            long min1 = n;
            int from1 = 0;
            int to1 = 0;

            for (int i = 0; i < s.Length; i++)
            {
                var removed = s[..i] + s[(i + 1)..];
                for (int j = 0; j < removed.Length + 1; j++)
                {
                    long num = long.Parse(removed[..j] + s[i] + removed[j..]);

                    if (num < min1)
                    {
                        min1 = num;
                        from1 = i;
                        to1 = j;
                    }
                }
            }
            return new long[] { min1, from1, to1 };


        }
    }
}
