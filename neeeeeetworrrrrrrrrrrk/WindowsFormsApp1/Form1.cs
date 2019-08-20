using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.IO;
using static System.Console;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        private TcpListener tcpListener = null;
        private TcpClient tcpClient = null;
        private NetworkStream ns = null;
        private BinaryWriter bw = null;
        private BinaryReader br = null;

        int intvalue;
        float floatvalue;
        string strvalue;

        private int DataReceive()
        {
            intvalue = br.ReadInt32();
            if( intvalue == -1)
            {
                return -1;
            }
            floatvalue = br.ReadSingle();
            strvalue = br.ReadString();
            string str = intvalue + "/" + floatvalue + "/" + strvalue;
            MessageBox.Show(str);
            return 0;
        }
        private void DataSend()
        {
            bw.Write(intvalue);
            bw.Write(floatvalue);
            bw.Write(strvalue);
            MessageBox.Show("보냈습니다");
        }

        private void Allclose()
        {
            if (bw != null)
            {
                bw.Close();
                bw = null;
            }
            if (br != null)
            {
                br.Close();
                br = null;
            }
            if (ns != null)
            {
                ns.Close();
                ns = null;
            }
            if (tcpClient != null)
            {
                tcpClient.Close();
                tcpClient = null;
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
            for (int i=0;i<iPHost.AddressList.Length; i++)
            {
                if(iPHost.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
                {
                    textBox1.Text = iPHost.AddressList[i].ToString();
                    break;
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            tcpClient = tcpListener.AcceptTcpClient();
            if (tcpClient.Connected)
            {
                textBox2.Text = ((IPEndPoint)tcpClient.Client.RemoteEndPoint).Address.ToString();
                //클라이언트 IP주소 가져오기
            }

            ns = tcpClient.GetStream();
            bw = new BinaryWriter(ns);
            br = new BinaryReader(ns);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            while(true)
            {
                if (tcpClient.Connected)
                {
                    if (DataReceive() == -1)
                    {
                        break;
                    }
                    DataSend();
                }
                else
                {
                    Allclose();
                    break;
                }                
            }
            Allclose();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Allclose();
            tcpListener.Stop();
        }
    }
}
