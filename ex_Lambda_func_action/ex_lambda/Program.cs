using System;
using static System.Console;

namespace ex_lambda
{
    class Program
    {
        delegate int calcul(int a, int b);
        delegate string Concatenate(string[] args);
        static void Main(string[] args)
        {
            calcul calcul = (a, b) => a + b;

            WriteLine($"{3} + {4} = {calcul(3, 4)}");

            Concatenate concatenate = (arr) =>
            {
                string result = "";
                foreach (string s in arr)
                {
                    result += s;
                }
                return result;
            };
            WriteLine(concatenate(args));
        }
    }
}
