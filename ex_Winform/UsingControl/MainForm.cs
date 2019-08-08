using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingControl
{
    public partial class MainForm : Form
    {
        Random random = new Random(37);
        public MainForm()
        {
            InitializeComponent();

            lvDummy.Columns.Add("Name");
            lvDummy.Columns.Add("Depth");
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var Fonts = FontFamily.Families;
            foreach (FontFamily font in Fonts)
                cboFont.Items.Add(font.Name);
        }

        void ChangeFont()
        {
            if (cboFont.SelectedIndex < 0)
                return;

            FontStyle style = FontStyle.Regular;
            if (chkBold.Checked)
                style |= FontStyle.Bold;
            if (chkItalic.Checked)
                style |= FontStyle.Italic;

            txtSampleText.Font =
                new Font((string)cboFont.SelectedItem, 10,
                    style);
        }
        private void cboFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            pgDummy.Value = tbDummy.Value;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Text = "Modal Form";
            form.Width = 300;
            form.Height = 100;
            form.BackColor = Color.Red;
            form.ShowDialog();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Text = "Modaless Form";
            form.Width = 300;
            form.Height = 300;
            form.BackColor = Color.Green;
            form.Show();
        }

      

        private void BtnMsgbox_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtSampleText.Text, "messageBox test", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            if(tvDummy.SelectedNode == null)
            {
                MessageBox.Show("선택된 노드가 없습니다.", "Treeview test", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tvDummy.SelectedNode.Nodes.Add(random.Next().ToString());
            tvDummy.SelectedNode.Expand();
            TreeToList();
        }

        private void BtnAddRoot_Click(object sender, EventArgs e)
        {
            tvDummy.Nodes.Add(random.Next().ToString());
            TreeToList();
        }

        void TreeToList()
        {
            lvDummy.Items.Clear();
            foreach (TreeNode node in tvDummy.Nodes)
                TreeToList(node);
        }
        void TreeToList(TreeNode Node)
        {
            lvDummy.Items.Add(
                    new ListViewItem(
                        new string[] { Node.Text,
                            Node.FullPath.Count(f => f == '\\').ToString() }));

            foreach (TreeNode node in Node.Nodes)
            {
                TreeToList(node);
            }
        }
    }
}
