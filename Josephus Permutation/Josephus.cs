using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.Josephus_Permutation
{
    public class Josephus
    {
        public static List<object> JosephusPermutation(List<object> items, int k)
        {

            List<object> result = new List<object>();
            int delNumber = k - 1;
            if (items.Count < k && items.Count != 0)
            {
                delNumber = delNumber % items.Count;
                foreach (int i in Enumerable.Range(1, items.Count))
                {
                    result.Add(items[delNumber]);
                    items.RemoveAt(delNumber);
                    if (items.Count > 0)
                    {
                        delNumber = (delNumber + k - 1) % items.Count;
                    }
                    else return result;
                }
            }
            else
            {
                foreach (int i in Enumerable.Range(1, items.Count))
                {
                    result.Add(items[delNumber]);
                    items.RemoveAt(delNumber);
                    if (items.Count > 0)
                    {
                        delNumber = (delNumber + k - 1) % items.Count;
                    }
                    else return result;
                }
                return result;
            }
            return result;
        }
    }
}