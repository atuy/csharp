namespace ex
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LB_servername = new System.Windows.Forms.Label();
            this.input_serverIP = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_serverIP = new System.Windows.Forms.Button();
            this.LB_serverST = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.File_path = new System.Windows.Forms.TextBox();
            this.Btn_filepath = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Btn_sendfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_servername
            // 
            this.LB_servername.AutoSize = true;
            this.LB_servername.Location = new System.Drawing.Point(12, 9);
            this.LB_servername.Name = "LB_servername";
            this.LB_servername.Size = new System.Drawing.Size(72, 12);
            this.LB_servername.TabIndex = 0;
            this.LB_servername.Text = "서버 IP 주소";
            this.LB_servername.Click += new System.EventHandler(this.LB_servername_Click);
            // 
            // input_serverIP
            // 
            this.input_serverIP.Location = new System.Drawing.Point(89, 6);
            this.input_serverIP.Name = "input_serverIP";
            this.input_serverIP.Size = new System.Drawing.Size(224, 21);
            this.input_serverIP.TabIndex = 1;
            this.input_serverIP.Text = "127.0.0.1";
            this.input_serverIP.TextChanged += new System.EventHandler(this.Input_serverIP_TextChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.ToolTip1_Popup);
            // 
            // btn_serverIP
            // 
            this.btn_serverIP.Location = new System.Drawing.Point(319, 4);
            this.btn_serverIP.Name = "btn_serverIP";
            this.btn_serverIP.Size = new System.Drawing.Size(100, 23);
            this.btn_serverIP.TabIndex = 2;
            this.btn_serverIP.Text = "IP 입력";
            this.btn_serverIP.UseVisualStyleBackColor = true;
            this.btn_serverIP.Click += new System.EventHandler(this.Btn_serverIP_Click);
            // 
            // LB_serverST
            // 
            this.LB_serverST.AutoSize = true;
            this.LB_serverST.Location = new System.Drawing.Point(166, 46);
            this.LB_serverST.Name = "LB_serverST";
            this.LB_serverST.Size = new System.Drawing.Size(69, 12);
            this.LB_serverST.TabIndex = 3;
            this.LB_serverST.Text = "서버 접속중";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "파일경로";
            // 
            // File_path
            // 
            this.File_path.Location = new System.Drawing.Point(89, 72);
            this.File_path.Name = "File_path";
            this.File_path.Size = new System.Drawing.Size(224, 21);
            this.File_path.TabIndex = 5;
            // 
            // Btn_filepath
            // 
            this.Btn_filepath.Location = new System.Drawing.Point(319, 70);
            this.Btn_filepath.Name = "Btn_filepath";
            this.Btn_filepath.Size = new System.Drawing.Size(100, 23);
            this.Btn_filepath.TabIndex = 6;
            this.Btn_filepath.Text = "...";
            this.Btn_filepath.UseVisualStyleBackColor = true;
            this.Btn_filepath.Click += new System.EventHandler(this.Btn_filepath_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(14, 165);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(405, 23);
            this.progressBar1.Step = 100;
            this.progressBar1.TabIndex = 7;
            this.progressBar1.Click += new System.EventHandler(this.ProgressBar1_Click);
            // 
            // Btn_sendfile
            // 
            this.Btn_sendfile.Location = new System.Drawing.Point(14, 254);
            this.Btn_sendfile.Name = "Btn_sendfile";
            this.Btn_sendfile.Size = new System.Drawing.Size(409, 23);
            this.Btn_sendfile.TabIndex = 8;
            this.Btn_sendfile.Text = "파일 전송";
            this.Btn_sendfile.UseVisualStyleBackColor = true;
            this.Btn_sendfile.Click += new System.EventHandler(this.Btn_sendfile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 320);
            this.Controls.Add(this.Btn_sendfile);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Btn_filepath);
            this.Controls.Add(this.File_path);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LB_serverST);
            this.Controls.Add(this.btn_serverIP);
            this.Controls.Add(this.input_serverIP);
            this.Controls.Add(this.LB_servername);
            this.Name = "Form1";
            this.Text = "파일전송";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_servername;
        private System.Windows.Forms.TextBox input_serverIP;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_serverIP;
        private System.Windows.Forms.Label LB_serverST;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox File_path;
        private System.Windows.Forms.Button Btn_filepath;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button Btn_sendfile;
    }
}

