using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.Duplicate_Encoder
{
    public class Kata
    {
        public static int getFrequencty(string word, char c)
        {
            int counter = 0;
            foreach (char ch in word)
            {
                if (char.ToLower(ch) == char.ToLower(c)) counter++;
            }
            return counter;
        }
        public static string DuplicateEncode(string word)
        {
            char[] arr = word.ToLower().ToCharArray();
            List<char> list = new List<char>();

            foreach(char ch in arr)
            {
                if(getFrequencty(word, ch) > 1)
                {
                    list.Add(')');
                }
                else list.Add('(');
            }

            return String.Join("",list);
        }
    }
}
