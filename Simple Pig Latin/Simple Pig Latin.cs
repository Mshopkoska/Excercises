using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.Simple_Pig_Latin
{
    public class Kata
    {
        public static string PigIt(string str)
        {
            string[] splitted = str.Split(' ');

            for (int i = 0; i < splitted.Length; i++)
            {
                string s = splitted[i];
                //pig -> ig pay
                char firstLetter = s[0];
                StringBuilder st = new StringBuilder();
                if (char.IsLetter(s[s.Length - 1]))
                {
                    st.Append(s.Substring(1) + firstLetter + "ay");
                    splitted[i] = st.ToString();
                }
            }

            return string.Join(" ", splitted);
        }
    }
}
