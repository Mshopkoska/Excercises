using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.Convert_string_to_camel_case
{
    internal class Kata
    {
        public static string ToCamelCase(string str)
        {
            if (str.Count() == 0) return "";
            string[] splitted = str.Split(new char[] { '-', '_' });

            List<string> list = new List<string>(splitted);
            if (char.IsUpper(list[0][0]))
            {
                string word = list[0];
                char[] toCharArr = word.ToCharArray();
                toCharArr[0] = char.ToUpper(toCharArr[0]);
                word = String.Join("", toCharArr);
                list[0] = word;
            }

            for (int i = 1; i < list.Count; i++)
            {
                string word = list[i];
                char[] toCharArr = word.ToCharArray();
                toCharArr[0] = char.ToUpper(toCharArr[0]);
                word = String.Join("", toCharArr);
                list[i] = word;
            }
            return String.Join("", list);
        }

        /*public static void Main()
        {
            Console.WriteLine(ToCamelCase("The_stealth_warrior-l"));
        }*/
    }
}
