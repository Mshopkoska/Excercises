using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.Sort_the_odd
{
    public class Kata
    {
        public static int[] SortArray(int[] array)
        {
            int length = array.Length;
            if (length <= 0) return array;
            int i = 0;
            while (i < length)
            {
                while (i < length && array[i] % 2 == 0) i++;
                int j = i + 1;
                while (j < length)
                {
                    while (j < length && array[j] % 2 == 0) j++;
                    if (j < length && array[i] % 2 != 0 && array[j] % 2 != 0 && array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                    j++;
                }
                i++;
            }
            return array;
        }
    }
}
