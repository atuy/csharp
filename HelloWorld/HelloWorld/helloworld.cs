﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace HelloWorld
{
    class helloworld
    {
        static void Main(string[] args)
        {
            String a;
            a = ReadLine();
            if (a.Length == 0)
            {
                Console.WriteLine("사용법 : hellowrold.exe <이름>");
                return;
            }
            WriteLine("hello, {0}!", a);

            WriteLine("여러분 안녕하세요?");
            WriteLine("반갑습니다");
        }
    }
}
