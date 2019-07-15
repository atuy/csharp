using System;
using static System.Console;

namespace Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = ("슈퍼맨", 9999);
            WriteLine(a);
            WriteLine($"{a.Item1}, {a.Item2}");
            WriteLine();

            var b = (Name: "박찬명", Age: 24);
            WriteLine($"{b}");
            WriteLine($"{b.Name}, {b.Age}");
            WriteLine();

            var (name, age) = b;
            WriteLine($"{name}, {age}");
            WriteLine();

            b = a;
            WriteLine($"{b.Name}, {b.Age}");
        }
    }
}
