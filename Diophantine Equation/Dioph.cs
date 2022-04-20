using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.Diophantine_Equation
{
    internal class Dioph
    {
        public static string solEquaStr(long n)
        {
            List<long[]> result = new List<long[]>();
            int max = (int)Math.Sqrt((double)n);

            long xMinus2y = 0;
            long xPlus2y = 0;
            long x, y;

            for (int i = 1; i <=max; ++i)
            {
                long temp = n % i;
                if (n % i == 0)
                {
                    xMinus2y = i;
                    xPlus2y = n / i;
                    if ((xPlus2y + xMinus2y) % 2 == 0 && (xPlus2y - xMinus2y) % 4 == 0)
                    {
                        x = (xPlus2y + xMinus2y) / 2;
                        y = (xPlus2y - xMinus2y) / 4;

                        long[] xy = { x, y };
                        result.Add(xy);
                    }
                }
            }

            StringBuilder st = new StringBuilder();
            st.Append("[");
            if (result.Count > 0)
            {
                foreach (long[] xy in result)
                {
                    st.Append(String.Format("[{0}, {1}], ", xy[0], xy[1]));
                }
                st.Length -= 2;

            }
            st.Append("]");
            return st.ToString();
        }
    }
}
