using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;

namespace Charpter3
{
    class IPGetter
    {
        static void Main(string[] args)
        {
            IPHostEntry hostInfo = Dns.GetHostEntry("www.google.com");
            Console.WriteLine(hostInfo.AddressList[0]);
            Console.ReadLine();
        }
    }
}
