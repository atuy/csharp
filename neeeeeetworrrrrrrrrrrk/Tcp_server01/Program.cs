using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using static System.Console;

namespace Tcp_server01
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener tcpListener = new TcpListener(IPAddress.Parse("210.104.96.53"),4545);
            tcpListener.Start();
            WriteLine("대기상태");
            TcpClient tcpClient = tcpListener.AcceptTcpClient();
            NetworkStream ns = tcpClient.GetStream();
            byte[] receivmsg = new byte[100];
            ns.Read(receivmsg, 0, 100);
            string strmsg = Encoding.Unicode.GetString(receivmsg);
            WriteLine(strmsg);

            string echomsg = "서버접속";
            byte[] sendmsg = Encoding.Unicode.GetBytes(echomsg);

            ns.Write(sendmsg, 0, sendmsg.Length);
            ns.Close();
            tcpClient.Close();
            tcpListener.Stop();
        }
    }
}
