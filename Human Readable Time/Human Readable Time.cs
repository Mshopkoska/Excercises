using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises.Human_Readable_Time
{
    internal class Human_Readable_Time
    {
        public static class TimeFormat
        {
            public static string GetReadableTime(int seconds)
            {
                TimeSpan time = TimeSpan.FromSeconds(seconds);
                if (seconds == 86400) return "24:00:00";
                if (time.TotalHours > 24)
                {
                    return (int)time.TotalHours + time.ToString(@"\:mm\:ss");
                }
                else return time.ToString(@"hh\:mm\:ss");

            }
        }
    }
}
