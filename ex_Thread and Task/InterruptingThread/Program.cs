using System;
using System.Security.Permissions;
using System.Threading;
using static System.Console;

namespace InterruptingThread
{
    class SideTask
    {
        int count;

        public SideTask(int count)
        {
            this.count = count;
        }

        public void KeepAlive()
        {
            try
            {
                WriteLine("Running thread isn't gonna be interrupted");
                Thread.SpinWait(1000000);

                while (count > 0)
                {
                    WriteLine($"{count--} left");

                    WriteLine("Entering into WaitJoinSleep State...");
                    Thread.Sleep(10);
                }
                WriteLine("Count : 0");
            }
            catch (ThreadInterruptedException e)
            {
                WriteLine(e);
            }
            finally
            {
                WriteLine("Clearing resource...");
            }
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            SideTask task = new SideTask(100);
            Thread t1 = new Thread(new ThreadStart(task.KeepAlive));
            t1.IsBackground = false;

            WriteLine("Starting thread...");
            t1.Start();

            Thread.Sleep(100);

            WriteLine("Interrupting thread...");
            t1.Interrupt();

            WriteLine("Wating until thread stops...");
            t1.Join();

            WriteLine("Finished");
        }
    }
}
