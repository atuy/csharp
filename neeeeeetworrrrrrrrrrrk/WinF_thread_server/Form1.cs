using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace WinF_thread_server
{
    public partial class Form1 : Form
    {
        private TcpListener tcpListener = null;

        private void AcceptClient()
        {
            while(true)
            {
                TcpClient tcpClient = tcpListener.AcceptTcpClient();

                if(tcpClient.Connected)
                {
                    string str = ((IPEndPoint)tcpClient.Client.RemoteEndPoint).Address.ToString();
                    listBox1.Items.Add(str);
                }

                EchoServer echoserver = new EchoServer(tcpClient);
                Thread th = new Thread(new ThreadStart(echoserver.Process));
                th.IsBackground = true;
                th.Start();
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tcpListener = new TcpListener(3000);
            tcpListener.Start();
            IPHostEntry iPHost = Dns.GetHostEntry(Dns.GetHostName());
            for (int i = 0; i < iPHost.AddressList.Length; i++)
            {
                if (iPHost.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
                {
                    textBox1.Text = iPHost.AddressList[i].ToString();
                    break;
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(new ThreadStart(AcceptClient));
            th.IsBackground = true;
            th.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(tcpListener != null)
            {
                tcpListener.Stop();
                tcpListener = null;
            }
        }
    }
    class EchoServer
    {
        TcpClient refClient;
        private BinaryReader br = null;
        private BinaryWriter bw = null;

        int intvalue;
        float floatvalue;
        string strvalue;

        public EchoServer(TcpClient client)
        {
            refClient = client;
        }

        public void Process()
        {
            NetworkStream ns = refClient.GetStream();

            try
            {
                br = new BinaryReader(ns);
                bw = new BinaryWriter(ns);

                while(true)
                {
                    intvalue = br.ReadInt32();                    
                    floatvalue = br.ReadSingle();
                    strvalue = br.ReadString();

                    bw.Write(intvalue);
                    bw.Write(floatvalue);
                    bw.Write(strvalue);
                }
            }
            catch (SocketException se)
            {
                br.Close();
                bw.Close();
                ns.Close();
                ns = null;
                refClient.Close();
                MessageBox.Show(se.Message);
                Thread.CurrentThread.Abort();
            }
            catch (IOException ex)
            {
                //읽을수 없을 때 처리
                br.Close();
                bw.Close();
                ns.Close();
                ns = null;
                refClient.Close();              
                Thread.CurrentThread.Abort();
            }
        }
    }
}
