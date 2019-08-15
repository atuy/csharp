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
            this.input_serverIP.Size = new System.Drawing.Size(593, 21);
            this.input_serverIP.TabIndex = 1;
            this.input_serverIP.Text = "0.0.0.0";
            this.input_serverIP.TextChanged += new System.EventHandler(this.Input_serverIP_TextChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.ToolTip1_Popup);
            // 
            // btn_serverIP
            // 
            this.btn_serverIP.Location = new System.Drawing.Point(688, 4);
            this.btn_serverIP.Name = "btn_serverIP";
            this.btn_serverIP.Size = new System.Drawing.Size(100, 23);
            this.btn_serverIP.TabIndex = 2;
            this.btn_serverIP.Text = "IP 입력";
            this.btn_serverIP.UseVisualStyleBackColor = true;
            this.btn_serverIP.Click += new System.EventHandler(this.Btn_serverIP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_serverIP);
            this.Controls.Add(this.input_serverIP);
            this.Controls.Add(this.LB_servername);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_servername;
        private System.Windows.Forms.TextBox input_serverIP;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_serverIP;
    }
}

