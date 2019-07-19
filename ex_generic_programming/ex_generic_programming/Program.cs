using System;
using static System.Console;

namespace ex_generic_programming
{
    class Program
    {
        static void Copyarr<T>(T[] source, T[] target)
        {
            for (int i=0;i<source.Length;i++)
            {
                target[i] = source[i];
            }
        }
        static void Main(string[] args)
        {
            int[] source = { 1, 2, 3, 4, 5, 6, 7 };
            int[] target = new int[source.Length];

            Copyarr<int>(source, target);

            foreach(int num in target)
            {
                WriteLine(num);
            }
            string[] source2 = { "하나", "둘", "셋", "넷", "다섯", "여섯" };
            string[] target2 = new string[source2.Length];

            Copyarr<string>(source2, target2);
            foreach (string num in target2)
            {
                WriteLine(num);
            }
        }
    }
}
