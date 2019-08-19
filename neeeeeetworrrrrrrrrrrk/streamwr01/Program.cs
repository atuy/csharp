using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using static System.Console;

namespace streamwr01
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener tcpListener = new TcpListener(3000);
            tcpListener.Start();
            TcpClient tcpClient = tcpListener.AcceptTcpClient();

            bool yesno = false;
            int val1 = 12;
            float pi = 3.14f;
            string msg = "hello world";

            NetworkStream ns = tcpClient.GetStream();

            using (StreamWriter sw = new StreamWriter(ns))
            {
                sw.AutoFlush = true;
                sw.WriteLine(yesno);
                sw.WriteLine(val1);
                sw.WriteLine(pi);
                sw.WriteLine(msg);
            }

            ns.Close();
            tcpClient.Close();
            tcpListener.Stop();
        }
    }
}
