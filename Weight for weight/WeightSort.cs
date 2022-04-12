using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Text.RegularExpressions;


namespace Excercises.Weight_for_weight
{    public class WeightSort
    {

        public long orginalWeight { get; set; }
        public long scalledWeight { get; set; }

        class MyComparer : IComparer<WeightSort>
        {
            public int Compare(WeightSort x, WeightSort y)
            {
                if (x.scalledWeight == y.scalledWeight)
                {
                    string xx = x.orginalWeight.ToString();
                    string yy = y.orginalWeight.ToString();

                    return xx.CompareTo(yy);
                }

                else return x.scalledWeight.CompareTo(y.scalledWeight);
            }
        }
        public override string ToString()
        {
            return orginalWeight.ToString();
        }

        public static int sum(string num)
        {
            char[] digits = num.ToCharArray();
            int sum = 0;
            foreach (char c in digits)
            {
                sum += int.Parse(c.ToString()); ;
            }
            return sum;
        }

        public static string orderWeight(string strng)
        {
            if (strng.Count() == 0 || strng == "" || strng == null) return "";

            var rx = new Regex(@"\s+", RegexOptions.Compiled);
            string[] splitted = rx.Split(strng);

            List<WeightSort> weightList = new List<WeightSort>();
            foreach (string s in splitted)
            {
                long newWeight = sum(s);
                WeightSort w = new WeightSort();
                w.orginalWeight = long.Parse(s);
                w.scalledWeight = newWeight;

                weightList.Add(w);
            }

            weightList.Sort(new MyComparer());
            string[] result = new string[weightList.Count];
            int i = 0;
            foreach (WeightSort w in weightList)
            {
                result[i++] = w.ToString();
            }
            string finalResult = string.Join(" ", result);
            return finalResult;
        }
    }
}