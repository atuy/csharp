using System;
using static System.Console;
namespace EX_method
{
    class Program
    {
        public static double square(double num)
        {
            return num * num;
        }
        public static void Mean(double a, double b, double c, double d, double e, ref double mean)
        {
            mean = (a + b + c + d + e) / 5;
        }
        static void Main(string[] args)
        {
            WriteLine("1번문제");
            Write("수를 입력해 주세요 : ");
            double input = double.Parse(ReadLine());
            WriteLine($"제곱 값은 = {square(input)}입니다");
            WriteLine();

            WriteLine("2번문제");
            double mean = 0;
            Mean(1, 2, 3, 4, 5, ref mean);
            WriteLine($"평균은 = {mean}");

            
        }
    }
}
