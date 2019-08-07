using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

namespace UsingApplication
{
    class Program : Form
    {
        static void Main(string[] args)
        {
            Program form = new Program();
            form.Click += new EventHandler(
                (sender, EventArgs) =>
                {
                    WriteLine("Closing Window");
                    Application.Exit();
                }
                );

            WriteLine("start Window app");
            Application.Run(form);

            WriteLine("Exit window");
        }
    }
}
