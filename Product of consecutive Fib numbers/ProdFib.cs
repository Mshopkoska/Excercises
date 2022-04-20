using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.Product_of_consecutive_Fib_numbers
{ 
    public class ProdFib
    {
        public static ulong fib(ulong n)
        {
            ulong a = 1;
            ulong b = 1;
            ulong c = 0;

            for (ulong i = 0; i < n - 1; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }

            return a;
        }

        public static ulong[] productFib(ulong prod)
        {
            ulong current = 0;
            ulong x = 0;
            ulong fib1 = 0;
            ulong fib2 = 0;

            while (current < prod)
            {
                x++;
                fib1 = fib(x);
                fib2 = fib(x + 1);
                current = fib1 * fib2;
            }

            if (current == prod)
            {
                return new ulong[3] { (ulong)fib1, (ulong)fib2, 1 };
            }
            else
            {
                return new ulong[3] { (ulong)fib1, (ulong)fib2, 0 };
            }
        }

    }
}
