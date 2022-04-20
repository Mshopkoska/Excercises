using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Net;


namespace Excercises.int32_to_IPv4
{
    internal class Kata
    {
        public static string UInt32ToIP(uint ip)
        {
            return IPAddress.Parse(ip.ToString()).ToString();
        }

    }
}
