using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.Write_out_numbers
{
    public class NumberTranslation
    {
        public static string format(string str)
        {
            List<string> s = new List<string>(str.Split(" "));
            s.RemoveAll(x => x.Equals(""));
            List<string> items = new List<string>();
            if (s[s.Count - 1] == " ")
            {
                items = s.GetRange(s.Count - 1, 1);
                s.RemoveRange(s.Count - 1, 1);
                return string.Join("", items);

            }

            return string.Join(" ", s);
        }
        public static string getOnes(int n)
        {
            if (n == 1) { return "one"; }
            if (n == 2) { return "two"; }
            if (n == 3) { return "three"; }
            if (n == 4) { return "four"; }
            if (n == 5) { return "five"; }
            if (n == 6) { return "six"; }
            if (n == 7) { return "seven"; }
            if (n == 8) { return "eight"; }
            if (n == 9) { return "nine"; }
            if (n == 10) { return "ten"; }
            if (n == 11) { return "eleven"; }
            if (n == 12) { return "twelve"; }
            if (n == 13) { return "thirteen"; }
            if (n == 14) { return "fourteen"; }
            if (n == 15) { return "fifteen"; }
            if (n == 16) { return "sixteen"; }
            if (n == 17) { return "seventeen"; }
            if (n == 18) { return "eighteen"; }
            if (n == 19) { return "nineteen"; }

            return "";
        }

        public static string getTens(int n)
        {
            if (n == 20) { return "twenty"; }
            if (n == 30) { return "thirty"; }
            if (n == 40) { return "forty"; }
            if (n == 50) { return "fifty"; }
            if (n == 60) { return "sixty"; }
            if (n == 70) { return "seventy"; }
            if (n == 80) { return "eighty"; }
            if (n == 90) { return "ninety"; }
            return "";
        }

        public static string getHundreds(int n)
        {
            return string.Format("{0} hundred", getOnes(n)).Trim();
        }


        public static string getThousands(int n)
        {
            if (n <= 19)
            {
                return string.Format("{0} thousand", getOnes(n)).Trim();
            }
            if (n <= 99)
            {
                int tens = (int)Math.Floor(n / (decimal)10) * 10;
                var on = n % 10;
                string ones = on.ToString();
                string connector = " ";

                if (on > 0)
                {
                    connector = "-";
                }
                else
                {
                    ones = "";
                }
                return string.Format("{0}{1}{2} thousand", getTens(tens), connector, getOnes(on)).Trim();
            }
            return "";
        }

        public static string Number2Words(int n)
        {
            string hundredThousand = "";
            string thousand = "";
            string hundred = "";
            string tens = "";
            string ones = "";
            

            if (n == 0)
            {
                return "zero";
            }

            if (n > 99999)
            {
                hundredThousand = String.Format("{0} hundred", getOnes((int)Math.Floor(n / (decimal)100000))).Trim();
                n = n - (int)(Math.Floor(n / (decimal)100000) * 100000);
            }

            if (n > 999)
            {
                thousand = String.Format("{0}", getThousands((int)Math.Floor(n / (decimal)1000))).Trim();
                n = n - (int)(Math.Floor(n / (decimal)1000) * 1000);
            }

            if (n > 99)
            {
                hundred = String.Format("{0} hundred", getOnes((int)Math.Floor(n / (decimal)100))).Trim();
                n = n - (int)(Math.Floor(n / (decimal)100) * 100);
            }

            if (n > 19)
            {
                tens = String.Format("{0}", getTens((int)Math.Floor(n / (decimal)10) * 10)).Trim();
                n = n - (int)(Math.Floor(n / (decimal)10) * 10);
            }
            if (n > 0)
            {
                ones = getOnes(n).Trim();
            }
            if (tens != "" && ones != "")
            {
                tens += '-';
            }
            string result = format(hundredThousand + " " + thousand + " " + hundred + " " + tens + ones);
            return result.Trim();
        }

    }
}

