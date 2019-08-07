using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace FormBackground
{
    class Program : Form
    {
        Random random;
        public Program()
        {
            random = new Random();

            this.MouseWheel += new MouseEventHandler(Program_MouseWheel);
            this.MouseDown += new MouseEventHandler(Program_MouseDown);
        }
        void Program_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Color oldColor = this.BackColor;
                this.BackColor = Color.FromArgb(random.Next(0, 255), 
                                                random.Next(0, 255), 
                                                random.Next(0, 255));
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (this.BackgroundImage != null)
                {
                    this.BackgroundImage = null;
                    return;
                }
                string file = "sample.jpg";

                if (System.IO.File.Exists(file) == false)
                {
                    MessageBox.Show("이미지가 없습니다.");
                }
                else
                {
                    this.BackgroundImage = Image.FromFile(file);
                }
            }
        }
        void Program_MouseWheel(object sender, MouseEventArgs e)
        {
            this.Opacity = this.Opacity + (e.Delta > 0 ? 0.1 : -0.1);
            Console.WriteLine($"Opacity : {this.Opacity}");
        }
        static void Main(string[] args)
        {
            Application.Run(new Program());
        }
    }
}
