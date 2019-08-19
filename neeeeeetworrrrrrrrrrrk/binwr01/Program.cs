using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.IO;
using static System.Console;

namespace binwr01
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener tcpListener = new TcpListener(IPAddress.Any, 3000);
            tcpListener.Start();

            TcpClient tcpClient = tcpListener.AcceptTcpClient();
            NetworkStream ns = tcpClient.GetStream();

            using ( BinaryWriter bw = new BinaryWriter(ns))
            {
                bool yesno = false;
                int val1 = 12;
                float pi = 3.14f;
                string msg = "hello world";

                bw.Write(yesno);
                bw.Write(val1);
                bw.Write(pi);
                bw.Write(msg);
            }

            ns.Close();
            tcpClient.Close();
            tcpListener.Stop();
        }
    }
}
