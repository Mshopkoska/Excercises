using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.Zero_fill._for_the_Queen
{
    public static class Kata
    {
        public static string ZeroFill(int number, int size)
        {
            number = number < 0 ? (int)Math.Floor((decimal)number * -1) : (int)Math.Floor((decimal)number);

            return generateZeroes(size - number.ToString().Length) + number;
        }

        public static string generateZeroes(int n)
        {
            string result = "";
            for (int i = 0; i < n; i++)
            {
                result += "0";
            };
            return result;
        }
    }
}

