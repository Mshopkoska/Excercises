using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.Your_order_please
{

    public static class Kata
    {
        public static string Order(string sentence)
        {
            if (sentence.Equals(""))
                return "";

            String[] words = sentence.Split(" ");

            String[] result = new string[words.Length];
            foreach(string word in words)
            {
                int digit = int.Parse(new String(word.Where(Char.IsDigit).ToArray()));

                
                result[digit - 1] = word;
            }
            return String.Join(" ", result);
        }
    }
}
