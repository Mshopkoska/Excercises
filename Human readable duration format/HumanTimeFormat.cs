using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.Human_readable_duration_format
{
    public class HumanTimeFormat
    {
        public static string formatDuration(int seconds)
        {
            string s = "";
            int sec = seconds;
            int[] divArr = { 60 * 60 * 24 * 365, 60 * 60 * 24, 60 * 60, 60, 1 };
            string[] nameArr = { "year", "day", "hour", "minute", "second" };

            if (seconds == 0)
            {
                s = "now";
            }

            for (int i = 0; i < divArr.Length; i++)
            {
                int k = sec / divArr[i];
                sec = sec % divArr[i];
                if (k != 0)
                {
                    string pref = "";
                    if (s != "")
                    {
                        if (sec == 0)
                        {
                            pref = " and ";
                        }
                        else
                        {
                            pref = ", ";
                        }
                    }
                    s = s + pref + k.ToString() + " " + nameArr[i];
                    s += k > 1 ? "s" : "";
                }
            }
            return s;
        }
    }
}
