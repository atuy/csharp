using System;
using System.Threading;
using static System.Console;

namespace AbortingThread
{
    class SideTAsk
    {
        int count;
        public SideTAsk(int count)
        {
            this.count = count;
        }
        public void KeepAlive()
        {
            try
            {
                while(count > 0)
                {
                    WriteLine($"{count--} left");
                    Thread.Sleep(10);
                }
                WriteLine("count : 0");
            }
            catch (ThreadAbortException e)
            {
                WriteLine(e);
                Thread.ResetAbort();
            }
            finally
            {
                WriteLine("Clearing");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SideTAsk task = new SideTAsk(100);
            Thread t1 = new Thread(new ThreadStart(task.KeepAlive));
            t1.IsBackground = false;

            WriteLine("start");
            t1.Start();
            Thread.Sleep(10);

            WriteLine("Aborting thread");
            t1.Abort();

            WriteLine("wating until thread stops");
            t1.Join();

            WriteLine("fin");
        }
    }
}
