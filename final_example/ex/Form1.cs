using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex
{
    public partial class Form1 : Form
    {
        string Server_IP = "127.0.0.1";
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

        private void LB_servername_Click(object sender, EventArgs e)
        {

        }
    }
}
