using System;
using static System.Console;

namespace ex_duck_typing
{
    class Duck
    {
        public void Walk()
        {
            WriteLine(this.GetType() + ".walk()");
        }
        public void Swim()
        {
            WriteLine(this.GetType() + ".Swim()");
        }
        public void Quack()
        {
            WriteLine(this.GetType() + ".Quack()");
        }
    }
    class Mallard : Duck
    {

    }
    class Robot
    {
        public void Walk()
        {
            WriteLine("Robot.walk()");
        }
        public void Swim()
        {
            WriteLine("Robot.Swim()");
        }
        public void Quack()
        {
            WriteLine("Robot .Quack()");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            dynamic[] arr = new dynamic[] { new Duck(), new Mallard(), new Robot() };

            foreach(dynamic tmp in arr)
            {
                WriteLine(tmp.GetType());
                tmp.Walk();
                tmp.Swim();
                tmp.Quack();
                WriteLine();
            }
        }
    }
}
