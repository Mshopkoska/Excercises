using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; 

namespace Excercises.Take_a_ten_min_walk
{
    class Kata
    {
        public static bool IsValidWalk(string[] walk)
        {
            //insert brilliant code here

            if (walk.Length != 10) return false;
            Dictionary<string, int> map = new Dictionary<string, int>();
            foreach (string c in walk)
            {
                if (!map.ContainsKey(c))
                {
                    map[c] = 1;
                }
                else
                {
                    int prevVal = map[c];
                    map[c] = prevVal + 1;
                }
            }
            /*if (map["n"] != map["s"] || map["w"] != map["e"])
                return false;*/



            if ((map.ContainsKey("n") && !map.ContainsKey("s")) || (map.ContainsKey("s") && !map.ContainsKey("n"))) return false; //ne moze da se vrati na start
            if ((map.ContainsKey("w") && !map.ContainsKey("e")) || (map.ContainsKey("e") && !map.ContainsKey("w"))) return false;

            if (map.ContainsKey("n") && map.ContainsKey("s") && map["n"] != map["s"])
            {
                return false;
            }


            if (map.ContainsKey("w") && map.ContainsKey("e") && map["w"] != map["e"])
            {
                return false;
            }
            return true;
        }

    }
    
}
