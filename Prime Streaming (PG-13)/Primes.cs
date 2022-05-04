using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.Prime_Streaming__PG_13_
{
    public class Primes
    {
        static Primes()
        {
            Dictionary<int, bool> numbers = new Dictionary<int, bool>();

            int n = 20000000;

            foreach (var num in Enumerable.Range(2, n))
            {
                numbers.Add(num, true);
            }

            // naogjanje na prime numbers, ako ne e prime, vo dictionary kako value ke staime false
            for (int p = 2; p * p <= n; p++)
            {
                if (numbers[p])
                {
                    for (int i = p * p; i <= n; i += p)
                    {
                        numbers[i] = false;
                    }
                }
            }

            PrimeNums = new List<int>(numbers.Where(e => e.Value == true).Select(e => e.Key));
        }
        public static List<int> PrimeNums { get; set; }
        public static IEnumerable<int> Stream()
        {
            return PrimeNums;
        }

        /*public static void Main()
        {

            IEnumerable<int> pr = Primes.Stream();
            Console.WriteLine(string.Join("\n", Primes.Stream().Take(10)));
        }*/
    }
}
