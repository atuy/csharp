using System;
using System.Threading;
using static System.Console;

namespace basicthread
{
    class Program
    {
        static void Something()
        {
            for (int i=0;i<10;i++)
            {
                WriteLine($"something : {i}");
                Thread.Sleep(100);
            }
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(Something));
            WriteLine("start");

            t1.Start();
            for (int i = 0; i<10;i++)
            {
                WriteLine($"main : {i}");
                Thread.Sleep(100);
            }
            WriteLine("wating until thread stops");
            t1.Join();

            WriteLine("Fin");
        }
    }
}
