using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;
using static System.Console;

namespace streamrd01
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] buffer = new char[100];
            TcpClient tcpClient = new TcpClient("localhost", 3000);
            NetworkStream ns = tcpClient.GetStream();

            using( StreamReader sr = new StreamReader(ns))
            {
                string str = sr.ReadLine();
                WriteLine(str);
                str = sr.ReadLine();
                WriteLine(str);
                str = sr.ReadLine();
                WriteLine(str);
                str = sr.ReadLine();
                WriteLine(str);
            }
            ns.Close();
            tcpClient.Close();
        }
    }
}
