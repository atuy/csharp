using System;
using static System.Console;

namespace inheritance
{
    class Program
    {
        class Bace
        {
            protected string name;

            public Bace(string name)
            {
                this.name = name;
                WriteLine($"{this.name}.Base()");
            }

            public void BaseMethoe()
            {
                WriteLine($"{name}.BaseMethoe()");
            }
        }

        class derived : Bace
        {
            public derived(string name) : base(name)
            {
                WriteLine($"{this.name}.derived()");
            }
            public void derivedMethoe()
            {
                WriteLine($"{name}.derivedMethoe()");
            }
        }
        static void Main(string[] args)
        {
            Bace a = new Bace("a");
            a.BaseMethoe();

            derived b = new derived("b");
            b.BaseMethoe();
            b.derivedMethoe();

        }
    }
}
