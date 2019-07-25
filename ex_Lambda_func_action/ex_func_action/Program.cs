using System;
using static System.Console;

namespace ex_func_action
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int> func1 = () => 10;
            WriteLine($"func1() = {func1()}");

            Func<int, int> func2 = (x) => x * 2; 
            WriteLine($"func2(4) = {func2(4)}");

            Func<double, double, double> func3 = (x, y) => x / y;
            WriteLine($"func3(22,7) = {func3(22,7)}");

            Func<string, string> func4 = (c) => c.ToUpper();
            WriteLine($"func4() = {func4("abcd")}");
            WriteLine();

            Action action1 = () => WriteLine("ACtion()");
            action1();

            int result = 0;
            Action<int> action2 = (x) => result = x * x;
            action2(3);
            WriteLine($"result = {result}");

            Action<double, double> action3 = (x, y) =>
            {
                double pi = x / y;
                WriteLine($"Action<T1, T2>({x},{y}) : {pi}");
            };
            action3(22, 7);
        }
    }
}
