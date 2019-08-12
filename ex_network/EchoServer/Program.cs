using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using static System.Console;
namespace EchoServer
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                WriteLine("사용법 : {0} <Bind IP>", Process.GetCurrentProcess().ProcessName);
                return;
            }

            string bindIp = args[0];
            const int bindPort = 5425;
            TcpListener server = null;

            try
            {
                IPEndPoint localAddress = new IPEndPoint(IPAddress.Parse(bindIp), bindPort);

                server = new TcpListener(localAddress);
                server.Start();

                WriteLine("서버 스타트");

                while(true)
                {
                    TcpClient client = server.AcceptTcpClient();
                    WriteLine("클라이언트 접속 {0}", ((IPEndPoint)client.Client.RemoteEndPoint).ToString());

                    NetworkStream stream = client.GetStream();

                    int length;
                    string date = null;
                    byte[] bytrs = new byte[256];
                    
                    while((length = stream.Read(bytrs,0,bytrs.Length)) !=0 )
                    {
                        date = Encoding.Default.GetString(bytrs, 0, length);
                        WriteLine(String.Format("수신 : {0}", date));

                        byte[] msg = Encoding.Default.GetBytes(date);

                        stream.Write(msg, 0, msg.Length);
                        WriteLine(String.Format("송신 : {0}", date));
                    }
                    stream.Close();
                    client.Close();
                }
            }

            catch (SocketException e)
            {
                WriteLine(e);
            }

            finally
            {
                server.Stop();
            }

            WriteLine("서버를 종료합니다");
        }
    }
}
