using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Excercises.The_Millionth_Fibonacci_Kata
{
    public class Fibonacci
    {
        public static BigInteger[] calc(BigInteger n)
        {
            if (n == 0)
            {
                BigInteger[] result = { 0, 1 };
                return result;
            }
            else if (n == 1)
            {
                BigInteger[] result = { 1, 1 };
                return result;
            }
            else
            {
                BigInteger[] r = calc(n / 2);
                BigInteger a = r[0];
                BigInteger b = r[1];
                BigInteger p = a * (2 * b - a);
                BigInteger q = b * b + a * a;

                if (n % 2 == 0)
                {
                    BigInteger[] result = { p, q };
                    return result;
                }
                else
                {
                    BigInteger[] result = { q, p + q };
                    return result;
                }
            }
        }

        public static BigInteger getNegativeNumber(BigInteger n)
        {
            return n * -1;
        }
        public static BigInteger fib(int n)
        {
            if (n >= 0) return calc(n)[0];
            else
            {
                if (n % 2 == 0)
                {
                    BigInteger[] result = calc(getNegativeNumber(n));
                    return getNegativeNumber(result[0]);
                }
                else
                {
                    BigInteger[] result = calc(getNegativeNumber(n));
                    return result[0];
                }
            }
        }
    }
}