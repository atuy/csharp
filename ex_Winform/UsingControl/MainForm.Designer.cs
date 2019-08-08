namespace UsingControl
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ibiFont = new System.Windows.Forms.Label();
            this.cboFont = new System.Windows.Forms.ComboBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.txtSampleText = new System.Windows.Forms.TextBox();
            this.grpBar = new System.Windows.Forms.GroupBox();
            this.pgDummy = new System.Windows.Forms.ProgressBar();
            this.tbDummy = new System.Windows.Forms.TrackBar();
            this.grpFrom = new System.Windows.Forms.GroupBox();
            this.btnModal = new System.Windows.Forms.Button();
            this.btnModaless = new System.Windows.Forms.Button();
            this.btnMsgbox = new System.Windows.Forms.Button();
            this.grpTreeList = new System.Windows.Forms.GroupBox();
            this.tvDummy = new System.Windows.Forms.TreeView();
            this.lvDummy = new System.Windows.Forms.ListView();
            this.btnAddRoot = new System.Windows.Forms.Button();
            this.btnAddChild = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDummy)).BeginInit();
            this.grpFrom.SuspendLayout();
            this.grpTreeList.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSampleText);
            this.groupBox1.Controls.Add(this.chkItalic);
            this.groupBox1.Controls.Add(this.chkBold);
            this.groupBox1.Controls.Add(this.cboFont);
            this.groupBox1.Controls.Add(this.ibiFont);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "comdobox, checkbox, text box";
            // 
            // ibiFont
            // 
            this.ibiFont.AutoSize = true;
            this.ibiFont.Location = new System.Drawing.Point(3, 17);
            this.ibiFont.Name = "ibiFont";
            this.ibiFont.Size = new System.Drawing.Size(29, 12);
            this.ibiFont.TabIndex = 0;
            this.ibiFont.Text = "Font";
            // 
            // cboFont
            // 
            this.cboFont.FormattingEnabled = true;
            this.cboFont.Location = new System.Drawing.Point(38, 14);
            this.cboFont.Name = "cboFont";
            this.cboFont.Size = new System.Drawing.Size(384, 20);
            this.cboFont.TabIndex = 1;
            this.cboFont.SelectedIndexChanged += new System.EventHandler(this.cboFont_SelectedIndexChanged);
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Location = new System.Drawing.Point(428, 14);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(48, 16);
            this.chkBold.TabIndex = 2;
            this.chkBold.Text = "굵게";
            this.chkBold.UseVisualStyleBackColor = true;
            this.chkBold.CheckedChanged += new System.EventHandler(this.chkBold_CheckedChanged);
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.Location = new System.Drawing.Point(520, 13);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(60, 16);
            this.chkItalic.TabIndex = 3;
            this.chkItalic.Text = "이테릭";
            this.chkItalic.UseVisualStyleBackColor = true;
            this.chkItalic.CheckedChanged += new System.EventHandler(this.chkItalic_CheckedChanged);
            // 
            // txtSampleText
            // 
            this.txtSampleText.Location = new System.Drawing.Point(5, 40);
            this.txtSampleText.Name = "txtSampleText";
            this.txtSampleText.Size = new System.Drawing.Size(765, 21);
            this.txtSampleText.TabIndex = 4;
            this.txtSampleText.Text = "hello C#";
            this.txtSampleText.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // grpBar
            // 
            this.grpBar.Controls.Add(this.tbDummy);
            this.grpBar.Controls.Add(this.pgDummy);
            this.grpBar.Location = new System.Drawing.Point(12, 129);
            this.grpBar.Name = "grpBar";
            this.grpBar.Size = new System.Drawing.Size(776, 139);
            this.grpBar.TabIndex = 5;
            this.grpBar.TabStop = false;
            this.grpBar.Text = "trackbar & ProgrerssBar";
            // 
            // pgDummy
            // 
            this.pgDummy.Location = new System.Drawing.Point(6, 80);
            this.pgDummy.Maximum = 50;
            this.pgDummy.Name = "pgDummy";
            this.pgDummy.Size = new System.Drawing.Size(764, 23);
            this.pgDummy.TabIndex = 0;
            // 
            // tbDummy
            // 
            this.tbDummy.Location = new System.Drawing.Point(6, 29);
            this.tbDummy.Maximum = 50;
            this.tbDummy.Name = "tbDummy";
            this.tbDummy.Size = new System.Drawing.Size(764, 45);
            this.tbDummy.TabIndex = 1;
            this.tbDummy.Scroll += new System.EventHandler(this.TrackBar1_Scroll);
            // 
            // grpFrom
            // 
            this.grpFrom.Controls.Add(this.btnMsgbox);
            this.grpFrom.Controls.Add(this.btnModaless);
            this.grpFrom.Controls.Add(this.btnModal);
            this.grpFrom.Location = new System.Drawing.Point(12, 297);
            this.grpFrom.Name = "grpFrom";
            this.grpFrom.Size = new System.Drawing.Size(776, 121);
            this.grpFrom.TabIndex = 2;
            this.grpFrom.TabStop = false;
            this.grpFrom.Text = "Modal && Modaless";
            // 
            // btnModal
            // 
            this.btnModal.Location = new System.Drawing.Point(6, 56);
            this.btnModal.Name = "btnModal";
            this.btnModal.Size = new System.Drawing.Size(225, 23);
            this.btnModal.TabIndex = 0;
            this.btnModal.Text = "Modal";
            this.btnModal.UseVisualStyleBackColor = true;
            this.btnModal.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnModaless
            // 
            this.btnModaless.Location = new System.Drawing.Point(249, 56);
            this.btnModaless.Name = "btnModaless";
            this.btnModaless.Size = new System.Drawing.Size(264, 23);
            this.btnModaless.TabIndex = 1;
            this.btnModaless.Text = "Moidaless";
            this.btnModaless.UseVisualStyleBackColor = true;
            this.btnModaless.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnMsgbox
            // 
            this.btnMsgbox.Location = new System.Drawing.Point(535, 56);
            this.btnMsgbox.Name = "btnMsgbox";
            this.btnMsgbox.Size = new System.Drawing.Size(235, 23);
            this.btnMsgbox.TabIndex = 2;
            this.btnMsgbox.Text = "Messagebox";
            this.btnMsgbox.UseVisualStyleBackColor = true;
            this.btnMsgbox.Click += new System.EventHandler(this.BtnMsgbox_Click);
            // 
            // grpTreeList
            // 
            this.grpTreeList.Controls.Add(this.btnAddChild);
            this.grpTreeList.Controls.Add(this.btnAddRoot);
            this.grpTreeList.Controls.Add(this.lvDummy);
            this.grpTreeList.Controls.Add(this.tvDummy);
            this.grpTreeList.Location = new System.Drawing.Point(12, 456);
            this.grpTreeList.Name = "grpTreeList";
            this.grpTreeList.Size = new System.Drawing.Size(776, 192);
            this.grpTreeList.TabIndex = 6;
            this.grpTreeList.TabStop = false;
            this.grpTreeList.Text = "TreeView & ListView";
            // 
            // tvDummy
            // 
            this.tvDummy.Location = new System.Drawing.Point(6, 49);
            this.tvDummy.Name = "tvDummy";
            this.tvDummy.Size = new System.Drawing.Size(351, 97);
            this.tvDummy.TabIndex = 0;
            // 
            // lvDummy
            // 
            this.lvDummy.Location = new System.Drawing.Point(392, 49);
            this.lvDummy.Name = "lvDummy";
            this.lvDummy.Size = new System.Drawing.Size(378, 97);
            this.lvDummy.TabIndex = 1;
            this.lvDummy.UseCompatibleStateImageBehavior = false;
            this.lvDummy.View = System.Windows.Forms.View.Details;
            // 
            // btnAddRoot
            // 
            this.btnAddRoot.Location = new System.Drawing.Point(6, 163);
            this.btnAddRoot.Name = "btnAddRoot";
            this.btnAddRoot.Size = new System.Drawing.Size(75, 23);
            this.btnAddRoot.TabIndex = 2;
            this.btnAddRoot.Text = "루트 추가";
            this.btnAddRoot.UseVisualStyleBackColor = true;
            this.btnAddRoot.Click += new System.EventHandler(this.BtnAddRoot_Click);
            // 
            // btnAddChild
            // 
            this.btnAddChild.Location = new System.Drawing.Point(87, 163);
            this.btnAddChild.Name = "btnAddChild";
            this.btnAddChild.Size = new System.Drawing.Size(75, 23);
            this.btnAddChild.TabIndex = 3;
            this.btnAddChild.Text = "자식추가";
            this.btnAddChild.UseVisualStyleBackColor = true;
            this.btnAddChild.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 799);
            this.Controls.Add(this.grpTreeList);
            this.Controls.Add(this.grpFrom);
            this.Controls.Add(this.grpBar);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Control test";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpBar.ResumeLayout(false);
            this.grpBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDummy)).EndInit();
            this.grpFrom.ResumeLayout(false);
            this.grpTreeList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.ComboBox cboFont;
        private System.Windows.Forms.Label ibiFont;
        private System.Windows.Forms.TextBox txtSampleText;
        private System.Windows.Forms.GroupBox grpBar;
        private System.Windows.Forms.TrackBar tbDummy;
        private System.Windows.Forms.ProgressBar pgDummy;
        private System.Windows.Forms.GroupBox grpFrom;
        private System.Windows.Forms.Button btnModaless;
        private System.Windows.Forms.Button btnModal;
        private System.Windows.Forms.Button btnMsgbox;
        private System.Windows.Forms.GroupBox grpTreeList;
        private System.Windows.Forms.Button btnAddChild;
        private System.Windows.Forms.Button btnAddRoot;
        private System.Windows.Forms.ListView lvDummy;
        private System.Windows.Forms.TreeView tvDummy;
    }
}

