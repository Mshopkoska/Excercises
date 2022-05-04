using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.Find_The_Parity_Outlier
{
    public class Kata
    {
        public static int Find(int[] integers)
        {
            List<int> even = new List<int>();
            List<int> odd = new List<int>();
            foreach(int i in integers)
            {
                if (i % 2 == 0)
                    even.Add(i);
                else
                    odd.Add(i);

                if (even.Count > 1 && odd.Count > 0)
                    return odd[0];
                if (even.Count > 0 && odd.Count > 1)
                    return even[0];
            }
            return 0;
        }
    }
}
