using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.Equal_sides_of_an_array
{
    public class Kata
    {
        public static int FindEvenIndex(int[] arr)
        {
            int preSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int postSum = 0;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    postSum += arr[j];
                }

                if (preSum == postSum)
                    return i;

                preSum += arr[i];
            }

            return -1;
        }
    }
}
