using System;
using static System.Console;

namespace static_method
{
    class Program
    {
        class global
        {
            public static int count = 0;
        }
        class ClassA
        {
            public ClassA()
            {
                global.count++;
            }
        }
        class ClassB
        {
            public ClassB()
            {
                global.count++;
            }
        }
        static void Main(string[] args)
        {
            WriteLine($"global.count : {global.count}");

            new ClassA();
            new ClassB();
            new ClassA();
            new ClassB();
            WriteLine($"global.count : {global.count}");
        }
    }
}
