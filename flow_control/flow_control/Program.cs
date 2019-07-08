using System;
using static System.Console;

namespace flow_control
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int num;
            Write("숫자를 입력하시오:");
            num = Int32.Parse(ReadLine());

            if(num > 0)
            {
                WriteLine("양수입니다");
            }
            else if (num < 0)
            {
                WriteLine("음수입니다");
            }
            else
            {
                WriteLine("0입니다");
            }

            if(num % 2 == 0)
            {
                WriteLine("짝수입니다");
            }
            else
            {
                WriteLine("홀수입니다");
            }
            */
            /*
            object obj = null;
            string str = ReadLine();

            if (int.TryParse(str, out int out_i))
            {
                obj = out_i;
            }
            else if (float.TryParse(str, out float out_f))
            {
                obj = out_f;
            }
            else
                obj = str;

            switch (obj)
            {
                case int i:
                    WriteLine($"{i}는 int 형식 입니다");
                    break;
                case float f:
                    WriteLine($"{f}는 float 형식 입니다");
                    break;
                default:
                    WriteLine($"{obj}는 모르는 형식 입니다");
                    break;
            }
            */

            /* object obj = null;
             string str = ReadLine();

             if (int.TryParse(str, out int out_i))
             {
                 obj = out_i;
             }
             else if (float.TryParse(str, out float out_f))
             {
                 obj = out_f;
             }
             else
                 obj = str;

             switch (obj)
             {
                 case int i:
                     WriteLine($"{i}는 int 형식 입니다");
                     break;
                 case float f when f>=0:
                     WriteLine($"{f}는 양의 float 형식 입니다");
                     break;
                 case float f when f < 0:
                     WriteLine($"{f}는 음의 float 형식 입니다");
                     break;
                 default:
                     WriteLine($"{obj}는 모르는 형식 입니다");
                     break;
             }
             */

            int[] arr = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            foreach(int a in arr)
            {
                WriteLine("{0}", a);
            }
        }
    }
}
