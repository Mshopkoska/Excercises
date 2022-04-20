using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.MoveZeros
{
    internal class MoveZeroesToEnd
    {
        public static int[] MoveZeroes(int[] arr)
        {
            List<int> r = new List<int>(arr);
            int count = arr.Length;

            r.RemoveAll(x => x == 0);
            for (int i = r.Count; i < count; i++)
            {
                r.Add(0);
            }

            return r.ToArray();
        }
    }
}
