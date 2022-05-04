using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Excercises.Strip_Comments
{
    public class StripCommentsSolution
    {

        public static string StripComments(string text, string[] commentSymbols)
        {
            string[] splitted = text.Split("\n");
            List<string> result = new List<string>();

            foreach(string item in splitted)
            {
                string s = "";
                foreach(char c in item)
                {
                    if (commentSymbols.Contains(c.ToString()))
                    {
                        break;
                    }
                    else
                    {
                        s = s + c;  
                    }
                }
                result.Add(s.TrimEnd());
            }
            return String.Join("\n", result.ToArray());
        }

        /*public static void Main()
        {
            string r = StripComments("a #b\nc\nd $e f g", new string[] { "#", "$" });
            Console.Write(r);
        }*/
    }
}