using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Excercises.Greed_is_good
{
    public static class Kata
    {
        public static Hashtable diceCounter(int[] dice)
        {
            Hashtable ht = new Hashtable();
            foreach (int i in dice)
            {
                if (!ht.ContainsKey(i))
                {
                    ht[i] = 1;
                }
                else
                {
                    ht[i] = (int)ht[i] + 1;
                }
            }
            return ht;
        }
        public static int Score(int[] dice)
        {
            // Fill me in!
            Hashtable counter = diceCounter(dice);
            var points = new Dictionary<int, int>
            {
                {1, 1000}, {6, 600}, {5, 500}, {4, 400}, {3, 300},{2, 200}
            };

            int total = 0;
            foreach (DictionaryEntry entry in counter)
            {
                int v = (int)entry.Value;
                int k = (int)entry.Key;
                if (v >= 3)
                {
                    total += points[k] * (v / 3);
                }
                if (k == 1)
                {
                    total += 100 * (v % 3);
                }
                else if (k == 5)
                {
                    total += 50 * (v % 3);
                }
            }
            return total;
        }
    }
}