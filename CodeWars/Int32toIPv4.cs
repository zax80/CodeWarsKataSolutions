using System;
using System.Net;

namespace CodeWars
{
    public static class Int32toIPv4
    {
        public static string UInt32ToIP(uint ip)
        {
            return IPAddress.Parse(ip.ToString()).ToString();
        }
    }
}
