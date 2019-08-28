using System;
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
        string clientIP;
        string str;
        string time = null;
        string msg = null;
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
            MessageBox.Show("서버 시작");
        }
        private void TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Button1_Click(sender, e);
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tcpListener != null)
            {
                tcpListener.Stop();
                tcpListener = null;
            }
        }
        private void AcceptClient()
        {
            while (true)
            {
                TcpClient tcpClient = tcpListener.AcceptTcpClient();

                if (tcpClient.Connected)
                {
                    clientIP = ((IPEndPoint)tcpClient.Client.RemoteEndPoint).Address.ToString();
                    listBox1.Items.Add(clientIP);
                }

                //EchoServer echoserver = new EchoServer(tcpClient);
                Thread th = new Thread(() => Proc(tcpClient));
                th.IsBackground = true;
                th.Start();
                MessageBox.Show("클라이언트 접속");
                
            }
        }   
        
        
        void Proc(TcpClient client)
        {
            TcpClient refClient = client;
            BinaryReader br = null;
            BinaryWriter bw = null;
            NetworkStream ns = refClient.GetStream();
            
            try
            {
                br = new BinaryReader(ns);
                bw = new BinaryWriter(ns);
                while (true)
                {
                    str = br.ReadString();
                    time = DateTime.Now.ToShortTimeString();
                    str = str.TrimEnd();
                    msg = "[" + time + "] : " + str + "\r\n";
                    bw.Write(msg);
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
                listBox1.Items.Remove(clientIP);
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
                listBox1.Items.Remove(clientIP);
                Thread.CurrentThread.Abort();
            }
        }
    }
    //public class EchoServer
    //{
    //    TcpClient refClient;
    //    private BinaryReader br = null;
    //    private BinaryWriter bw = null;
    //    string Ipaddress;
    //    string str;
    //    private bool check = false;
    //    public EchoServer(TcpClient client)
    //    {
    //        refClient = client;
    //        Ipaddress = ((IPEndPoint)refClient.Client.RemoteEndPoint).Address.ToString();
    //    }
        
    //    public void Process()
    //    {
    //        NetworkStream ns = refClient.GetStream();

    //        try
    //        {
    //            br = new BinaryReader(ns);
    //            bw = new BinaryWriter(ns);
    //            while (true)
    //            {
    //                str = br.ReadString();
    //                bw.Write(str);
    //            }
    //        }
    //        catch (SocketException se)
    //        {
    //            br.Close();
    //            bw.Close();
    //            ns.Close();
    //            ns = null;
    //            refClient.Close();                
    //            MessageBox.Show(se.Message);
              
    //            Thread.CurrentThread.Abort();
    //        }
    //        catch (IOException ex)
    //        {
    //            //읽을수 없을 때 처리
    //            br.Close();
    //            bw.Close();
    //            ns.Close();
    //            ns = null;
    //            refClient.Close();
                
    //            Thread.CurrentThread.Abort();
    //        }
    //    }
    //}
}
