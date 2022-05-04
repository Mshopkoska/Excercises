using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.Title_Case
{
    public class Kata
    {
        public static string TitleCase(string title, string minorWords = "")
        {
            string[] titleArr = title.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] minorWordsArr = new string[] { };
            if (minorWords != null)
                minorWordsArr = minorWords.ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < titleArr.Length; i++)
            {
                if (i == 0 || !minorWordsArr.Any(e => e == titleArr[i].ToLower()))
                    sb.Append(toTitleCase(titleArr[i]) + ' ');
                else
                    sb.Append((titleArr[i].ToLower()) + ' ');

            }
            return sb.ToString().TrimEnd(' ');
        }

        private static string toTitleCase(string v)
        {
            return v.Substring(0, 1).ToUpper() + v.Substring(1, v.Length - 1).ToLower();
        }
    }
}
