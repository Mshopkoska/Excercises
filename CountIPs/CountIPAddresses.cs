using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
public class CountIPAddresses
{
    public static long IpsBetween(string start, string end)
    {
        long[] b = start.Split('.').Select(long.Parse).ToArray();
        long[] a = end.Split('.').Select(long.Parse).ToArray();

        long x = (((a[0] - b[0]) * 256 + a[1] - b[1]) * 256 + a[2] - b[2]) * 256 + a[3] - b[3];
        return (long)x;
    }
}