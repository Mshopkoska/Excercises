using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
/*
namespace Excercises.Strings_Mix
{
    internal class Mix
    {
       
        public static Hashtable getData(String str)
        {
            Hashtable data = new Hashtable();

            List<char> chars = new List<char>();
            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i]; 
                if(char.IsLetter(c) && char.IsLower(c))
                {
                    if (!chars.Contains(c))
                    {
                        int count = str.Count(x => x == c);
                        chars.Add(c);
                        data[c] = count;
                    }
                }
               
            }

            return data;
        }
         public static void Main()
        {

            string str1 = "Are they here?";
            string str2 = "yes, they are here";

            Hashtable  table1=  getData(str1);
            Hashtable table2 = getData(str2);

            List<char> chars = new List<char>();

            StringBuilder st = new StringBuilder();

            Hashtable finalTable = new Hashtable();

            foreach (DictionaryEntry entry in table1)
            {
                if (!chars.Contains((char)entry.Key))
                {
                    //check for the entry in the second table
                    if (table2.ContainsKey(entry.Key))
                    {
                        //compare occurances
                        int occ1 = (int) entry.Value;
                        int occ2 = (int)table2[entry];

                        if(occ1> occ2)
                        {

                        }
                        else if (occ1 < occ2)
                        {

                        }
                        else
                        {

                        }
                    }
                }
            }


        }
    }
}
*/