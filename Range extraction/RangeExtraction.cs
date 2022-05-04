using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.Range_extraction
{
    public class RangeExtraction
    {
        public static string Extract(int[] args)
        {
            StringBuilder result = new StringBuilder();
            List<int> range = new List<int>();
            for (int i = 0; i < args.Length; i++)
            {
                if (i + 1 < args.Length && args[i + 1] - args[i] == 1)
                {
                    range.Add(args[i]);
                }
                else if (range.Count == 1)
                {
                    result.Append(range[0].ToString() + ',' + args[i].ToString() + ',');
                    range.Clear();
                }
                else if (range.Count > 0)
                {
                    result.Append(range[0].ToString() + '-' + args[i].ToString() + ',');
                    range.Clear();
                }
                else
                {
                    result.Append(args[i].ToString() + ',');
                }
            }
            return result.ToString().TrimEnd(',');
        }

        /*public static void Main()
        {
            int[] range = new[] { -6, -3, -2, -1, 0, 1, 3, 4, 5, 7, 8, 9, 10, 11, 14, 15, 17, 18, 19, 20 };

            string r = Extract(range);
        }*/
    }

    
}
