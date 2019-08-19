using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using static System.Console;

namespace IPAddress01
{
    class Program
    {
        static void Main(string[] args)
        {
            string Address = ReadLine();
            IPAddress IP = IPAddress.Parse(Address);
            WriteLine($"IP : {IP}");

            /*
             * IP의 형태로 입력받아 출력하는 코드
             */
            WriteLine();
            WriteLine();
            WriteLine();

            IPAddress[] IP_1 = Dns.GetHostAddresses("www.naver.com");
            foreach (IPAddress host in IP_1)
            {
                WriteLine($"{host}");
            }

            /*
             * DNS의 주소를 받아오는 코드
             */
            WriteLine();
            WriteLine();
            WriteLine();


            IPHostEntry iPHost = Dns.GetHostEntry("www.naver.com");
            foreach (IPAddress ip in iPHost.AddressList)
                WriteLine($"{ip}");

            WriteLine($"{iPHost.HostName}");


            WriteLine();
            WriteLine();
            WriteLine();

            IPAddress iPAddress = IPAddress.Parse("127.0.0.1");
            int port = 5454;
            IPEndPoint iPEnd = new IPEndPoint(iPAddress, port);
            WriteLine($"IP : {iPEnd.Address}, Port : {iPEnd.Port}");
            WriteLine(iPEnd.ToString());
            ReadKey();
        }
    }
}
