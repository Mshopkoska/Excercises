using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.Burrows_Wheeler_Transformation
{
    public class Kata
    {
        public static Tuple<string, int> Encode(string s)
        {
            if (s.Length == 0)
            { return new Tuple<string, int>("", 0); }
            var list = new List<string>() { s };
            var ss = s + s;
            for (int i = 1; i < s.Length; i++)
            {
                list.Add(ss.Substring(i, s.Length));
            }
            list.Sort(StringComparer.Ordinal);
            foreach (var item in list)
            {
                System.Console.WriteLine(item);
            }
            return new Tuple<string, int>(string.Join("", list.Select(w => w[s.Length - 1])), list.IndexOf(s));
        }

        public static string Decode(string s, int i)
        {
            if (s.Length == 0)
            { return ""; }
            var list = new List<string>();
            foreach (char c in s)
            {
                list.Add(c.ToString());
            }
            list.Sort(StringComparer.Ordinal);

            for (int x = 1; x < s.Length; x++)
            {
                for (int y = 0; y < s.Length; y++)
                {
                    list[y] = s[y] + list[y];
                }
                list.Sort(StringComparer.Ordinal);
            }

            return list[i];
        }
    }
}
