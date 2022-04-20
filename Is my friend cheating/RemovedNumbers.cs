using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.Is_my_friend_cheating
{
    internal class RemovedNumbers
    {

        public static List<long[]> removNb(long n)
        {
            long sumOfFull = (n * (n + 1)) / 2;
            List<long[]> ret = new List<long[]>();
            for (int i = 1; i < n; i++)
            {
                long y = (sumOfFull - i) / (i + 1);
                if ((sumOfFull - i) % (i + 1) != 0 || y > n || y < 0)
                    continue;

                List<long> temp = new List<long>();
                temp.Add(i);
                temp.Add(y);
                ret.Add(temp.ToArray());
            }

            return ret;
        }
    }
}
