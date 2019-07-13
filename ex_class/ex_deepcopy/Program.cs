using System;
using static System.Console;

namespace ex_deepcopy
{
    class my
    {
        public int num1;
        public int num2;

        public my Deepcopy()
        {
            my newcopy = new my();
            newcopy.num1 = this.num1;
            newcopy.num2 = this.num2;

            return newcopy;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("shallow copy");
            {
                my source = new my();
                source.num1 = 10;
                source.num2 = 20;

                my target = source;
                target.num2 = 30;

                WriteLine($"{source.num1} {source.num2}");
                WriteLine($"{target.num1} {target.num2}");
                WriteLine();
            }
            WriteLine("deep copy");
            {
                my source = new my();
                source.num1 = 10;
                source.num2 = 20;

                my target = source.Deepcopy();
                target.num2 = 30;

                WriteLine($"{source.num1} {source.num2}");
                WriteLine($"{target.num1} {target.num2}");
                WriteLine();
            }

        }
    }
}
