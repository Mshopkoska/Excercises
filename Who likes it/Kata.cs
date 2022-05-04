using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.Who_likes_it
{
    public static class Kata
    {
        public static string Likes(string[] name)
        {
            String result = "";
            if (name.Length == 0)
                result = "no one likes this";
            else if (name.Length == 1)
                result = name[0] + " likes this";
            else if (name.Length == 2)
                result = name[0] + " and " + name[1] + " like this";
            else if (name.Length == 3)
                result = name[0] + ", " + name[1] + " and " + name[2] + " like this";
            else
                result = name[0] + ", " + name[1] + " and " + (name.Length - 2) + " others like this";
            return result;
        }
    }
}
