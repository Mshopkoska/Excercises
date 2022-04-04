using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
/*
namespace Excercises.Weight_for_weight
{
    internal class WeightSort
    {
        public static int sum(string num)
        {
            char[] digits = num.ToCharArray(); 
            int sum = 0;   
            foreach(char c in digits)
            {
                sum+= int.Parse(c.ToString()); ;  
            }
            return sum;
        }

        public static void Main()
        {
            string strng = "11 11 2000 10003 22 123 1234000 44444444 9999";
            string[] splitted  = strng.Split(' ');

            Hashtable ht = new Hashtable();  //key ke bide vistinskata tezhina, value e novata 
            foreach(string s in splitted)
            {
                int newWeight = sum(s);
                ht[s] = newWeight;
            }

            string[] arrKey = new string[ht.Count];
            int[] arrValue = new int[ht.Count];
            ht.Keys.CopyTo(arrKey, 0);
            ht.Values.CopyTo(arrValue, 0);

            Array.Sort(arrValue, arrKey);
            string[] arrKey2 = arrKey;

            string result = string.Join(" ", arrKey2);

        }
    }
}
*/