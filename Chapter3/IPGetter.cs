using System;
using System.Net;


class IPGetter
{
    static void Main(string[] args)
    {
        IPHostEntry hostInfo = Dns.GetHostEntry("www.google.com");
        Console.WriteLine(hostInfo.AddressList[0]);
        Console.ReadLine();
    }
}

