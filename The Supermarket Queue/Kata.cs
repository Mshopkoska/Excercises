using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.The_Supermarket_Queue
{
    public class Kata
    {
        public static long QueueTime(int[] customers, int n)
        {
            if (n == 1)
                return customers.Sum();

            int[] naNaplata = new int[n];
            Queue<int> customersQ = new Queue<int>(customers);
            bool queueHasItems = true;
            int time = 0; int minTime;
            while (queueHasItems)
            {
                minTime = int.MaxValue;

                for (int i = 0; i < n; i++)
                {
                    if (naNaplata[i] == 0)
                        queueHasItems = customersQ.TryDequeue(out naNaplata[i]);
                    // zemi min val ama ne  0
                    if (naNaplata[i] != 0)
                        minTime = (naNaplata[i] < minTime ? naNaplata[i] : minTime);
                }
                time += minTime;

                // namali go vremeto na customers za najbrzoto vreme 
                for (int i = 0; i < n; i++)
                    naNaplata[i] -= minTime;
            }

            time += naNaplata.Max();
            return time;
        }
    }
}
