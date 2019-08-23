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

namespace WinF_thread_client
{
    public partial class Form1 : Form
    {
        private TcpClient tcpClient = null;
        private NetworkStream ns = null;
        private BinaryWriter bw = null;
        private BinaryReader br = null;

        string msg;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                tcpClient = new TcpClient(textBox1.Text, 3000);
                if (tcpClient.Connected)
                {
                    ns = tcpClient.GetStream();
                    br = new BinaryReader(ns);
                    bw = new BinaryWriter(ns);
                    MessageBox.Show("서버 접속 성공");
                }
                else
                {
                    MessageBox.Show("서버 접속 실패");
                }
            }
            else
            {
                MessageBox.Show("서버 IP를 입력해 주세요");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(textBox3.Text))
            {
                bw.Write(textBox3.Text + "\r\n");
                msg = br.ReadString();
                textBox2.Text += msg;                
                textBox3.Text = "";
            }
            else
            {
                textBox3.Text = "";
            }                                   
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tcpClient != null)
            {                
                bw.Close();
                br.Close();
                ns.Close();
                tcpClient.Close();
            }
        }


        private void TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Button1_Click(sender, e);
            }
        }

        private void TextBox3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!String.IsNullOrWhiteSpace(textBox3.Text))
                {
                    bw.Write(textBox3.Text);
                    msg = br.ReadString();
                    textBox2.Text += msg;
                    textBox3.Text = "";
                }
                else
                {
                    textBox3.Text = "";
                }
            }
        }
    }
}
