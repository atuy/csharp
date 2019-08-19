using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using static System.Console;

namespace Tcp_server02
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener tcpListener = new TcpListener(IPAddress.Any, 4545);
            tcpListener.Start();

            byte[] buffer = new byte[1024];
            int TotalConut = 0, readCount = 0;
            WriteLine("서버");

            TcpClient tcpClient = tcpListener.AcceptTcpClient();
            NetworkStream ns = tcpClient.GetStream();

            while(true)
            {
                readCount = ns.Read(buffer, 0, buffer.Length);
                if(readCount == 0)
                {
                    break;
                }

                TotalConut += readCount;
                ns.Write(buffer, 0, readCount);
                WriteLine(Encoding.Unicode.GetString(buffer));
            }

            ns.Close();
            tcpClient.Close();
            tcpListener.Stop();

        }
    }
}
