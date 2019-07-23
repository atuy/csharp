using System;
using static System.Console;

namespace ex_Event_Test
{
    delegate void EventHandler(string message);

    class Sample
    {
        public event EventHandler Something;
        public void DoSomething(int num)
        {
            int tmp = num % 10;

            if (tmp != 0 && tmp %3 == 0)
            {
                Something(String.Format("{0} : 짝", num));
            }
        }
    }
    class Program
    {
        static public void Myhandler(string message)
        {
            WriteLine(message);
        }
        static void Main(string[] args)
        {
            Sample sample = new Sample();

            sample.Something += new EventHandler(Myhandler);

            for(int i=0;i<30; i++)
            {
                sample.DoSomething(i);
            }
        }
    }
}
