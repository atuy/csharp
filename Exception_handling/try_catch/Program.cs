using System;
using static System.Console;

namespace try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            try
            {
                for(int i=0;i<arr.Length+1;i++)
                {
                    WriteLine(arr[i]);
                }
            }
            catch(IndexOutOfRangeException e)
            {
                WriteLine($"예외발생 {e.Message}");
            }

            WriteLine("종료");
        }
    }
}
