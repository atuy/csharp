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
            WriteLine($"a type = {a.GetType()}, b type = {b.GetType()}");
            WriteLine($"a max = {sbyte.MaxValue} , a min = {sbyte.MinValue}");
            WriteLine($"b max = {byte.MaxValue} , b min = {byte.MinValue}");
            WriteLine();
            short c = -30000;
            ushort d = 60000;

            WriteLine($"c = {c}, d = {d}");
            WriteLine($"c type = {c.GetType()}, d type = {d.GetType()}");
            WriteLine($"c max = {short.MaxValue}, c min = {short.MinValue}");
            WriteLine($"d max = {ushort.MaxValue}, d max = {ushort.MinValue}");
            WriteLine();

            int e = -1000_0000;
            uint f = 3_0000_0000;

            WriteLine($"e = {e}, f = {f}");
            WriteLine($"e type = {e.GetType()}, f type = {f.GetType()}");
            WriteLine($"e max = {int.MaxValue} , e min = {int.MinValue}");
            WriteLine($"f max = {uint.MaxValue}, f min = {uint.MinValue}");
            WriteLine();

            long g = -5000_0000_0000;
            ulong h = 200_0000_0000_0000_0000;

            WriteLine($"g = {g}, h = {h}");
            WriteLine($"g type = {g.GetType()}, h type = {h.GetType()}");
            WriteLine($"g max = {long.MaxValue} , g min = {long.MinValue}");
            WriteLine($"h max = {ulong.MaxValue} , h min = {ulong.MinValue}");
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
            //부동 소수점 형식
            float c_a = 3.14159265358979323846f;
            double c_b = 3.14159265358979323846;
            decimal c_c = 3.141592653589793238462643383279m;
            WriteLine($"c_a = {c_a} , c_b = {c_b} , c_c = {c_c}");


            WriteLine();
            WriteLine();
            //문자형식과 문자열
            char d_a = 'a';
            char d_b = 'e';
            char d_c = 'i';
            char d_d = 'o';
            char d_e = 'u';

            Write(d_a);
            Write(d_b);
            Write(d_c);
            Write(d_d);
            Write(d_e);
            WriteLine();

            string e_a = "aeiou";
            WriteLine(e_a);

            WriteLine();
            WriteLine();
            //논리형식
            bool f_a = true;
            bool f_b = false;

            WriteLine($"f_a = {f_a} , f_b = {f_b}");


            WriteLine();
            WriteLine();
            //object
            object g_a = 123;
            object g_b = 3.141592653589793238462643383279m;
            object g_c = true;
            object g_d = "안녕하세여";

            WriteLine($"g_a = {g_a} , g_b = {g_b} , g_c = {g_c} , g_d = {g_d}");


            WriteLine();
            WriteLine();
            //박싱 언박싱
            int h_a = 123;
            object h_b = (object)h_a;
            int h_c = (int)h_b;

            WriteLine($"h_a = {h_a} , h_b = {h_b} , h_c = {h_c}");


            WriteLine();
            WriteLine();
            //문자열을 숫자, 숫자를 문자열
            int i_a = 123;
            string i_b = i_a.ToString();
            WriteLine($"i_a = {i_a}, {i_a.GetType()} , i_b = {i_b}, {i_b.GetType()}");

            float i_c = 3.14f;
            string i_d = i_c.ToString();
            WriteLine($"i_c = {i_c}, {i_c.GetType()} , i_d = {i_d}, {i_d.GetType()}");

            string i_e = "123456";
            int i_f = Convert.ToInt32(i_e);
            WriteLine($"i_e = {i_e}, {i_e.GetType()} , i_f = {i_f}, {i_f.GetType()}");

            i_f = int.Parse(i_e);
            WriteLine($"i_e = {i_e}, {i_e.GetType()} , i_f = {i_f}, {i_f.GetType()}");

            string i_g = "1.23456";
            float i_h = float.Parse(i_g);
            WriteLine($"i_g = {i_g}, {i_g.GetType()} , i_h = {i_h}, {i_h.GetType()}");

            WriteLine();
            WriteLine();
            //널 조건부 연산자
            System.Collections.ArrayList check =null;
            check?.Add("야구");
            check?.Add("축구");
            WriteLine($"count : {check?.Count}");
            WriteLine($"{check?[0]}");
            WriteLine($"{check?[1]}");

            check = new System.Collections.ArrayList();
            check?.Add("야구");
            check?.Add("축구");
            WriteLine($"count : {check?.Count}");
            WriteLine($"{check?[0]}");
            WriteLine($"{check?[1]}");


            WriteLine();
            WriteLine();
            //널 병합 연산자
            int? num = null;
            WriteLine($"{num ?? -1}");

            num = 50;
            WriteLine($"{num ?? -1}");

            string tmp = null;
            WriteLine($"{tmp ?? "def"}");

            tmp = "a";
            WriteLine($"{tmp ?? "def"}");

        }
    }
}
