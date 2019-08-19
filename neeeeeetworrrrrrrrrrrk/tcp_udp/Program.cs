using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using static System.Console;

namespace tcp_udp
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            TcpListener tcpListener = new TcpListener(ip, 5454);
            WriteLine($"{tcpListener.LocalEndpoint.ToString()}");


            tcpListener = new TcpListener(ip, 4545);
            tcpListener.Start();
            WriteLine("대기 시작");
            TcpClient tcpClient = tcpListener.AcceptTcpClient();
            WriteLine("대기상태 종료");
            tcpListener.Stop();
        }
    }
}
