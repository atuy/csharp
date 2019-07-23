using System;
using static System.Console;

namespace ex_delegate
{
    delegate int Sample(int a, int b);

    class Calcul
    {
        public int Plus(int a, int b)
        {
            return a + b;
        }
        public static int Minus(int a, int b)
        {
            return a - b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calcul a = new Calcul();
            Sample sample;

            sample = new Sample(a.Plus);
            WriteLine(sample(3, 4));

            sample = new Sample(Calcul.Minus);
            WriteLine(sample(3, 4));
        }
    }
}
