using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.GA_DE_RY_PO_LU_KI_cypher_vol_2
{
    public class Kata
    {
        public static string Encode(string str, string key)
        {
            string cyper = key + key.ToUpper();
            return string.Concat(str.Select(x => cyper.IndexOf(x) == -1 ? x :
                 ((cyper.IndexOf(x) % 2 == 1) ? cyper[cyper.IndexOf(x) - 1] : cyper[cyper.IndexOf(x) + 1])));
        }

        public static string Decode(string str, string key)
        {
            return Encode(str, key);
        }
    }
}
