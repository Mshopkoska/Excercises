using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Excercises.Not_very_secure
{
    public class Kata
    {
        public static bool Alphanumeric(string str)
        {
            if (str == null || str == "" || str == " ") return false;
            Regex rg = new Regex(@"^[a-zA-Z0-9]*$");
            return rg.IsMatch(str);
        }
    }
}