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
            
            foreach (int i in Enumerable.Range(0, 9))
            {
                var set = new HashSet<int>(board[i]); //horizontalno.
                if (set.Count < 9) return false;
            }

            foreach (int i in Enumerable.Range(0, 9))
            {
                List<int> col = new List<int>();
                foreach (int j in Enumerable.Range(0, 9))
                {
                    col.Add(board[j][i]);
                }
                var set = new HashSet<int>(col); //vertikalno.
                if (set.Count < 9) return false;
            }

            //check subboards
            //first one
            var set2 = new HashSet<int>();
            for (int i=0;i<3; i++)
            {
                for(int j = 0; j< 3; j++)
                {
                    set2.Add(board[i][j]);   
                }
            }
            if (set2.Count < 9) return false;

            //second
            for (int i = 0; i < 3; i++)
            {
                for (int j = 3; j < 6; j++)
                {
                    set2.Add(board[i][j]);
                }
            }
            if (set2.Count < 9) return false;


            //third
            for (int i = 0; i < 3; i++)
            {
                for (int j = 6; j < 9; j++)
                {
                    set2.Add(board[i][j]);
                }
            }
            if (set2.Count < 9) return false;



            //fourth
            for (int i = 3; i < 6; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    set2.Add(board[i][j]);
                }
            }
            if (set2.Count < 9) return false;

            //fifth
            for (int i = 3; i < 6; i++)
            {
                for (int j = 3; j < 6; j++)
                {
                    set2.Add(board[i][j]);
                }
            }
            if (set2.Count < 9) return false;



            //sixth
            for (int i = 3; i < 6; i++)
            {
                for (int j = 6; j < 9; j++)
                {
                    set2.Add(board[i][j]);
                }
            }
            if (set2.Count < 9) return false;

            //seventh
            for (int i = 6; i < 9; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    set2.Add(board[i][j]);
                }
            }
            if (set2.Count < 9) return false;

            //eight
            for (int i = 6; i < 9; i++)
            {
                for (int j = 3; j < 6; j++)
                {
                    set2.Add(board[i][j]);
                }
            }
            if (set2.Count < 9) return false;

            //eighth
            for (int i = 6; i < 9; i++)
            {
                for (int j = 6; j < 9; j++)
                {
                    set2.Add(board[i][j]);
                }
            }
            if (set2.Count < 9) return false;
            return true;
        }
     }
}
