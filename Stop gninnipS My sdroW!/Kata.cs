using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.Stop_gninnipS_My_sdroW_
{
    public class Kata
    {

        public static string getReversedWord(string word)
        {
            char[] charArr = word.ToCharArray();
            Array.Reverse(charArr); 
            return string.Join("", charArr);
        }
        public static string SpinWords(string sentence)
        {
            
            string[] words = sentence.Split(' ');

            List<String> result = new List<String>();
            foreach(string word in words)
            {
                if (word.Count() >= 5)
                {
                    result.Add(getReversedWord(word));
                }
                else result.Add(word);
            }

            return String.Join(" ", result.ToArray());
        }
    }
}
