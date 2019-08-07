using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormSize
{
    class Program : Form
    {
        static void Main(string[] args)
        {
            Program win = new Program();
            win.Width = 500;
            win.Height = 300;

            win.MouseDown += new MouseEventHandler(win_MouseDown);

            Application.Run(win);
        }

        static void win_MouseDown(object sender, MouseEventArgs e)
        {
            Form form = (Form)sender;
            int oldW = form.Width;
            int oldH = form.Height;

            if (e.Button == MouseButtons.Left)
            {
                if(oldW < oldH)
                {
                    form.Width = oldH;
                    form.Height = oldW;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if(oldH < oldW)
                {
                    form.Width = oldH;
                    form.Height = oldW;
                }
            }

            Console.WriteLine("윈도우 크기가 변경되었습니다");
            Console.WriteLine($"W : {form.Width},  H : {form.Height}");
        }
    }
}
