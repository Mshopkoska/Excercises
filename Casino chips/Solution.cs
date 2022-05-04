using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.Casino_chips
{
    public class Solution
    {


        public static int solve(int[] arr)
        {
            Array.Sort(arr);
            if (arr[0] + arr[1] <= arr[2])
            {
                return arr[0] + arr[1];
            }
            else return (arr.Sum() / 2);
        }
        /* arr = sorted(arr)

    if arr[0] + arr[1] <= arr[2]:
        return arr[0] + arr[1]
    else:
        return sum(arr) // 2*/
    }
}
