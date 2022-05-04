using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; 

namespace Excercises.Sum_by_Factors
{
	public class SumOfDivided
	{
        private static List<int> primeFactors(int number)
        {       
            int i = 2;
            List<int> factors = new List<int>();
            if (number < 0)
            {
                number *= -1;
            }
            while (i * i <= number)
            {
                if(!(number % i == 0)) i += 1;

                else
                {
                    number /= i;
                    factors.Add(i);
                }
            }
            if (number > 1)
            {
                factors.Add(number);    
            }
            return factors;

        }

        public static List<int> combine(List<int> arr, List<int> arr2)
        {

            foreach(int a in arr)
            {
                if (!arr2.Contains(a))
                {
                    arr2.Add(a);
                }
            }
            return arr2;
        }


        public static string sumOfDivided(int[] lst)
		{
            List<int> factors = new List<int>();
            Hashtable sums = new Hashtable();
           
            foreach(int i in lst)
            {
                combine(primeFactors(i), factors); //moze treba da se sejvne nekade ili void da bide
            }
            foreach (int i in factors)
            {
                int sum = 0;
                foreach(int j in lst)
                {
                    if (!(!(j % i == 0)))
                    {
                        sum += j;
                    }
                }
                sums.Add(i, sum);
            }

            ArrayList al = new ArrayList(sums.Keys);
            al.Sort();


            StringBuilder st = new StringBuilder();
            foreach (int i in al)
            {
                st.Append("(" + i + " " + sums[i] + ")");
            }


            return st.ToString();
        }
    }
}
