using System;

namespace this_constructor
{
    class Program
    {
        class my
        {
            int a, b, c;

            public my()
            {
                this.a = 5425;
                Console.WriteLine("my()");
            }
            public my(int b) : this()
            {
                this.b = b;
                Console.WriteLine("my({b})");
            }
            public my(int b,int c ):this(b)
            {
                this.c = c;
                Console.WriteLine("my({b},{c})");
            }
            public void print()
            {
                Console.WriteLine($"a : {a}, b : {b}, c : {c}");
            }
        }
        static void Main(string[] args)
        {
            my a = new my();
            a.print();
            Console.WriteLine();

            my b = new my(1);
            b.print();
            Console.WriteLine();

            my c = new my(10,20);
            c.print();
            Console.WriteLine();
        }
    }
}
