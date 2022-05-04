using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.Next_smaller_number_with_the_same_digits
{
    public class Kata
    {
         public static Boolean hasSameDigits(long n, long m)
         {
             //dali n i m imaat isti digits
             var setN = new HashSet<char> (n.ToString().ToCharArray());
             var setM = new HashSet<char>(m.ToString().ToCharArray());

             if (setN.SetEquals(setM)) return true;
             return false;
         }
         public static long NextSmaller(long n)
         {
             char[] digits = n.ToString().ToCharArray();
             Array.Sort(digits);


             long smallest = long.Parse(String.Join("", digits));
             long number = 0;
             for (long i = n-1 ; i >= smallest; i--) 
             {
                 if (hasSameDigits(n, i)){
                     number = i;
                     break;
                 }
             }
             if (number != 0) return number;
             else return -1;
         }

         /*public static void Main()
         {
             long n = 123456798;
             long smallest = NextSmaller(n);
             Console.WriteLine(smallest);
         }*/


        
        

       /* static IList<long> Permute(int[] nums)
        {
            var list = new List<long>();
            return DoPermute(nums, 0, nums.Length - 1, list);
        }

        static IList<long> DoPermute(int[] nums, int start, int end, IList<long> list)
        {
            if (start == end)
            {
                // We have one of our possible n! solutions,
                // add it to the list.
                string digits = string.Join("", nums);
                long number = long.Parse(digits);
                if (!list.Contains(number)) list.Add(number);
                
            }
            else
            {
                for (var i = start; i <= end; i++)
                {
                    Swap(ref nums[start], ref nums[i]);
                    DoPermute(nums, start + 1, end, list);
                    Swap(ref nums[start], ref nums[i]);
                }
            }

            return list;
        }
        static void Swap(ref int a, ref int b)
        {
            var temp = a;
            a = b;
            b = temp;
        }


        public static long NextSmaller(long n)
        {
            char[] digits = n.ToString().ToCharArray();
            int[] intDigits = Array.ConvertAll(digits, c => (int)Char.GetNumericValue(c));

            IList <long> allPossibleNumbers = Permute(intDigits);
            allPossibleNumbers.Remove(n);
            if (allPossibleNumbers.Count == 0) return -1;
            else
            {
                long[] numbers = allPossibleNumbers.ToArray();
                Array.Sort(numbers);
                Array.Reverse(numbers);
                //Console.WriteLine(numbers[0]);
                return numbers[0];
            }
        }*/

        
    }
}
