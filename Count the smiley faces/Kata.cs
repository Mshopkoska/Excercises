using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.Count_the_smiley_faces
{
    public static class Kata
    {
        public static int CountSmileys(string[] s)
        {
            int result = 0;
            for (int x = 0; x < s.Length; x++)
            {
                int face = 0;
                if (s[x].Contains(":") || s[x].Contains(";")) { face++; }
                if (s[x].Contains(")") || s[x].Contains("D")) { face++; }
                if (s[x].Contains(" ")) { face--; }
                if (face == 2) { result++; }
            }
            return result;
        }
    }
}
