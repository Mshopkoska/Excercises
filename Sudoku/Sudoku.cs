using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.Sudoku
{
    internal class Sudoku
    {

        public static bool ValidateSolution(int[][] board)
        {
            List<int> temp = new List<int>();
            foreach (int[] row in board)
            {
                foreach (int i in Enumerable.Range(1, 9))
                {
                    if (!row.Contains(i))
                    {
                        return false;
                    }
                }
            }

            foreach (int column in Enumerable.Range(0, 9))
            {
                foreach (int[] row in board)
                {
                    temp.Add(row[column]);
                }
                foreach (int i in Enumerable.Range(1, 9))
                {
                    if (!temp.Contains(i))
                    {
                        return false;
                    }
                }
                temp.Clear();
            }
            int j = 0;

            while (j <= 2)
            {
                temp = new List<int>();
                foreach (int row in Enumerable.Range(3 * j, 3 * j + 3))
                {
                    foreach (int column in Enumerable.Range(3 * j, 3 * j + 3))
                    {
                        var smth = board[row][column];
                        temp.Add(smth);
                    }
                }
                foreach (int i in Enumerable.Range(1, 9))
                {
                    if (temp.Count(x => x == i) != 1)
                    {
                        return false;
                    }
                }
                j += 1;

            }
            return true;
        }

        public static void Main()
        {

            int[][] r = new int[][]
        {
            new int[] {5, 3, 4, 6, 7, 8, 9, 1, 2},
            new int[] {6, 7, 2, 1, 9, 5, 3, 4, 8},
            new int[] {1, 9, 8, 3, 4, 2, 5, 6, 7},
            new int[] {8, 5, 9, 7, 6, 1, 4, 2, 3},
            new int[] {4, 2, 6, 8, 5, 3, 7, 9, 1},
            new int[] {7, 1, 3, 9, 2, 4, 8, 5, 6},
            new int[] {9, 6, 1, 5, 3, 7, 2, 8, 4},
            new int[] {2, 8, 7, 4, 1, 9, 6, 3, 5},
            new int[] {3, 4, 5, 2, 8, 6, 1, 7, 9},
        };


            Boolean b = ValidateSolution(r);
            Console.WriteLine(b.ToString());
        }
     }
}
