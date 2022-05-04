using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.Build_Tower
{
    public class Kata
    {
        public static string[] TowerBuilder(int nFloors)
        {
            string[] r = new string[nFloors];
            int length = (nFloors - 1) * 2 + 1;
            for (int x = 0; x < nFloors; x++)
            {
                int dvezda = x * 2 + 1;
                int prazno = (length - dvezda) / 2;
                string l = "";
                for (int i = 0; i < prazno; i++) { l += " "; }
                for (int i = 0; i < dvezda; i++) { l += "*"; }
                for (int i = 0; i < prazno; i++) { l += " "; }
                r[x] = l;
            }
            return r;
        }
    }
}
