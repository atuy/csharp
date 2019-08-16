using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using FUP;

namespace ex
{
    public partial class Form1 : Form
    {
        string Server_IP = "127.0.0.1";
        const int CHUNK_SIZE = 4096;
        string filepath = "";
        const int serverPort = 5425;

        public Form1()
        {
            InitializeComponent();
        }

        private void ToolTip1_Popup(object sender, PopupEventArgs e)
        {
            toolTip1.SetToolTip(input_serverIP, "서버 IP를 입력하세요");
        }

        private void Btn_serverIP_Click(object sender, EventArgs e)
        {
            Server_IP = (string)input_serverIP.Text;
            input_serverIP.Text = "서버 IP\t" + Server_IP;
        }

        private void Input_serverIP_TextChanged(object sender, EventArgs e)
        {

        }
        private void Btn_filepath_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                File_path.Text = dlg.SafeFileName;
                filepath = File_path.Text;
            }
        }
        private void LB_servername_Click(object sender, EventArgs e)
        {

        }
        private void ProgressBar1_Click(object sender, EventArgs e)
        {

        }
        private void Btn_sendfile_Click(object sender, EventArgs e)
        {
            try
            {
                IPEndPoint clientAddress = new IPEndPoint(0, 0);
                IPEndPoint serverAddress =
                    new IPEndPoint(IPAddress.Parse(Server_IP), serverPort);

                Console.WriteLine("클라이언트: {0}, 서버:{1}",
                    clientAddress.ToString(), serverAddress.ToString());

                uint msgId = 0;

                FUP.Message reqMsg = new FUP.Message();
                reqMsg.Body = new BodyRequest()
                {
                    FILESIZE = new FileInfo(filepath).Length,
                    FILENAME = System.Text.Encoding.Default.GetBytes(filepath)
                };
                reqMsg.Header = new Header()
                {
                    MSGID = msgId++,
                    MSGTYPE = CONSTANTS.REQ_FILE_SEND,
                    BODYLEN = (uint)reqMsg.Body.GetSize(),
                    FRAGMENTED = CONSTANTS.NOT_FRAGMENTED,
                    LASTMSG = CONSTANTS.LASTMSG,
                    SEQ = 0
                };

                TcpClient client = new TcpClient(clientAddress);
                client.Connect(serverAddress);

                NetworkStream stream = client.GetStream();

                MessageUtil.Send(stream, reqMsg);

                FUP.Message rspMsg = MessageUtil.Receive(stream);

                if (rspMsg.Header.MSGTYPE != CONSTANTS.REP_FILE_SEND)
                {
                    LB_serverST.Text = "정상적인 서버 응답이 아닙니다.";                  
                    return;
                }

                if (((BodyResponse)rspMsg.Body).RESPONSE == CONSTANTS.DENIED)
                {
                    LB_serverST.Text = "서버에서 파일 전송을 거부했습니다.";
                    return;
                }
                LB_serverST.Text = "서버 접속 성공";

                using (Stream fileStream = new FileStream(filepath, FileMode.Open))
                {
                    byte[] rbytes = new byte[CHUNK_SIZE];

                    long readValue = BitConverter.ToInt64(rbytes, 0);

                    int totalRead = 0;
                    ushort msgSeq = 0;
                    byte fragmented =
                        (fileStream.Length < CHUNK_SIZE) ?
                        CONSTANTS.NOT_FRAGMENTED : CONSTANTS.FRAGMENTED;
                    while (totalRead < fileStream.Length)
                    {
                        int read = fileStream.Read(rbytes, 0, CHUNK_SIZE);
                        totalRead += read;
                        FUP.Message fileMsg = new FUP.Message();

                        byte[] sendBytes = new byte[read];
                        Array.Copy(rbytes, 0, sendBytes, 0, read);

                        fileMsg.Body = new BodyData(sendBytes);
                        fileMsg.Header = new Header()
                        {
                            MSGID = msgId,
                            MSGTYPE = CONSTANTS.FILE_SEND_DATA,
                            BODYLEN = (uint)fileMsg.Body.GetSize(),
                            FRAGMENTED = fragmented,
                            LASTMSG = (totalRead < fileStream.Length) ?
                                      CONSTANTS.NOT_LASTMSG :
                                      CONSTANTS.LASTMSG,
                            SEQ = msgSeq++
                        };

                        progressBar1.Value = (int)(((double)totalRead / (double)fileStream.Length) * progressBar1.Maximum);

                        MessageUtil.Send(stream, fileMsg);
                    }

                    Console.WriteLine();

                    FUP.Message rstMsg = MessageUtil.Receive(stream);

                    BodyResult result = ((BodyResult)rstMsg.Body);
                    Console.WriteLine("파일 전송 성공 : {0}",
                        result.RESULT == CONSTANTS.SUCCESS);
                }

                stream.Close();
                client.Close();
            }
            catch (SocketException ae)
            {
                Console.WriteLine(ae);
            }

            MessageBox.Show("클라이언트를 종료합니다");
        }
    }
}
