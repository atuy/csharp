using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using static System.Console;

namespace Tcp_client01
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpClient tcpClient = new TcpClient("210.104.96.53", 4545);
            if (tcpClient.Connected)
            {
                WriteLine("연결 성공");
                NetworkStream ns = tcpClient.GetStream();
                string msg = ReadLine();
                byte[] sendmsg = Encoding.Unicode.GetBytes(msg);
                ns.Write(sendmsg, 0, sendmsg.Length);

                byte[] receivmsg = new byte[100];
                ns.Read(receivmsg, 0, 100);
                string receive = Encoding.Unicode.GetString(receivmsg);
                WriteLine(receive);
                ns.Close();
            }
                
            else
                WriteLine("연결 실패");

            tcpClient.Close();
        }
    }
}
