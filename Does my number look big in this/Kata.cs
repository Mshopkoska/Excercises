using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.Does_my_number_look_big_in_this
{
    public class Kata
    {
        public static bool Narcissistic(int value)
        {
            if (value == 0)
            { return true; }
            int numDigits = (int)Math.Log10(value) + 1;
            int sum = 0;
            foreach (var dig in value.ToString())
            {
                sum += (int)Math.Pow(dig - '0', numDigits);
                if (sum > value) { System.Console.WriteLine("over"); return false; }
            }
            return value == sum;
        }
    }
}
