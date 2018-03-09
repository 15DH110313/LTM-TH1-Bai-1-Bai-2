using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace BaiTH1
{
    class Program
    {
         [STAThread]
        static void Main(string[] args)
        {
            ////////////////BT1/////////////////
            // Lấy Hostname
            String strHostName = Dns.GetHostName();
            Console.WriteLine("Host Name: " + strHostName);

            // Tìm Hostname
            IPHostEntry iphostentry = Dns.GetHostByName(strHostName);

            // Xuất danh sách IP
            int nIP = 0;
            foreach (IPAddress ipaddress in iphostentry.AddressList)
            {
                Console.WriteLine("IP #" + ++nIP + ": " +ipaddress.ToString());
            }
            ////////////////BT2/////////////////
            // Nhập Hostname/IP cần phân giải
            Console.Write("Hostname/IP: ");
            string host = Console.ReadLine();

            IPHostEntry e = Dns.GetHostEntry(host);
            Console.WriteLine("Hostname: {0}", e.HostName);

            // Nếu là IP, tìm hostname
            foreach (string s in e.Aliases) Console.WriteLine("Alias: {0} \n", s);

            // Nếu là Hostname, phân giải tìm IP
            foreach (IPAddress i in e.AddressList) Console.WriteLine("IP: {0}", i);
        }
    }
}
