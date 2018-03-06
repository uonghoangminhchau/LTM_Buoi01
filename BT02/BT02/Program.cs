using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace BT02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap ten mien hoac ip: ");
            string host = Console.ReadLine();

            IPHostEntry e = Dns.Resolve(host);
            Console.WriteLine("Hostname: {0}", e.HostName);

            // Danh sách điạ chỉ IP
            foreach (IPAddress i in e.AddressList)
                Console.WriteLine("\t+ IP: {0}", i);
        }
    }
}
