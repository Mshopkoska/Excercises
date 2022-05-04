using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.Counting_duplicates
{
    internal class CountingDuplicates
    {
        public static int frequency(char[] chars, char c) {
            int counter = 0;
            foreach (char c2 in chars)
            {
                if (c == c2) counter++;
            }
                return counter;
        }


        public static int DuplicateCount(string str)
        {
            char[] chars = str.ToCharArray();
            for (int i = 0;i<chars.Length;i++)
            {
                chars[i]=char.ToLower(chars[i]);    
            }

            String result = "";
            foreach (char c in chars)
            {
                char c2=char.ToLower(c);
                if (frequency(chars, c) > 1 && !result.Contains(c))
                {
                    result += c;
                }
            }
            return result.Length;
        }
    }
}
