using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
/*
namespace Excercises.Factorial_decomposition
{
    internal class FactDecomp
    {

        public static long calculateFactoriel(int n)
        {
            long result = 1;
            for(int i=n; i> 0; i--)
            {
                result *= i;
            }
            return result;
        }

        public static Hashtable countDivisors(long n, List<int> divisors)
        {
            Boolean flag = false;
            int i = 0;
            int count = 0;
            Hashtable ht = new Hashtable();
            long rest = n;
            
            while(rest != 1){
                int divisor = divisors[i];

                if(rest % divisor == 0)
                {
                    count++;
                    rest /= divisor;
                    flag = true;

                    if (rest == 1)
                    {
                        if (!ht.ContainsKey(divisor)) //ako vo tabelata ne postoi zapis za ovoj delitel
                        {
                            ht[divisor] = count; //go stavame
                            count = 0;
                            if (i == 0) i++;
                            else i = 0;

                        }
                        else
                        {
                            int prevCount = (int)ht[divisor];
                            ht[divisor] = prevCount + count;
                            if (i == 0) i++;
                            else i = 0;
                        }
                    }
                }
                else
                {
                    if (flag)
                    {
                        if (!ht.ContainsKey(divisor)) //ako vo tabelata ne postoi zapis za ovoj delitel
                        {
                            ht[divisor] = count; //go stavame
                            count = 0;
                            if (i == 0) i++;
                            else i = 0;
                           
                        }
                        else
                        {
                            int prevCount = (int)ht[divisor];
                            ht[divisor] = prevCount + count;
                            if (i == 0) i++;
                            else i = 0;
                        }
                        flag = false;
                    }
                    else i++;
                }

            }

            return ht;
        }
        public static string Decomp(int n)
        {
            long num = calculateFactoriel(n);
            List<int> primeFactors= new List<int>();

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
                        primeFactors.Add(i);
                        
                    }
                }
            }

            primeFactors.Sort();
            int counter = 0;

            StringBuilder st = new StringBuilder();
            Hashtable ht = countDivisors(num, primeFactors);

            foreach(int factor in primeFactors)
            {
                
                //"2^10 * 3^5 * 5^2 * 7 * 11"
                if((int)ht[factor] == 1)
                {
                    st.Append(factor);
                    st.Append(" * ");
                }
                else
                {
                    st.Append(factor + "^" + ht[factor]);
                    st.Append(" * ");
                }
                
            }
            st.Remove(st.Length - 2, 1);
            


            return st.ToString();


        }

        public static void Main()
        {

            //Console.WriteLine(calculateFactoriel(5));
            //string r = Decomp(12);
            //List<int> re = Decomp(12);
            Console.WriteLine(Decomp(12));


           // List<int> divs = new List<int> { 2, 3, 5, 7, 11 };
           // countDivisors(479001600, divs);
        }
    }
}

*/