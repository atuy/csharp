using System;
using static System.Console;
namespace DataType
{
    class Program
    {
        static void Main(string[] args)
        {
            //15가지 기본자료 형식

            //정수타입 예제
            sbyte a = -10;
            byte b = 40;

            WriteLine($"a = {a}, b = {b}");

            short c = -30000;
            ushort d = 60000;

            WriteLine($"c = {c}, d = {d}");

            int e = -1000_0000;
            uint f = 3_0000_0000;

            WriteLine($"e = {e}, f = {f}");

            long g = -5000_0000_0000;
            ulong h = 200_0000_0000_0000_0000;

            WriteLine($"g = {g}, h = {h}");

            WriteLine();
            WriteLine();
            //2진수 10진수 16진수
            byte b_a = 240;                             //10
            byte b_b = 0b11110000;                      //2
            byte b_c = 0xF0;                            //16
            uint b_d = 0x1234abcd;
            WriteLine($"b_a = {b_a}, b_b ={b_b}, b_c={b_c}, b_d = {b_d}");

            WriteLine();
            WriteLine();
            //오버플로우
            uint c_a = uint.MaxValue;
            WriteLine($"c_a = {c_a}");
            c_a += 1;
            WriteLine($"c_a = {c_a}");

        }
    }
}
