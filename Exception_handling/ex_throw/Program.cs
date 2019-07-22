using System;
using static System.Console;

namespace ex_throw
{
    class Program
    {
        static void Dosamething(int arg)
        {
            if(arg<10)
            {
                WriteLine($"arg : {arg}");
            }
            else
            {
                throw new Exception("arg가 10보다 큽니다");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Dosamething(1);
                Dosamething(3);
                Dosamething(5);
                Dosamething(7);
                Dosamething(9);
                Dosamething(11);
                Dosamething(13);
                Dosamething(15);
                Dosamething(17);
                Dosamething(19);
            }
            catch(Exception e)
            {
                WriteLine(e.Message);
            }
        }
    }
}
