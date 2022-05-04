using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.Snail
{
    public class SnailSolution
    {
        public List<int> result = new List<int>();
        public int[][] arr { get; set; }

        public SnailSolution(int[][] arr)
        {
            this.arr = arr;
        }

        public static int[] Snail(int[][] array)
        {
            // enjoy
            if (array[0].Length == 0) return new int[0];
            if (array.Length == 1) return array[0];

            int len = array.Length;

            SnailSolution sl = new SnailSolution(array);
            sl.travel(0, len);

            return sl.result.ToArray();           
        }

        public void travel(int n, int len)
        {
            if(n <= len/2)
            {
                for (int r = n; r < len - n; r++) this.result.Add(arr[n][r]); // move right

                for (int d = n + 1; d < len - n; d++) this.result.Add(arr[d][len - 1 - n]); // move down

                for (int l = len - 2 - n; l >= n; l--) this.result.Add(arr[len - 1 - n][l]); // move left

                for (int u = len - 2 - n; u >= n + 1; u--) this.result.Add(arr[u][n]); // move up

                travel(n + 1, len);
            }
        }

       /* public static void Main()
        {
            int[][] array =
             {
           new []{1, 2, 3},
           new []{4, 5, 6},
           new []{7, 8, 9}
             };

            int[] r = Snail(array);
            for(int i =0; i<r.Length; i++)
            {
                Console.WriteLine(r[i]);    
            }
        }*/
    }
}
