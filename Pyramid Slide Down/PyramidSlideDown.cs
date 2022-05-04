using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.Pyramid_Slide_Down
{
    public class PyramidSlideDown
    {
        public static int LongestSlideDown(int[][] pyramid)
        {
            for (int i = 1; i < pyramid.Length; i++)
                for (int j = 0; j < pyramid[i].Length; j++)
                    if (j == 0) { pyramid[i][j] += pyramid[i - 1][j]; }
                    else if (j == pyramid[i].Length - 1) { pyramid[i][j] += pyramid[i - 1][j - 1]; }
                    else { pyramid[i][j] += Math.Max(pyramid[i - 1][j], pyramid[i - 1][j - 1]); }

            return pyramid[pyramid.Length - 1].Max();
        }
    }
}
