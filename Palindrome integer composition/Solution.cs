using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.Palindrome_integer_composition
{
    public class Solution
    {
        public static string Reverse(string text)
        {
            char[] array = text.ToCharArray();
            Array.Reverse(array);
            return new String(array);
        }
        public static List<int> assertSquareSums(int[] squares, int n)
        {
            List<int> result = new List<int>();
            int squareCount = squares.Count() - 1;
            
            // izmini broevi od 2 do count-1
            for (int range = 2; range < squareCount - 1; range++)
            {
                for (int shift = 1; shift < squareCount - range + 1; shift++)
                {
                    
                    int sum = 0;
                    // soberi gi broevite
                    for (int i = 0; i < range; i++)
                    {
                        sum += squares[shift + i];
                    }
                    if (sum <= n && (sum.ToString() == Reverse(sum.ToString()))) // ako e palindrom i sumata e dobra dodadi u lista
                    {
                        result.Add(sum);
                    }
                    else if (sum > n)
                    { break; }
                }

            }

            return result;
        }
        public static int values(int n)
        {

            List<int> result = new List<int>();
            int maxSquareBase = Convert.ToInt32(Math.Floor(Math.Sqrt(n)));
            int[] squares = new int[maxSquareBase + 1];
            for (int i = 1; i <= maxSquareBase; i++)
            { squares[i] = Convert.ToInt32(Math.Pow(i, 2)); }

            result = assertSquareSums(squares, n);
            return result.Distinct().Count();
        }

        /*public static void Main()
        {

            int r = values(100);
            Console.WriteLine(r);
        }*/
    }

}
