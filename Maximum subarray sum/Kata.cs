using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.Maximum_subarray_sum
{
    public static class Kata
    {
        public static int MaxSequence(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j <= arr.Length; j++)
                {
                    var slice = arr[i..j];
                    int newSum = slice.Sum();
                    if (newSum > sum)
                    {
                        sum = newSum;
                    }
                }
            }

            return sum > 0 ? sum : 0;
        }
    }
}
