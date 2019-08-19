using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using static System.Console;

namespace Tcp_client02
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpClient tcpClient = new TcpClient("localhost", 4545);
            NetworkStream ns = tcpClient.GetStream();
            WriteLine("클라이언트");

            byte[] buffer = new byte[1024];
            byte[] sendmsg = Encoding.Unicode.GetBytes("안녕하세여ㅕㅕㅕㅕㅕㅕㅕㅕㅕ!!");
            ns.Write(sendmsg, 0, sendmsg.Length);
            int totalcount = 0, readcount = 0;

            while( totalcount < sendmsg.Length)
            {
                readcount = ns.Read(buffer, 0, buffer.Length);
                totalcount += readcount;

                string recvmsg = Encoding.Unicode.GetString(buffer);
                WriteLine(recvmsg);
            }

            WriteLine($"받은 문자열 바이트 수 : {totalcount}");
            ns.Close();
            tcpClient.Close();
        }
    }
}
