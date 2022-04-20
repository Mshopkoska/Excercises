using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.John_and_Ann_sign_up_for_Codewars
{
    internal class Johnann
    {

        public static void JonnahAnnah(List<long> j, List<long> a, long n)
        {
            j.Add(0);
            a.Add(1);

            for (long i = 1; i < n; i++)
            {
                j.Add(i - a[(int)j[(int)i - 1]]);
                a.Add(i - j[(int)a[(int)i - 1]]);
            }
        }



        public static List<long> John(long n)
        {
            List<long> j = new List<long>();
            List<long> a = new List<long>();

            JonnahAnnah(j, a, n);

            return j;
        }


        public static List<long> Ann(long n)
        {
            List<long> j = new List<long>();
            List<long> a = new List<long>();

            JonnahAnnah(j, a, n);

            return a;
        }
        public static long SumJohn(long n)
        {
            List<long> j = new List<long>();
            List<long> a = new List<long>();
            j.Add(0);
            a.Add(1);

            long result = j[0];
            for (long i = 1; i < n; i++)
            {
                j.Add(i - a[(int)j[(int)i - 1]]);
                a.Add(i - j[(int)a[(int)i - 1]]);
                result += i - a[(int)j[(int)i - 1]];
            }
            return result;
        }
        public static long SumAnn(long n)
        {
            List<long> j = new List<long>();
            List<long> a = new List<long>();
            j.Add(0);
            a.Add(1);

            long result = a[0];
            for (long i = 1; i < n; i++)
            {
                j.Add(i - a[(int)j[(int)i - 1]]);
                a.Add(i - j[(int)a[(int)i - 1]]);
                result += i - j[(int)a[(int)i - 1]];
            }
            return result;
        }


        /*public static void Main()
        {
            List<long> john = John(6);
            List<long> ann = Ann(6);

            foreach(long i in john)
            {
                Console.Write(i + " ");
            }

            foreach (long i in ann)
            {
                Console.Write(i + " ");
            }

        }*/


    }
}
