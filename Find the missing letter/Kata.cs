using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.Find_the_missing_letter
{
    public class Kata
    {
        public static char FindMissingLetter(char[] array)
        {
            string abc = "abcdefghijklmnopqrstuvwxyz";
            abc = abc + abc.ToUpper();
            int i0 = abc.IndexOf(array[0]);
            for (int i = 0; i < array.Length; i++)
            {
                if (abc[i0 + i] != array[i])
                    return (char)((int)array[i] - 1);
            }
            return ' ';
        }
    }
}
