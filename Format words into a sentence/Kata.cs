using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.Format_words_into_a_sentence
{
    public static class Kata
    {
        public static string FormatWords(string[] words)
        {
            StringBuilder result = new StringBuilder();
            if (words == null)
                return "";

            
            
            List<string> list = new List<string>(words);
            list.RemoveAll(x=>x=="");
            list.RemoveAll(x => x == " ");
            list.RemoveAll(x => x == ",");
            

            int len = list.Count;

            for (int i = 0; i < len - 2; i++)
            {
                result.Append(list[i] + ", ");
            }
            

            if (len > 1)
            {
                if(len-result.Length == 2 && result.Length !=0)result.Length -= 2;

                result.Append(list[len - 2] + " and " + list[len - 1]);
            }
               
            else if (len == 1)
                result.Append(list[0]);

            return result.ToString();
        }
    }
}

