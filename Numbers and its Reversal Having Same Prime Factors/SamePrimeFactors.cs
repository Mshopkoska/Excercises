using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.Numbers_and_its_Reversal_Having_Same_Prime_Factors
{
    public class SamePrimeFactors
    {
        public static Boolean isPalindrome(int n)
        {
            string number = n.ToString();

            char[] rev = n.ToString().ToCharArray();
            Array.Reverse(rev);

            string reversed = String.Join("",rev);

            return number==reversed;
        }

        public static List<int> getDivisors(int num)
        {
            List<int> divisors = new List<int>();

            int count = 0;
            Boolean flag = false;

            for (int i = 2; i < num; i++)
            {
                // check for divisibility
                if (num % i == 0)
                {
                    count = 0;
                    // check for prime number
                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                            count++;
                    }
                    if (count == 2)
                    {
                        flag = true;
                        divisors.Add(i);

                    }
                }
            }
            divisors.Sort();
            return divisors;
        }

        public static Boolean samePrimes(int n)
        {
            char[] reversed = n.ToString().ToCharArray();
            Array.Reverse(reversed);
            int reversedInt = Int32.Parse(String.Join("",reversed));

            List<int> primesN = getDivisors(n);
            List<int> primesReversed = getDivisors(reversedInt);

            if (primesN.SequenceEqual(primesReversed) && primesN.Count!=0 && primesReversed.Count!=0)
            {
                return true;
            }
            else return false;
        }

        public static int[] SameFactRev(int nMax)
        {

            List<int> numbers = Enumerable.Range(1, nMax).ToList();

            List<int> result = new List<int>();
            //lista od breovite sto ne se palindromi
            numbers = numbers.Where(x => !isPalindrome(x)).ToList();

            numbers = numbers.Where(x => samePrimes(x)).ToList();

            return numbers.ToArray();

        }


       /* public static void Main()
        {
            int[] r = SameFactRev(1000);
            foreach(int n in r)
            {
                Console.WriteLine(n);
            }
        }*/
    }
}
