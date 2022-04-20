using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.What_s_a_Perfect_Power_anyway
{
    internal class PerfectPower
    {
        public static (int, int)? IsPerfectPower(int n)
        {
            int[] pair = new int[2];

            int myLog = (int)Math.Floor(Math.Log(n, 2) + 1);
            for (int i = 2; i <= myLog; i++)
            {
                //As a Math rule I only need to check below Base 2 Log of number
                int x = Convert.ToInt32(Math.Pow(n, 1.0 / i));
                if (n == Math.Pow(x, i))
                {
                    pair[0] = x;
                    pair[1] = i;
                    break;
                }
            }
            if (pair[0] == 0 || pair[1] == 0) return null;
            return (pair[0], pair[1]);
        }
    }
}
