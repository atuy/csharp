using System;
using static System.Console;

namespace ex_throwExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int? a = null;
                int b = a ?? throw new ArgumentNullException();
            }
            catch(ArgumentNullException e)
            {
                WriteLine(e);
            }

            try
            {
                int[] arr = new[] { 1, 2, 3 };
                int index = 4;
                int value = arr[index >= 0 && index < 3 ? index : throw new IndexOutOfRangeException()];
            }
            catch(IndexOutOfRangeException e)
            {
                WriteLine(e.Message);
            }
        }
    }
}
