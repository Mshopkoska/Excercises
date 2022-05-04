using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Excercises.Sum_strings_as_numbers
{
    public static class Kata
    {
        public static string sumStrings(string a, string b)
        {
            if (a == "") return b;
            if (b == "") return a;

            BigInteger aa = BigInteger.Parse(a);
            BigInteger bb = BigInteger.Parse(b);


            BigInteger res = aa + bb;
            return res.ToString();
        }
    }
}
