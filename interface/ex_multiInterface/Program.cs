using System;

namespace ex_multiInterface
{
    interface IRunnable
    {
        void run();
    }
    interface IFlyable
    {
        void fly();
    }
    class Flyingcar : IRunnable, IFlyable
    {
        public void run()
        {
            Console.WriteLine("run");
        }
        public void fly()
        {
            Console.WriteLine("fly");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Flyingcar a = new Flyingcar();
            a.run();
            a.fly();

            IRunnable b = a as IRunnable;
            b.run();

            IFlyable c = a as IFlyable;
            c.fly();
        }
    }
}
