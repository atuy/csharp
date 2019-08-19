using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.IO;
using static System.Console;

namespace binrd01
{
    class Program
    {
        static void Main(string[] args)
        {
            bool yesno ;
            int val1;
            float pif;
            string msg;

            TcpClient tcpClient = new TcpClient("localhost", 3000);
            NetworkStream ns = tcpClient.GetStream();

            using (BinaryReader br = new BinaryReader(ns))
            {
                yesno = br.ReadBoolean();
                val1 = br.ReadInt32();
                pif = br.ReadSingle();
                msg = br.ReadString();

            }
            ns.Close();
            tcpClient.Close();

            WriteLine(yesno);
            WriteLine(val1);
            WriteLine(pif);
            WriteLine(msg);

        }
    }
}
