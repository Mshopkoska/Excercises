using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.Next_bigger_number_with_the_same_digits
{
    public class Kata
    {
        public static long NextBiggerNumber(long n)
        {
            char[] digits = n.ToString().ToCharArray();
            Array.Sort(digits);
            Array.Reverse(digits);

            long biggest = long.Parse(String.Join("", digits));

            for (long i = n + 1; i <= biggest; i++) 
            {
                char[] curr = i.ToString().ToCharArray();
                Array.Sort(curr);
                Array.Reverse(curr);

                long current = long.Parse(String.Join("", curr));
                if(biggest == current)
                {
                    return i;
                }
            }
            return -1;
        }

      /* public static void Main()
        {
            long res = NextBiggerNumber(123456789);
            Console.WriteLine(res);
        }*/
    }
}
